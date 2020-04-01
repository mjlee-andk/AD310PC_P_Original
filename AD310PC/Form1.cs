using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using myResource = AD310AD.Properties.Resources;
using mySetting = AD310AD.Properties.Settings;
using System.Globalization;

namespace AD310AD
{
    public partial class Form1 : Form
    {
        Class1 rs = new Class1();           // 인스턴스
        
        public delegate void msgCallback(string str);

        //StreamWriter writeLog = new StreamWriter("logdata.txt");    // 로그 기록
       
        string dispMsg = string.Empty;              // 표시 데이터 변수
        string temp = string.Empty;                 // 임시 변수

        // 아래로 상태 표시 변수
        bool stable = false;
        bool zero = false;
        bool net = false;
        bool hold = false;
        bool hg = false;
       
        // 단위 표시
        bool kg = false;        
        bool g = false;
        bool t = false;
        bool kgReady = false;

        bool doSpan = false;                        // 스팬 적용
        bool funcMode = false;                      // 설정 모드
        bool serialMode = false;                    // 통신설정 모드
        bool basicMode = false;                     // 기본설정 모드
        bool compMode = false;                      // 외부출력 모드
        bool doCalMode = false;                     // 캘리브레이션 진행 
        bool verMode = false;                       // 버전
        bool modeInitF = false;                     // init F 모드
        bool modeInitA = false;                     // init All 모드
        bool initF = false;                         // init 응답 플래그
        int err_cnt = 0;

        int next = 0;                               // 타이머 인덱스 지정 변수
        int cnt100ms = 0;                           // 100ms 카운터

        string[] fDataArray = new string[20];       // f펑션 정보 배열
        string[] cfDataArray = new string[11];      // cf 펑션 정보 배열

        bool doInit = false;                        // 초기화 루틴 진입

        int standbySec = 0;                         // 스탠바이 시간체크 변수
        bool stanby = false;                        // 스탠바이 플래그

        bool ver = true;

        // 초기화 함수 상수 정의
        public const int SERIAL = 1;
        public const int BASIC = 2;
        public const int COMP = 3;
        public const int CAL = 4;

        public Form1()
        {
            InitializeComponent();  
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            foreach (string str in SerialPort.GetPortNames())
            {
                ((ComboBox)cmbPort).Items.Add(str);
            }

            checkBox1.Text = "설정 보이기";
            tabControl1.Visible = false;
            base.Size = new Size(757, 400);

            // 이전 설정값 읽어오기
            cmbPort.Text = mySetting.Default.PortDefault;
            cmbBaudrate.Text = mySetting.Default.BpsDefault;
            cmbDatabits.Text = mySetting.Default.LengthDefault;
            cmbParity.Text = mySetting.Default.ParityDefault;
            cmbStopbits.Text = mySetting.Default.StopDefault;
            cmbTerminator.Text = mySetting.Default.TerminatorDefault;

        }

        // 시리얼 수신 이벤트
        // 기본적으로 다음의 과정을 통해 데이터를 표시
        // 수신 - 데이터 취합(헤더구분) - 데이터 형성
        // 수신 : serialPort1_DataReceived (이벤트 동작)
        // 데이터 취합(헤더구분) : callThread
        // 데이터 형성 : makeFormat
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Thread msgThread = new Thread(new ParameterizedThreadStart(callThread));
            string rxData = string.Empty;
            stanby = false;
            standbySec = 0; 

            if (serialPort1.IsOpen)
            {
                try
                {
                    rxData = serialPort1.ReadTo(rs.Terminator);
                }
                catch
                {
                    rxData = string.Empty;
                }
            }

            if (rxData == "EER")
            {
                doInit = true;
                dispMsg = "init a";
                rxData = string.Empty;
                rs.Block = false;
            }
            else if ((rxData == "INCOK") || (rxData == "INFOK"))
            {
                initF = true;
                rs.Block = false;
                rxData = string.Empty;
                dispMsg = "------";
                return;
            }
            else if (rs.Block)
            {
                rs.Block = false;
                msgThread.Start(rxData);
            }
        }

        // 데이터 취합 부분
        // Compare 대신에 Contains 를 사용하는편이 유연성에 좋다.
        // 이 프로그램을 제작하 당시는 모르고 있어 적용하지 못함. 추후 수정 요망.
        private void callThread(object obj)
        {
            string str = Convert.ToString(obj); // 문자열 변환            

            // 헤더 구분 및 해당 데이터 취합
            if (((string.Compare(str, 0, "?", 0, 1) == 0) || (string.Compare(str, 0, "I", 0, 1) == 0) || (string.Compare(str, 0, "CF", 0, 2) == 0) || (string.Compare(str, 0, "CS", 0, 2) == 0)) && rs.CF)
            {
                rs.CF = false;
                cfDataArray[rs.arrayIndexCF] = str;                
                //str = string.Empty;
            }
            else if (((string.Compare(str, 0, "?", 0, 1) == 0) || (string.Compare(str, 0, "I", 0, 1) == 0) || (string.Compare(str, 0, "F", 0, 1) == 0) || (string.Compare(str, 0, "VER", 0, 3) == 0) || (string.Compare(str, 0, "STOOK", 0, 5) == 0) || (string.Compare(str, 0, "SETOK", 0, 5) == 0)) && rs.F)
            {
                rs.F = false;
                fDataArray[rs.arrayIndexF] = str;
                //str = string.Empty;
            }
            else
            {
                if (string.Compare(str, 0, "ST", 0, 2) == 0)
                {
                    stable = true;
                    hold = false;
                    hg = false;
                    net = (string.Compare(str, 3, "NT", 0, 2) == 0) ? true : false;
                    dispMsg = makeFormat(str);
                }
                else if (string.Compare(str, 0, "US", 0, 2) == 0)
                {
                    stable = false;
                    hold = false;
                    hg = false;
                    net = (string.Compare(str, 3, "NT", 0, 2) == 0) ? true : false;
                    dispMsg = makeFormat(str);
                }
                else if (string.Compare(str, 0, "HD", 0, 2) == 0)
                {
                    stable = false;
                    hold = true;
                    net = false;
                    hg = false;
                    dispMsg = makeFormat(str);
                }
                else if (string.Compare(str, 0, "HG", 0, 2) == 0)
                {
                    stable = false;
                    hold = true;
                    net = false;
                    hg = true;
                    dispMsg = makeFormat(str);
                }
                else if (string.Compare(str, 0, "OL", 0, 2) == 0)
                {
                    stable = false;
                    hold = false;
                    net = false;
                    hg = false;
                    dispMsg = "   .  ";
                }
                else
                {
                    stable = false;
                    hold = false;
                    zero = false;
                    net = false;
                    hg = false;
                    str = string.Empty;
                    rs.Block = true;
                    return;
                }
                //writeLog.WriteLine(lineNum++ + " : " + str, true);    // 입력 데이터 기록
                str = string.Empty;
            }
            rs.Block = true;
        }
        
        // 데이터 형성 부분
        private string makeFormat(string data)
        {
            char[] DataArray;
            if (data != string.Empty)
            {
                char[] rxDataArray = data.ToCharArray();
                DataArray = new char[rxDataArray.Length];
                int rxSum = 0;
                int j = 0;
                bool minus = false;
                for (int i = 0; i < rxDataArray.Length; i++)
                {
                    if ((rxDataArray[i] == '0') || (rxDataArray[i] == '1') || (rxDataArray[i] == '2') || (rxDataArray[i] == '3') || (rxDataArray[i] == '4') || (rxDataArray[i] == '5') || (rxDataArray[i] == '6') || (rxDataArray[i] == '7') || (rxDataArray[i] == '8') || (rxDataArray[i] == '9') || (rxDataArray[i] == '.'))
                    {
                        DataArray[j] = rxDataArray[i];
                        if (rxDataArray[i] != '.')
                            rxSum = rxSum * 10 + (rxDataArray[i] - '0');
                        j++;
                    }
                    else if (rxDataArray[i] == '-')
                        minus = true;
                    else if (rxDataArray[i] == 'k')
                        kgReady = true;
                    else if (rxDataArray[i] == 'g')
                    {
                        if (kgReady)
                        {
                            g = false;
                            kg = true;
                            t = false;                            
                        }
                        else
                        {
                            g = true;
                            kg = false;
                            t = false;
                        }
                    }
                    else if (rxDataArray[i] == 't')
                    {
                        g = false;
                        kg = false;
                        t = true;
                    }
                }

                if (minus) rxSum = ~rxSum;

                zero = (rxSum == 0) ? true : false;

                #region 제로서프레스
                if ((DataArray[0] == '0') && (DataArray[0] != '.'))
                {
                    DataArray[0] = '\0';
                    if ((DataArray[1] == '0') && (DataArray[1] != '.'))
                    {
                        DataArray[1] = '\0';
                        if ((DataArray[2] == '0') && (DataArray[2] != '.'))
                        {
                            DataArray[2] = '\0';
                            if ((DataArray[3] == '0') && (DataArray[3] != '.'))
                            {
                                DataArray[3] = '\0';
                                if ((DataArray[4] == '0') && (DataArray[4] != '.'))
                                {
                                    DataArray[4] = '\0';
                                    if ((DataArray[5] == '0') && (DataArray[5] != '.'))
                                    {
                                        DataArray[5] = '\0';
                                        if (DataArray[6] == '0')
                                        {
                                        }
                                        else if (minus) DataArray[5] = '-';
                                    }
                                    else if (DataArray[5] == '.')
                                    {
                                        DataArray[4] = '0';
                                        if (minus) DataArray[3] = '-';
                                    }
                                    else if (minus) DataArray[4] = '-';
                                }
                                else if (DataArray[4] == '.')
                                {
                                    DataArray[3] = '0';
                                    if (minus) DataArray[2] = '-';
                                }
                                else if (minus) DataArray[3] = '-';
                            }
                            else if (DataArray[3] == '.')
                            {
                                DataArray[2] = '0';
                                if (minus) DataArray[1] = '-';
                            }
                            else if (minus) DataArray[2] = '-';
                        }
                        else if (DataArray[2] == '.')
                        {
                            DataArray[1] = '0';
                            if (minus) DataArray[0] = '-';
                        }
                        else if (minus) DataArray[1] = '-';
                    }
                    else if (DataArray[1] == '.')
                    {
                        DataArray[0] = '0';
                    }
                    else if (minus) DataArray[0] = '-';
                }
                #endregion

                data = string.Empty;
                for (int i = 0; i < DataArray.Length; i++)
                {
                    if (DataArray[i] != '\0')
                        data += DataArray[i].ToString();
                }
            }
            return data;
        }

        #region 함수 사용 루틴 ( 고정 소수점 표시 문제로 사용 안함 )
        //private string makeFormat(string data)
        //{
        //    float rxSum = 0;
        //    
        //    if (data != string.Empty)
        //    {
        //        try
        //        {
        //            if(data.Contains("."))
        //            {
        //                //rxSum = Convert.ToDouble(data.Substring(6, 8), F);
        //                //rxSum = float.Parse(data.Substring(6, 8), F);
        //                rxSum = Convert.ToSingle(data.Substring(6, 8));
        //            }
        //            else
        //                rxSum = Convert.ToSingle(data.Substring(6, 7));
        //                //rxSum = float.Parse(data.Substring(6, 7), F);
        //        }
        //        catch
        //        {
        //            data=string.Empty;
        //            return data;
        //        }
        //        data = rxSum.ToString();
        //    }
        //    
        //    return data;
        //}
        #endregion

        // 데이터 표시
        private void dispMessage(string str)
        {
            if (serialPort1.IsOpen)
            {
                if (this.textBox1.InvokeRequired)
                {
                    msgCallback d = new msgCallback(dispMessage);
                    try 
                    { 
                        this.Invoke(d, new object[] { str }); 
                    }
                    catch
                    {
                    }
                }
                else
                {
                    this.textBox1.Clear();
                    this.textBox1.AppendText(str);
                }
            }
        }

        #region 메인버튼
        // 용기 제거
        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("CT" + rs.Terminator);
            }
        }

        // 제로/테어
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("MZT" + rs.Terminator);
            }
        }

        // HOLD
        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (hold)
                {
                    serialPort1.Write("HC" + rs.Terminator);
                }
                else
                {
                    serialPort1.Write("HS" + rs.Terminator);
                }
            }
        }

        // Gross / NET        
        private void button6_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (net)
                {
                    serialPort1.Write("MG" + rs.Terminator);
                }
                else
                {
                    serialPort1.Write("MN" + rs.Terminator);
                }
            }
        }

        // ON / OFF
        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 닫기 루틴
                // 닫기 전 리소스 해제 및 조건 루틴 필요
                try
                {
                    // OFF 시 통상모드로 종료
                    // block = false 상태로
                    // 연결 검증 과정이 생략된 상태
                    rs.Block = false;
                    serialPort1.Write("F206,1" + rs.Terminator);

                    timer1sec.Stop();
                    serialPort1.Close();
                    groupBoxPC.Enabled = true;
                    button2.Text = "ON";
                    dispTimer.Stop();

                    // 상태 표시 라벨 초기화
                    lblUnit.Text = string.Empty;
                    lblStable_.Visible = false;
                    lblHold_.Visible = false;
                    lblZero_.Visible = false;
                    lblNet_.Visible = false;

                    stanby = false;
                    standbySec = 0;
                    rs.Block = false;
                    textBox1.Clear();
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    textBox1.Text = "off";
                    dispMsg = string.Empty;

                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false; 
                    radioButton1.Checked = true;                    
                }
                catch
                {
                }
            }
            else
            {
                funcMode = false;
                // 열기 루틴
                try
                {
                    ver = true;
                    dispMsg = string.Empty;
                    serialPort1.Open();

                    standbySec = 0;
                    groupBoxPC.Enabled = false;
                    button2.Text = "OFF";
                    rs.Block = true;
                    textBox1.Clear();
                    textBox1.TextAlign = HorizontalAlignment.Right;
                    // 초기 설정 로딩 타이머 추가
                    dispTimer.Start();
                    timer1sec.Start();
                    // ON 시 통상모드에서 시작
                    // 연결 검증 과정이 생략된 상태
                    serialPort1.Write("F206,1" + rs.Terminator);

                    groupBoxRS.Enabled = false;
                    groupBoxBasic.Enabled = false;
                    groupBoxComp.Enabled = false;                    
                    groupBoxCal.Enabled = false;
                    //groupBoxInit.Enabled = false;
                    //groupBoxVer.Enabled = false;
                    groupBoxBasic2.Enabled = false;
                    
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton1.Checked = true;
                }
                catch
                {
                    // 포트 사용중일 때
                    MessageBox.Show("Can not Open !\r\nPlease Check Setting of Com Port !", "AD310PC", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // PRINT
        private void button5_Click(object sender, EventArgs e)
        {
            if (doInit) // 초기화 플래그
            {
                DialogResult ret;
                // 초기화 루틴
                // 시리얼이벤트(주의) 에서 EER(예시) 문자를 받으면 초기화 플래그를 세워준다.
                // block 후 표시창에 init a를 표시해준다.
                // 이 때 초기화 물음을 진행 후 초기화 명령어를 전송한다.(INC)
                // 시리얼이벤트(주의) 에서 INCOK를 읽으면 성공 메시지 표시 -------(예시)
                // block 을 풀어준다
                ret = MessageBox.Show("초기화를 진행합니다.", "초기화", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (ret == DialogResult.OK)
                {
                    next = 1;
                    doInit = false;
                    modeInitA = true;
                    serialPort1.Write("INC" + rs.Terminator);
                    timerInit.Start();
                    // 초기화 명령어 write
                    //serialPort1.Write("INC" + rs.Terminator);
                }
                else
                {
                }
            }
            else
            {
                // 계량모드 전환
                // 플래그 수정 필요
                rs.Block = true;
            }
        }
        #endregion

        // 설정 창 표시, 숨김
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "설정 감추기";
                tabControl1.Visible = true;
                base.Size = new Size(757, 700);
            }
            else
            {
                checkBox1.Text = "설정 보이기";
                tabControl1.Visible = false;
                base.Size = new Size(757, 400);
            }
        }

        #region PC설정
        // Port
        private void cmbPort_TextChanged(object sender, EventArgs e)
        {
            mySetting.Default.PortDefault = cmbPort.Text;
            serialPort1.PortName = mySetting.Default.PortDefault;
        }

        // Baudrate
        private void cmbBaudrate_TextChanged(object sender, EventArgs e)
        {
            mySetting.Default.BpsDefault = cmbBaudrate.Text;
            serialPort1.BaudRate = Convert.ToInt32(mySetting.Default.BpsDefault);
        }

        // Databits
        private void cmbDatabits_TextChanged(object sender, EventArgs e)
        {
            mySetting.Default.LengthDefault = cmbDatabits.Text;
            serialPort1.DataBits = Convert.ToInt32(mySetting.Default.LengthDefault);
        }

        // Parity
        private void cmbParity_TextChanged(object sender, EventArgs e)
        {
            mySetting.Default.ParityDefault = cmbParity.Text;
            if (mySetting.Default.ParityDefault == "Even")
            {
                serialPort1.Parity = Parity.Even;
            }
            else if (mySetting.Default.ParityDefault == "Odd")
            {
                serialPort1.Parity = Parity.Odd;
            }
            else if (mySetting.Default.ParityDefault == "None")
            {
                serialPort1.Parity = Parity.None;
            }
        }

        // Stopbits
        private void cmbStopbits_TextChanged(object sender, EventArgs e)
        {
            mySetting.Default.StopDefault = cmbStopbits.Text;
            if (mySetting.Default.StopDefault == "1")
            {
                serialPort1.StopBits = StopBits.One;
            }
            else if (mySetting.Default.StopDefault == "2")
            {
                serialPort1.StopBits = StopBits.Two;
            }
        }

        // Terminator
        private void cmbTerminator_TextChanged(object sender, EventArgs e)
        {
            mySetting.Default.TerminatorDefault = cmbTerminator.Text;
            if (mySetting.Default.TerminatorDefault == "CRLF")
            {
                rs.Terminator = "\r\n";
            }
            else if (mySetting.Default.TerminatorDefault == "CR")
            {
                rs.Terminator = "\r";
            }
        }
        #endregion

        #region 통신설정
        // 불러오기
        private void button7_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                // 박스 클리어
                cmdBaudrate.Text = string.Empty;
                cmdDatabits.Text = string.Empty;
                cmdParity.Text = string.Empty;
                cmdStopbits.Text = string.Empty;
                cmdTerminator.Text = string.Empty;

                next = 1;
                rs.Read = true;
                rs.Block = true;
                serialMode = true;
                button7.Enabled = false;
                button20.Enabled = false;
                groupBoxRS.Enabled = false;
                modeTimer.Start();
            }
        }

        // 적용
        private void button20_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 박스 클리어
                //cmdBaudrate.Text = string.Empty;
                //cmdDatabits.Text = string.Empty;
                //cmdParity.Text = string.Empty;
                //cmdStopbits.Text = string.Empty;
                //cmdTerminator.Text = string.Empty;

                next = 1;
                rs.Write = true;
                rs.Block = true;
                serialMode = true;
                button7.Enabled = false;
                button20.Enabled = false;
                groupBoxRS.Enabled = false;
                modeTimer.Start();
            }
        }
        #endregion

        #region 기본설정
        // 불러오기
        private void btnLoad1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                // 박스 클리어
                cmbCutoff.Text = string.Empty;
                cmbHoldmode.Text = string.Empty;
                cmbHoldtime.Value = 0;
                cmdZeroRange.Text = string.Empty;
                cmdZeroTime.Value = 0;
                cmdZeroTracking.Value = 0;

                next = 1;
                rs.Read = true;
                rs.Block = true;
                basicMode = true;
                btnLoad1.Enabled = false;
                button21.Enabled = false;
                groupBoxBasic.Enabled = false;
                groupBoxBasic2.Enabled = false;
                modeTimer.Start();
            }
        }

        // 적용
        private void button21_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 박스 클리어
                //cmbCutoff.Text = string.Empty;
                //cmbHoldmode.Text = string.Empty;
                //cmbHoldtime.Value = 0;
                //cmdZeroRange.Text = string.Empty;
                //cmdZeroTime.Value = 0;
                //cmdZeroTracking.Value = 0;

                next = 1;
                rs.Write = true;
                rs.Block = true;
                basicMode = true;
                btnLoad1.Enabled = false;
                button21.Enabled = false;
                groupBoxBasic.Enabled = false;
                groupBoxBasic2.Enabled = false;
                modeTimer.Start();
            }
        }
        #endregion

        #region 외부출력
        // 불러오기
        private void button10_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                // 박스 클리어
                cmdCmpMode.Text = string.Empty;
                cmdCmpOn.Text = string.Empty;
                cmdCmpValue.Text = string.Empty;
                cmdCompZero.Text = string.Empty;

                next = 1;
                rs.Read = true;
                rs.Block = true;
                compMode = true;
                button10.Enabled = false;
                button22.Enabled = false;
                groupBoxComp.Enabled = false;
                modeTimer.Start();
            }
        }

        // 적용
        private void button22_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 박스 클리어
                //cmdCmpMode.Text = string.Empty;
                //cmdCmpOn.Text = string.Empty;
                //cmdCmpValue.Text = string.Empty;
                //cmdCompZero.Text = string.Empty;

                next = 1;
                rs.Write = true;
                rs.Block = true;
                compMode = true;
                button10.Enabled = false;
                button22.Enabled = false;
                groupBoxComp.Enabled = false;
                modeTimer.Start();
            }
        }
        #endregion

        #region CAL 설정

        // 불러오기
        private void btnLoad4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                next = 1;
                rs.Read = true;
                rs.Block = true;
                modeTimer.Start();
            }
        }

        // 적용
        private void button19_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                next = 1;
                rs.Write = true;
                rs.Block = true;
                modeTimer.Start();
            }
        }

        #endregion

        #region 교정

        // CAL 정보 텍스트 상자에 넣기
        private void button17_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                // 박스 클리어
                calCapa.Value = 0;
                calDigit.Text = string.Empty;
                calPoint.Text = string.Empty;
                cmdUnit.Text = string.Empty;
                calCalF.Value = 0;

                next = 1;
                rs.Block = true;
                rs.Read = true;
                doCalMode = true;
                button17.Enabled = false;
                groupBoxCal.Enabled = false;
                modeTimer.Start();
            }
            else
            {
                //오류
            }
        }

        // 설정값 변경 적용
        private void button16_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // 박스 클리어
                //calCapa.Value = 0;
                //calDigit.Text = string.Empty;
                //calPoint.Text = string.Empty;
                //cmdUnit.Text = string.Empty;

                next = 1;
                rs.Write = true;
                doCalMode = true;
                groupBoxCal.Enabled = false;
                modeTimer.Start();
            }
            else
            {
                // 오류
            }
        }

        // CAL0
        private void button18_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("CAL0를 진행합니다.", "CAL0", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.OK)
            {
                serialPort1.Write("CALZERO" + rs.Terminator);
                Thread.Sleep(1000);
                lblResult0.ForeColor = Color.Blue;
                lblResult0.Text = "OK";
            }
            else
            {
                lblResult0.ForeColor = Color.Red;
                lblResult0.Text = "NG";
            }            
            groupBoxCal.Enabled = false;
            groupBoxCal.Enabled = true;            
        }

        // CALF
        private void button15_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("CALF를 진행합니다.", "CALF", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.OK)
            {
                // 박스 클리어
                //calCalF.Value = 0;

                groupBoxCal.Enabled = false;
                doSpan = true;
                next = 1;
                modeTimer.Start();
            }
            else
            {
                lblResultCalF.ForeColor = Color.Red;
                lblResultCalF.Text = "NG";
            }
        }

        #endregion

        #region 타이머

        // 펑션 로딩 및 변경
        private void modeTimer_Tick_1(object sender, EventArgs e)
        {
            string baudrate = string.Empty;
            string parity = string.Empty;
            string terminator = string.Empty;
            temp = string.Empty;

            if (serialPort1.IsOpen)
            {   
                if (serialMode) // 통신설정
                {
                    rs.F = true;
                    switch (next)
                    {
                        case 1:                            
                            if (rs.Read)
                            {
                                // baudrate 명령
                                rs.arrayIndexF = 7;
                                serialPort1.Write("?F201" + rs.Terminator);                                
                            }
                            else
                            {
                                // 명령
                                rs.arrayIndexF = 16;

                                if(cmdBaudrate.Text == "2400")
                                {
                                    baudrate = "024";
                                }
                                else if(cmdBaudrate.Text == "4800")
                                {
                                    baudrate = "048";
                                }
                                else if(cmdBaudrate.Text == "9600")
                                {
                                    baudrate = "096";
                                }
                                else if(cmdBaudrate.Text == "19200")
                                {
                                    baudrate = "192";
                                }
                                else if(cmdBaudrate.Text == "38400")
                                {
                                    baudrate = "384";
                                }

                                if(cmdParity.Text == "None")
                                    parity = "0";
                                else if(cmdParity.Text == "Odd")
                                    parity = "1";
                                else
                                    parity = "2";

                                if (cmdTerminator.Text == "CRLF")
                                    terminator = "1";
                                else if (cmdTerminator.Text == "CR")
                                    terminator = "2";

                                temp = baudrate + cmdDatabits.Text + parity + cmdStopbits.Text + terminator;
                                serialPort1.Write("RSSTO," + temp + rs.Terminator);
                            }
                            next = 2;
                            break;
                        case 2:                           
                            if (rs.Read)
                            {
                                // baudrate 표시
                                try
                                {
                                    if (Convert.ToInt32(fDataArray[7].Substring(5)) == 24)
                                    {
                                        cmdBaudrate.Text = cmdBaudrate.Items[0].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[7].Substring(5)) == 48)
                                    {
                                        cmdBaudrate.Text = cmdBaudrate.Items[1].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[7].Substring(5)) == 96)
                                    {
                                        cmdBaudrate.Text = cmdBaudrate.Items[2].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[7].Substring(5)) == 192)
                                    {
                                        cmdBaudrate.Text = cmdBaudrate.Items[3].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[7].Substring(5)) == 384)
                                    {
                                        cmdBaudrate.Text = cmdBaudrate.Items[4].ToString();
                                    }
                                    fDataArray[7] = string.Empty;
                                }
                                catch
                                {
                                    // I 또는 ? 응답시 오류 메시지 표시
                                    serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(SERIAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                                // databits 명령
                                rs.arrayIndexF = 8;
                                serialPort1.Write("?F202" + rs.Terminator);
                                next = 3;
                            }
                            else
                            {
                                // 판별
                                if (fDataArray[16] == "STOOK")
                                {
                                    next = 4;
                                    fDataArray[16] = string.Empty;
                                    rs.arrayIndexF = 17;
                                    serialPort1.Write("RSSET" + rs.Terminator);
                                }
                                else
                                {
                                    // 2회만 판정
                                    next = 3;
                                }
                            }                            
                            break;
                        case 3:                            
                            if (rs.Read)
                            {
                                // databits 표시
                                try
                                {
                                    if (Convert.ToInt32(fDataArray[8].Substring(5)) == 7)
                                    {
                                        cmdDatabits.Text = cmdDatabits.Items[0].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[8].Substring(5)) == 8)
                                    {
                                        cmdDatabits.Text = cmdDatabits.Items[1].ToString();
                                    }
                                    fDataArray[8] = string.Empty;
                                }
                                catch
                                {
                                    // I 또는 ? 응답시 오류 메시지 표시
                                    serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(SERIAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                                // parity 명령
                                rs.arrayIndexF = 9;
                                serialPort1.Write("?F203" + rs.Terminator);
                                next = 4;
                            }
                            else
                            {
                                // 판별
                                if (fDataArray[16] == "STOOK")
                                {
                                    next = 4;
                                    fDataArray[16] = string.Empty;
                                    rs.arrayIndexF = 17;
                                    serialPort1.Write("RSSET" + rs.Terminator);
                                }
                                else
                                {
                                    // 2회만 판정
                                    modeTimer.Stop();
                                    //종료
                                    break;
                                }
                            }
                            break;
                        case 4:
                            if (rs.Read)
                            {
                                // parity 표시
                                try
                                {
                                    if (Convert.ToInt32(fDataArray[9].Substring(5)) == 0)
                                    {
                                        cmdParity.Text = cmdParity.Items[0].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[9].Substring(5)) == 1)
                                    {
                                        cmdParity.Text = cmdParity.Items[1].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[9].Substring(5)) == 2)
                                    {
                                        cmdParity.Text = cmdParity.Items[2].ToString();
                                    }
                                    fDataArray[9] = string.Empty;
                                }
                                catch
                                {
                                    // I 또는 ? 응답시 오류 메시지 표시
                                    serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(SERIAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                                // stopbits 명령
                                rs.arrayIndexF = 10;
                                serialPort1.Write("?F204" + rs.Terminator);
                                next = 5;
                            }
                            else
                            {
                                // 판별
                                if (fDataArray[17] == "SETOK")
                                {
                                    next = -1;
                                    fDataArray[17] = string.Empty;
                                    rs.Block = false;
                                    // 통신 설정 변경 적용
                                    // 텍스트 변경되면 이벤트 발생
                                    serialPort1.Close();
                                    cmbBaudrate.Text = cmdBaudrate.Text;
                                    cmbDatabits.Text = cmdDatabits.Text;
                                    cmbParity.Text = cmdParity.Text;
                                    cmbStopbits.Text = cmdStopbits.Text;
                                    cmbTerminator.Text = cmdTerminator.Text;
                                    serialPort1.Open();
                                    
                                    // 플래그 초기화
                                    initFlag(SERIAL);
                                    groupBoxRS.Enabled = true;
                                    rs.Block = true;

                                    // 주의 : 래디오버튼 체크시 이벤트 동작
                                    // 이전에 플래그 초기화 필요
                                    radioButton1.Enabled = true;
                                    radioButton2.Enabled = true; 
                                    radioButton1.Checked = true;                                    
                                }
                                else
                                {
                                    // 2회만 판정
                                    next = 5;
                                }
                            }
                            break;
                        case 5:                            
                            if (rs.Read)
                            {
                                // stopbits 표시
                                try
                                {
                                    if (Convert.ToInt32(fDataArray[10].Substring(5)) == 1)
                                    {
                                        cmdStopbits.Text = cmdStopbits.Items[0].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[10].Substring(5)) == 2)
                                    {
                                        cmdStopbits.Text = cmdStopbits.Items[1].ToString();
                                    }
                                    fDataArray[10] = string.Empty;
                                }
                                catch
                                {
                                    // I 또는 ? 응답시 오류 메시지 표시
                                    serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(SERIAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                                // terminator 명령
                                serialPort1.Write("?F205" + rs.Terminator);
                            }
                            else
                            {
                                // 판별
                                if (fDataArray[17] == "SETOK")
                                {
                                    next = -1;

                                }
                                else
                                {
                                    // 2회만 판정
                                    modeTimer.Stop();
                                }
                            }
                            rs.arrayIndexF = 11;
                            next = -1;
                            break;
                        default:                            
                            if (rs.Read)
                            {
                                // terminator 표시
                                try
                                {
                                    if (Convert.ToInt32(fDataArray[11].Substring(5)) == 1)
                                    {
                                        cmdTerminator.Text = cmdTerminator.Items[0].ToString();
                                    }
                                    else if (Convert.ToInt32(fDataArray[11].Substring(5)) == 2)
                                    {
                                        cmdTerminator.Text = cmdTerminator.Items[1].ToString();
                                    }
                                    fDataArray[11] = string.Empty;
                                }
                                catch
                                {
                                    // I 또는 ? 응답시 오류 메시지 표시
                                    serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(SERIAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            }
                            next = 1;
                            groupBoxRS.Enabled = true;
                            button20.Enabled = true;
                            initFlag(SERIAL);
                            break;
                    }
                }
                else if (basicMode) // 기본설정
                {                    
                    switch (next)
                    {
                        case 1:
                            rs.F = true;
                            // 디지털 필터 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?F001" + rs.Terminator);
                            }
                            else
                            {
                                if (cmbCutoff.Text == cmbCutoff.Items[0].ToString())
                                {
                                    temp = "0";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[1].ToString())
                                {
                                    temp = "1";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[2].ToString())
                                {
                                    temp = "2";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[3].ToString())
                                {
                                    temp = "3";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[4].ToString())
                                {
                                    temp = "4";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[5].ToString())
                                {
                                    temp = "5";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[6].ToString())
                                {
                                    temp = "6";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[7].ToString())
                                {
                                    temp = "7";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[8].ToString())
                                {
                                    temp = "8";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[9].ToString())
                                {
                                    temp = "9";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[10].ToString())
                                {
                                    temp = "10";
                                }
                                else if (cmbCutoff.Text == cmbCutoff.Items[11].ToString())
                                {
                                    temp = "11";
                                }

                                serialPort1.Write("F001," + temp + rs.Terminator);
                            }
                            rs.arrayIndexF = 0;
                            next = 2;
                            break;
                        case 2:
                            rs.F = true;
                            // 디지털 필터 표시
                            try
                            {
                                if (Convert.ToInt32(fDataArray[0].Substring(5)) == 0)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 1)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[1].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 2)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[2].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 3)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[3].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 4)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[4].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 5)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[5].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 6)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[6].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 7)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[7].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 8)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[8].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 9)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[9].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 10)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[10].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[0].Substring(5)) == 11)
                                {
                                    cmbCutoff.Text = cmbCutoff.Items[11].ToString();
                                }
                                fDataArray[0] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(BASIC);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 홀드 모드 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?F002" + rs.Terminator);
                            }
                            else
                            {
                                if (cmbHoldmode.Text == cmbHoldmode.Items[0].ToString())
                                {
                                    temp = "0";
                                }
                                else if (cmbHoldmode.Text == cmbHoldmode.Items[1].ToString())
                                {
                                    temp = "1";
                                }
                                else if (cmbHoldmode.Text == cmbHoldmode.Items[2].ToString())
                                {
                                    temp = "2";
                                }
                                else if (cmbHoldmode.Text == cmbHoldmode.Items[3].ToString())
                                {
                                    temp = "3";
                                }
                                else if (cmbHoldmode.Text == cmbHoldmode.Items[4].ToString())
                                {
                                    temp = "4";
                                }
                                serialPort1.Write("F002," + temp + rs.Terminator);
                            }
                            rs.arrayIndexF = 1;
                            next = 3;
                            break;
                        case 3:
                            rs.F = true;
                            // 홀드 모드 표시
                            try
                            {
                                // 홀드 모드 표시
                                if (Convert.ToInt32(fDataArray[1].Substring(5)) == 0)
                                {
                                    cmbHoldmode.Text = cmbHoldmode.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[1].Substring(5)) == 1)
                                {
                                    cmbHoldmode.Text = cmbHoldmode.Items[1].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[1].Substring(5)) == 2)
                                {
                                    cmbHoldmode.Text = cmbHoldmode.Items[2].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[1].Substring(5)) == 3)
                                {
                                    cmbHoldmode.Text = cmbHoldmode.Items[3].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[1].Substring(5)) == 4)
                                {
                                    cmbHoldmode.Text = cmbHoldmode.Items[4].ToString();
                                }
                                fDataArray[1] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(BASIC);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 평균화 시간 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?F003" + rs.Terminator);
                            }
                            else
                            {
                                serialPort1.Write("F003," + (cmbHoldtime.Value*10).ToString() + rs.Terminator);
                            }
                            rs.arrayIndexF = 2;
                            next = 4;
                            break;
                        case 4:
                            rs.F = false;
                            rs.CF = true;
                            // 평균화 시간 표시
                            try
                            {
                                cmbHoldtime.Value = Convert.ToDecimal(Convert.ToInt32(fDataArray[2].Substring(5)) * 0.1);
                                fDataArray[2] = string.Empty;
                            }
                            catch
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(BASIC);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 제로 확보 범위 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?CF05" + rs.Terminator);
                            }
                            else
                            {
                                serialPort1.Write("CF05," + cmdZeroRange.Text + rs.Terminator);
                            }
                            rs.arrayIndexCF = 4;
                            next = 5;
                            break;
                        case 5:
                            rs.CF = true;
                            // 제로 확보 범위 표시
                            try
                            {
                                cmdZeroRange.Text = Convert.ToInt32(cfDataArray[4].Substring(5)).ToString();
                                cfDataArray[4] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(BASIC);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 영점 트래킹 시간 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?CF06" + rs.Terminator);
                            }
                            else
                            {
                                serialPort1.Write("CF06," + (Convert.ToInt16(cmdZeroTime.Value * 10)).ToString() + rs.Terminator);
                            }
                            rs.arrayIndexCF = 5;
                            next = 6;
                            break;
                        case 6:
                            rs.CF = true;
                            // 영점 트래킹 시간 표시
                            try
                            {
                                cmdZeroTime.Value = Convert.ToDecimal(Convert.ToInt32(cfDataArray[5].Substring(5)) * 0.1);
                                cfDataArray[5] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(BASIC);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 영점 트래킹 폭 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?CF07" + rs.Terminator);
                            }
                            else
                            {
                                serialPort1.Write("CF07," + (Convert.ToInt16(cmdZeroTracking.Value * 10)).ToString() + rs.Terminator);
                            }
                            rs.arrayIndexCF = 6;
                            next = 7;
                            break;
                        case 7:
                            rs.CF = true;
                            // 영점 트래킹 폭 표시
                            try
                            {
                                cmdZeroTracking.Value = Convert.ToDecimal(Convert.ToInt32(cfDataArray[6].Substring(5)) * 0.1);
                                cfDataArray[6] = string.Empty;
                            }
                            catch
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(BASIC);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 파워 온 제로 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?CF08" + rs.Terminator);
                            }
                            else
                            {
                                if (cmdPOZ.Text == cmdPOZ.Items[0].ToString())
                                {
                                    temp = "0";
                                }
                                else if (cmdPOZ.Text == cmdPOZ.Items[1].ToString())
                                {
                                    temp = "1";
                                }
                                serialPort1.Write("CF08," + temp + rs.Terminator);
                            }
                            rs.arrayIndexCF = 7;
                            next = -1;
                            break;
                        default:
                            rs.CF = true;
                            // 파워 온 제로 표시
                            try
                            {
                                if (Convert.ToInt32(cfDataArray[7].Substring(5)) == 0)
                                {
                                    cmdPOZ.Text = cmdPOZ.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[7].Substring(5)) == 1)
                                {
                                    cmdPOZ.Text = cmdPOZ.Items[1].ToString();
                                }
                                cfDataArray[7] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(BASIC);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            button21.Enabled = true;
                            initFlag(BASIC);
                            groupBoxBasic.Enabled = true;
                            groupBoxBasic2.Enabled = true;
                            break;
                    }
                }
                else if (compMode)  // 외부출력
                {
                    rs.F = true;
                    switch (next)
                    {
                        case 1:
                            // 외부출력 조건 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?F101" + rs.Terminator);
                            }
                            else
                            {
                                if (cmdCmpOn.Text == cmdCmpOn.Items[0].ToString())
                                {
                                    temp = "0";
                                }
                                else if (cmdCmpOn.Text == cmdCmpOn.Items[1].ToString())
                                {
                                    temp = "1";
                                }
                                serialPort1.Write("F101," + temp + rs.Terminator);
                            }
                            rs.arrayIndexF = 3;
                            next = 2;
                            break;
                        case 2:
                            // 외부출력 조건 표시
                            try
                            {
                                if (Convert.ToInt32(fDataArray[3].Substring(5)) == 0)
                                {
                                    cmdCmpOn.Text = cmdCmpOn.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[3].Substring(5)) == 1)
                                {
                                    cmdCmpOn.Text = cmdCmpOn.Items[1].ToString();
                                }
                                fDataArray[3] = string.Empty;
                            }
                            catch
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(COMP);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 설정값 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?F102" + rs.Terminator);
                            }
                            else
                            {
                                serialPort1.Write("F102," + cmdCmpValue.Text + rs.Terminator); 
                            }
                            rs.arrayIndexF = 4;
                            next = 3;
                            break;
                        case 3:
                            // 설정값 표시
                            try
                            {
                                cmdCmpValue.Text = Convert.ToInt32(fDataArray[4].Substring(5)).ToString();
                                fDataArray[4] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(COMP);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 모드 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?F103" + rs.Terminator);
                            }
                            else
                            {
                                if (cmdCmpMode.Text == cmdCmpMode.Items[0].ToString())
                                {
                                    temp = "0";
                                }
                                else if (cmdCmpMode.Text == cmdCmpMode.Items[1].ToString())
                                {
                                    temp = "1";
                                }
                                else if (cmdCmpMode.Text == cmdCmpMode.Items[2].ToString())
                                {
                                    temp = "2";
                                }
                                serialPort1.Write("F103," + temp + rs.Terminator);
                            }
                            rs.arrayIndexF = 5;
                            next = 4;
                            break;
                        case 4:
                            // 모드 표시
                            try
                            {
                                if (Convert.ToInt32(fDataArray[5].Substring(5)) == 0)
                                {
                                    cmdCmpMode.Text = cmdCmpMode.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[5].Substring(5)) == 1)
                                {
                                    cmdCmpMode.Text = cmdCmpMode.Items[1].ToString();
                                }
                                else if (Convert.ToInt32(fDataArray[5].Substring(5)) == 2)
                                {
                                    cmdCmpMode.Text = cmdCmpMode.Items[2].ToString();
                                }
                                fDataArray[5] = string.Empty;
                            }
                            catch
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(COMP);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // 제로근처 명령
                            if (rs.Read)
                            {
                                serialPort1.Write("?F104" + rs.Terminator);
                            }
                            else
                            {
                                serialPort1.Write("F104," + cmdCompZero.Text + rs.Terminator);
                            }
                            rs.arrayIndexF = 6;
                            next = -1;
                            break;
                        default:
                            // 제로근처 표시
                            try
                            {
                                cmdCompZero.Text = Convert.ToInt32(fDataArray[6].Substring(5)).ToString();
                                fDataArray[6] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(COMP);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            button22.Enabled = true;
                            groupBoxComp.Enabled = true;
                            initFlag(COMP);
                            break;
                    }
                }
                else if (doCalMode) // 교정
                {
                    rs.CF = true;
                    switch (next)
                    {
                        case 1: 
                            // CAPA 명령
                            rs.arrayIndexCF = 2; 
                            if(rs.Read)
                            {
                                serialPort1.Write("?CF03" + rs.Terminator);
                            }
                            else
                            {
                                serialPort1.Write("CF03," + calCapa.Value.ToString() + rs.Terminator);
                            } 
                            next = 2; 
                            break;
                        case 2:    
                            rs.arrayIndexCF = 1;                        
                            // CAPA 표시                              
                            try
                            {
                                calCapa.Value = Convert.ToDecimal(cfDataArray[2].Substring(5));
                                cfDataArray[2] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(CAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;

                            if (rs.Read)
                            {
                                
                                // DIV 명령
                                serialPort1.Write("?CF02" + rs.Terminator);
                            }
                            else
                            {
                                // DIV 명령
                                if (calDigit.Text == calDigit.Items[0].ToString())
                                {
                                    temp = "1";
                                }
                                else if (calDigit.Text == calDigit.Items[1].ToString())
                                {
                                    temp = "2";
                                }
                                else if (calDigit.Text == calDigit.Items[2].ToString())
                                {
                                    temp = "5";
                                }
                                else if (calDigit.Text == calDigit.Items[3].ToString())
                                {
                                    temp = "10";
                                }
                                else if (calDigit.Text == calDigit.Items[4].ToString())
                                {
                                    temp = "20";
                                }
                                else if (calDigit.Text == calDigit.Items[5].ToString())
                                {
                                    temp = "50";
                                }
                                serialPort1.Write("CF02," + temp + rs.Terminator);
                            }
                            next = 3; 
                            break;
                        case 3:                            
                            rs.arrayIndexCF = 0;
                            // DIV 표시
                            try
                            {
                                if (Convert.ToInt32(cfDataArray[1].Substring(5)) == 1)
                                {
                                    calDigit.Text = calDigit.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[1].Substring(5)) == 2)
                                {
                                    calDigit.Text = calDigit.Items[1].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[1].Substring(5)) == 5)
                                {
                                    calDigit.Text = calDigit.Items[2].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[1].Substring(5)) == 10)
                                {
                                    calDigit.Text = calDigit.Items[3].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[1].Substring(5)) == 20)
                                {
                                    calDigit.Text = calDigit.Items[4].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[1].Substring(5)) == 50)
                                {
                                    calDigit.Text = calDigit.Items[5].ToString();
                                }
                                //cfDataArray[1] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(CAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            if (rs.Read)
                            { 
                                // 소수점 명령
                                serialPort1.Write("?CF01" + rs.Terminator);
                            }
                            else
                            {
                                // 소수점 명령
                                if (calPoint.Text == calPoint.Items[0].ToString())
                                {
                                    temp = "0";
                                }
                                else if (calPoint.Text == calPoint.Items[1].ToString())
                                {
                                    temp = "1";
                                }
                                else if (calPoint.Text == calPoint.Items[2].ToString())
                                {
                                    temp = "2";
                                }
                                else if (calPoint.Text == calPoint.Items[3].ToString())
                                {
                                    temp = "3";
                                }
                                serialPort1.Write("CF01," + temp + rs.Terminator);
                            }
                            next = 4; 
                            break;
                        case 4:
                            rs.arrayIndexCF = 8;
                            // 소수점 표시
                            try
                            {
                                if (Convert.ToInt32(cfDataArray[0].Substring(5)) == 0)
                                {
                                    calPoint.Text = calPoint.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[0].Substring(5)) == 1)
                                {
                                    calPoint.Text = calPoint.Items[1].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[0].Substring(5)) == 2)
                                {
                                    calPoint.Text = calPoint.Items[2].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[0].Substring(5)) == 3)
                                {
                                    calPoint.Text = calPoint.Items[3].ToString();
                                }
                                cfDataArray[0] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(CAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                        //단위 설정 명령
                            if (rs.Read)
                            {
                            serialPort1.Write("?CF09" + rs.Terminator);
                            }
                            else
                            {
                                if (cmdUnit.Text == cmdUnit.Items[0].ToString())
                                {
                                    temp = "0";
                                }
                                else if (cmdUnit.Text == cmdUnit.Items[1].ToString())
                                {
                                    temp = "1";
                                }
                                else if (cmdUnit.Text == cmdUnit.Items[2].ToString())
                                {
                                    temp = "2";
                                }
                                else if (cmdUnit.Text == cmdUnit.Items[3].ToString())
                                {
                                    temp = "3";
                                }
                                serialPort1.Write("CF09," + temp + rs.Terminator);
                            }                            
                            next = 5;
                            break;
                        case 5:
                            rs.arrayIndexCF = 3;
                            // 단위 설정 표시
                            try
                            {
                                if (Convert.ToInt32(cfDataArray[8].Substring(5)) == 0)
                                {
                                    cmdUnit.Text = cmdUnit.Items[0].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[8].Substring(5)) == 1)
                                {
                                    cmdUnit.Text = cmdUnit.Items[1].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[8].Substring(5)) == 2)
                                {
                                    cmdUnit.Text = cmdUnit.Items[2].ToString();
                                }
                                else if (Convert.ToInt32(cfDataArray[8].Substring(5)) == 3)
                                {
                                    cmdUnit.Text = cmdUnit.Items[3].ToString();
                                }
                                cfDataArray[8] = string.Empty;
                            }
                            catch 
                            {
                                // I 또는 ? 응답시 오류 메시지 표시
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(CAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;
                            // Span 입력 전압 명령
                            serialPort1.Write("?CF04" + rs.Terminator);                            
                            next = -1;
                            break;                            
                        default:
                            // Span 입력 전압 표시                            
                            try
                            {
                                calCalF.Value = Convert.ToDecimal(cfDataArray[3].Substring(5));
                                //cfDataArray[3] = string.Empty;
                            }
                            catch 
                            {
                                serialPort1.DiscardOutBuffer();

                                    if (++err_cnt > 9)
                                    {
                                        initFlag(CAL);
                                        MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else next = 1;
                                    break;
                                }
                                err_cnt = 0;                          
                            groupBoxCal.Enabled = true;
                            initFlag(CAL);
                            break;
                    }
                }
                else if (doSpan)
                {
                    rs.CF = true;
                    switch (next)
                    {
                        case 1:
                            rs.arrayIndexCF = 9;
                            serialPort1.Write("CALSPAN" + rs.Terminator);
                            next = -1;
                            break;
                        default:                            
                            try
                            {
                                // SPAN 표시
                                if ((cfDataArray[9] == "I") || (cfDataArray[9] == "?"))
                                {
                                    calCalF.Value = Convert.ToDecimal(cfDataArray[3].Substring(5));
                                    cfDataArray[3] = string.Empty;
                                    lblResultCalF.ForeColor = Color.Red;
                                    lblResultCalF.Text = "NG";
                                }
                                else
                                {
                                    serialPort1.Write("CF04," + calCalF.Value.ToString() + rs.Terminator);
                                    lblResultCalF.ForeColor = Color.Blue;
                                    lblResultCalF.Text = "OK";
                                    
                                    // 플래그 초기화
                                    rs.CF = false;
                                    next = 1;
                                    doSpan = false;
                                    groupBoxCal.Enabled = false;
                                    modeTimer.Stop(); 

                                    radioButton1.Checked = true;
                                    break;
                                }
                            }
                            catch 
                            {
                                rs.CF = false;
                                next = 1;
                                doSpan = false;
                                groupBoxCal.Enabled = true;
                                modeTimer.Stop();   
                                MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }                              
                            rs.CF = false;
                            next = 1;
                            doSpan = false;
                            groupBoxCal.Enabled = true;
                            modeTimer.Stop();                            
                            break;
                    }
                }
                else if (verMode)
                {
                    rs.F = true;
                    switch (next)
                    {
                        case 1:
                            // 버전 명령
                            rs.arrayIndexF = 14;
                            serialPort1.Write("?VER" + rs.Terminator);
                            next = -1;
                            break;
                        default:
                            // 버전 표시
                            try
                            {
                                //boxAbout.Items.Clear();
                                //boxAbout.Items.Add("프로그램 버전 0.90");
                                //boxAbout.Items.Add("ROM 버전 " + (Convert.ToInt32(fDataArray[14].Substring(4, 3)) * 0.01).ToString("0.00"));
                                lblVer.Text = "ROM 버전 : " + (Convert.ToInt32(fDataArray[14].Substring(4,3)) * 0.01).ToString("0.00");
                            }
                            catch
                            {
                                next = 1;
                                rs.F = false;
                                verMode = false;
                                modeTimer.Stop();
                                break;
                            }
                            next = 1;
                            rs.F = false;
                            verMode = false;
                            modeTimer.Stop();
                            break;
                    }
                }
            }
        }

        #endregion            

        // 초당 10회씩 표시
        private void dispTimer_Tick(object sender, EventArgs e)
        {
            if (!funcMode)
            {
                if (stanby)
                {
                    dispMsg = string.Empty;
                    dispMessage("------");
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                }
                else
                {
                    dispMessage(dispMsg);
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    if((serialPort1.BaudRate == 19200) || (serialPort1.BaudRate == 38400))
                        serialPort1.DiscardInBuffer();
                }
            
                // 안정마크
                lblStable_.Visible = stable ? true : false;

                // 영점마크            
                lblZero_.Visible = zero ? true : false;

                // net마크
                lblNet_.Visible = net ? true : false;

                // hold
                if (hg)
                {
                    if (cnt100ms++ < 4)
                    {
                        lblHold_.Visible = true;
                    }
                    else
                    {
                        lblHold_.Visible = false;
                        if (cnt100ms > 8)
                        {
                            cnt100ms = 0;
                        }
                    }
                }
                else
                {
                    lblHold_.Visible = hold ? true : false;
                }

                if (kg)
                    lblUnit.Text = "kg";
                else if (g && !kgReady)
                    lblUnit.Text = "g";
                else if (t)
                    lblUnit.Text = "t";
                //else
                    //lblUnit.Text = string.Empty;
            }
            else if(initF)                
            {
                dispMessage(dispMsg);
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
            }
            g = false;
            kg = false;
            t = false;
            kgReady = false;
        }

        #region 모드 변경
        // 통상 모드
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                standbySec = 0;
                funcMode = false;
                dispMsg = string.Empty;
                textBox1.TextAlign = HorizontalAlignment.Right;                
                serialPort1.Write("F206,1" + rs.Terminator);
                Thread.Sleep(300);
                serialPort1.Write("F206,1" + rs.Terminator);
                Thread.Sleep(300);

                // 버튼 활성화
                button7.Enabled = false;
                button20.Enabled = false;
                btnLoad1.Enabled = false;
                button21.Enabled = false;
                button10.Enabled = false;
                button22.Enabled = false;
                button17.Enabled = false;

                // 그룹 박스 설정 금지 상태
                groupBoxRS.Enabled = false;
                groupBoxBasic.Enabled = false;
                groupBoxBasic2.Enabled = false;
                groupBoxComp.Enabled = false;
                groupBoxCal.Enabled = false;
                groupBoxInit.Enabled = false;
                groupBoxInit2.Enabled = false;
                //groupBoxVer.Enabled = false;

                rs.Block = true;
            }
        }

        // 설정 모드
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                funcMode = true;
                rs.Block = false;
                serialPort1.Write("F206,2" + rs.Terminator);
                serialPort1.DiscardInBuffer();
                Thread.Sleep(300);
                serialPort1.Write("F206,2" + rs.Terminator);
                serialPort1.DiscardInBuffer();
                Thread.Sleep(300);
                next = 1;

                // 불러오기 버튼 활성화
                button7.Enabled = true;
                btnLoad1.Enabled = true;
                button10.Enabled = true;
                button17.Enabled = true;

                // 적용버튼은 불러오기 후 활성화
                button20.Enabled = false;
                button21.Enabled = false;
                button22.Enabled = false;

                // 상태 표시 라벨 초기화
                lblUnit.Text = string.Empty;
                lblStable_.Visible = false;
                lblHold_.Visible = false;
                lblZero_.Visible = false;
                lblNet_.Visible = false;

                // 그룹 박스 활성화 상태
                //groupBoxRS.Enabled = false;
                //groupBoxBasic.Enabled = false;
                //groupBoxComp.Enabled = false;
                //groupBoxCal.Enabled = false;
                groupBoxInit.Enabled = true;
                groupBoxInit2.Enabled = true;
                //groupBoxVer.Enabled = true;
                //groupBox1.Enabled = false;

                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.Text = "5et";
            }
        }
        #endregion

        private void timer1sec_Tick(object sender, EventArgs e)
        {
            if (!funcMode)
            {
                ++standbySec;

                // 스탠바이 시간 체크

                if (standbySec >= 3)
                {
                    stanby = true;
                }
                else
                {
                    stanby = false;
                }
            }
        }

        #region 초기화
        // 설정 + 교정 초기화
        private void button11_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("CF 펑션 및 F 펑션 초기화를 진행합니다.", "초기화", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.OK)
            {
                modeInitA = true;
                next = 1;
                serialPort1.Write("INC" + rs.Terminator);
                timerInit.Start();
                //textBox1.TextAlign = HorizontalAlignment.Right;
            } 
        }

        // 설정만 초기화
        private void button23_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("F 펑션 초기화를 진행합니다.", "초기화", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ret == DialogResult.OK)
            {
                modeInitF = true;
                next = 1;
                serialPort1.Write("INF" + rs.Terminator);
                timerInit.Start();
            }
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.andk.co.kr");
        }

        // 초기화 타이머
        // 주의 : 모듈측 초기화 시간이 1~2초정도 되니 충분히 고려하여 작성할 것
        private void timerinit_Tick(object sender, EventArgs e)
        {
            if (modeInitF)
            {
                timerInit.Stop();
                if (initF)
                {
                    initF = false;
                    // 통신 설정 변경 적용
                    // 텍스트 변경되면 이벤트 발생
                    serialPort1.Close();
                    cmbBaudrate.Text = "2400";
                    cmbDatabits.Text = "7";
                    cmbParity.Text = "Even";
                    cmbStopbits.Text = "1";
                    cmbTerminator.Text = "CRLF";
                    serialPort1.Open();
                }
                else
                {                    
                    MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dispMsg = string.Empty;
                rs.Block = true;
                textBox1.TextAlign = HorizontalAlignment.Right;
                next = 1;
                modeInitF = false;     
                radioButton1.Checked = true;
            }
            else if (modeInitA)
            {
                timerInit.Stop();
                if (initF)
                {
                    initF = false;
                    // 통신 설정 변경 적용
                    // 텍스트 변경되면 이벤트 발생
                    serialPort1.Close();
                    cmbBaudrate.Text = "2400";
                    cmbDatabits.Text = "7";
                    cmbParity.Text = "Even";
                    cmbStopbits.Text = "1";
                    cmbTerminator.Text = "CRLF";
                    serialPort1.Open();
                }
                else
                {
                    MessageBox.Show("응답 오류!\r\n연결 상태 확인!", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dispMsg = string.Empty;
                rs.Block = true;
                textBox1.TextAlign = HorizontalAlignment.Right;
                modeInitA = false; 

                radioButton1.Checked = true;                
            }
        }

        // 정보창
        // 이벤트 조건 : 설정모드 상태에서 정보탭을 클릭
        private void tabVer_Enter(object sender, EventArgs e)
        {
            // 버전 불러오기
            if (serialPort1.IsOpen)
            {
                // 1회만 로딩
                if (ver && radioButton2.Checked)
                {
                    ver = false;
                    modeTimer.Stop();   // fail-safe
                    rs.Block = true;
                    verMode = true;
                    modeTimer.Start();

                }
            }
        }

        #region 플래그 초기화 함수
        private void initFlag(int mode)
        {
            switch (mode)
            {
                case SERIAL:
                    rs.F = false;
                    rs.Read = false;
                    rs.Write = false;
                    serialMode = false;
                    button7.Enabled = true;
                    //button20.Enabled = true;
                    break;
                case BASIC:
                    rs.F = false;
                    rs.CF = false;
                    rs.Read = false;
                    rs.Write = false;
                    basicMode = false;
                    btnLoad1.Enabled = true;
                    //button21.Enabled = true;
                    break;
                case COMP:
                    rs.F = false;
                    rs.Read = false;
                    rs.Write = false;
                    compMode = false;
                    button10.Enabled = true;
                    //button22.Enabled = true;
                    break;
                case CAL:
                    rs.CF = false; 
                    rs.Read = false;
                    rs.Write = false;
                    doCalMode = false;
                    button17.Enabled = true;
                    lblResult0.ForeColor = Color.Silver;
                    lblResultCalF.ForeColor = Color.Silver;
                    break;
            }
            next = 1;
            modeTimer.Stop();
        }
        #endregion

    }
}