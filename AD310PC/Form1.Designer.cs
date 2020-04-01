namespace AD310AD
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

            Properties.Settings.Default.Save();
            //lineNum = 0;
            serialPort1.Close();//
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.modeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblHold_ = new System.Windows.Forms.Label();
            this.lblNet_ = new System.Windows.Forms.Label();
            this.lblZero_ = new System.Windows.Forms.Label();
            this.lblStable_ = new System.Windows.Forms.Label();
            this.lblHold = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblZero = new System.Windows.Forms.Label();
            this.lblStable = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.button30 = new System.Windows.Forms.Button();
            this.dispTimer = new System.Windows.Forms.Timer(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.timer1sec = new System.Windows.Forms.Timer(this.components);
            this.tabVer = new System.Windows.Forms.TabPage();
            this.groupBoxVer = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabInit = new System.Windows.Forms.TabPage();
            this.groupBoxInit2 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.groupBoxInit = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.tabGoCal = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.groupBoxCal = new System.Windows.Forms.GroupBox();
            this.lblResultCalF = new System.Windows.Forms.Label();
            this.lblResult0 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.cmdUnit = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.calCalF = new System.Windows.Forms.NumericUpDown();
            this.calDigit = new System.Windows.Forms.ComboBox();
            this.calPoint = new System.Windows.Forms.ComboBox();
            this.calCapa = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button18 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.tabComp = new System.Windows.Forms.TabPage();
            this.button22 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBoxComp = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.cmdCmpOn = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmdCmpValue = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.cmdCompZero = new System.Windows.Forms.TextBox();
            this.cmdCmpMode = new System.Windows.Forms.ComboBox();
            this.tabSetBasic = new System.Windows.Forms.TabPage();
            this.groupBoxBasic2 = new System.Windows.Forms.GroupBox();
            this.label71 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.cmdZeroTracking = new System.Windows.Forms.NumericUpDown();
            this.cmdZeroRange = new System.Windows.Forms.TextBox();
            this.label72 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.cmdZeroTime = new System.Windows.Forms.NumericUpDown();
            this.label78 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.cmdPOZ = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.button21 = new System.Windows.Forms.Button();
            this.btnLoad1 = new System.Windows.Forms.Button();
            this.groupBoxBasic = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCutoff = new System.Windows.Forms.ComboBox();
            this.cmbHoldtime = new System.Windows.Forms.NumericUpDown();
            this.cmbHoldmode = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.tabSetRS = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.groupBoxRS = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.cmdTerminator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cmdStopbits = new System.Windows.Forms.ComboBox();
            this.cmdBaudrate = new System.Windows.Forms.ComboBox();
            this.cmdParity = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cmdDatabits = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.tabSetPC = new System.Windows.Forms.TabPage();
            this.groupBoxPC = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbTerminator = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDatabits = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.cmbStopbits = new System.Windows.Forms.ComboBox();
            this.cmbBaudrate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timerInit = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            this.tabVer.SuspendLayout();
            this.groupBoxVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabInit.SuspendLayout();
            this.groupBoxInit2.SuspendLayout();
            this.groupBoxInit.SuspendLayout();
            this.tabGoCal.SuspendLayout();
            this.groupBoxCal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCalF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCapa)).BeginInit();
            this.tabComp.SuspendLayout();
            this.groupBoxComp.SuspendLayout();
            this.tabSetBasic.SuspendLayout();
            this.groupBoxBasic2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdZeroTracking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdZeroTime)).BeginInit();
            this.groupBoxBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHoldtime)).BeginInit();
            this.tabSetRS.SuspendLayout();
            this.groupBoxRS.SuspendLayout();
            this.tabSetPC.SuspendLayout();
            this.groupBoxPC.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "COM1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox5.Location = new System.Drawing.Point(86, 196);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(84, 20);
            this.comboBox5.TabIndex = 9;
            this.comboBox5.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Baudrate";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.comboBox4.Location = new System.Drawing.Point(86, 152);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(84, 20);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.Text = "Even";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Databits";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(86, 108);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(84, 20);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parity";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "28800"});
            this.comboBox2.Location = new System.Drawing.Point(86, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 20);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "2400";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stopbits";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 340);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 16);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "설정 감추기";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 40);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 260);
            this.textBox2.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 13);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "갱신";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(322, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(58, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "변경";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(24, 20);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 21);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "F";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 20);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 21);
            this.textBox3.TabIndex = 11;
            // 
            // modeTimer
            // 
            this.modeTimer.Interval = 300;
            this.modeTimer.Tick += new System.EventHandler(this.modeTimer_Tick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.lblUnit);
            this.panel1.Controls.Add(this.lblHold_);
            this.panel1.Controls.Add(this.lblNet_);
            this.panel1.Controls.Add(this.lblZero_);
            this.panel1.Controls.Add(this.lblStable_);
            this.panel1.Controls.Add(this.lblHold);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblNet);
            this.panel1.Controls.Add(this.lblZero);
            this.panel1.Controls.Add(this.lblStable);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 323);
            this.panel1.TabIndex = 25;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.Font = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUnit.ForeColor = System.Drawing.Color.White;
            this.lblUnit.Location = new System.Drawing.Point(504, 180);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(0, 46);
            this.lblUnit.TabIndex = 67;
            // 
            // lblHold_
            // 
            this.lblHold_.AutoSize = true;
            this.lblHold_.BackColor = System.Drawing.Color.Transparent;
            this.lblHold_.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHold_.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblHold_.Location = new System.Drawing.Point(14, 141);
            this.lblHold_.Name = "lblHold_";
            this.lblHold_.Size = new System.Drawing.Size(62, 25);
            this.lblHold_.TabIndex = 65;
            this.lblHold_.Text = "HOLD";
            this.lblHold_.Visible = false;
            // 
            // lblNet_
            // 
            this.lblNet_.AutoSize = true;
            this.lblNet_.BackColor = System.Drawing.Color.Transparent;
            this.lblNet_.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNet_.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblNet_.Location = new System.Drawing.Point(14, 219);
            this.lblNet_.Name = "lblNet_";
            this.lblNet_.Size = new System.Drawing.Size(46, 25);
            this.lblNet_.TabIndex = 64;
            this.lblNet_.Text = "NET";
            this.lblNet_.Visible = false;
            // 
            // lblZero_
            // 
            this.lblZero_.AutoSize = true;
            this.lblZero_.BackColor = System.Drawing.Color.Transparent;
            this.lblZero_.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblZero_.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblZero_.Location = new System.Drawing.Point(14, 180);
            this.lblZero_.Name = "lblZero_";
            this.lblZero_.Size = new System.Drawing.Size(59, 25);
            this.lblZero_.TabIndex = 63;
            this.lblZero_.Text = "ZERO";
            this.lblZero_.Visible = false;
            // 
            // lblStable_
            // 
            this.lblStable_.AutoSize = true;
            this.lblStable_.BackColor = System.Drawing.Color.Transparent;
            this.lblStable_.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStable_.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblStable_.Location = new System.Drawing.Point(14, 102);
            this.lblStable_.Margin = new System.Windows.Forms.Padding(0);
            this.lblStable_.Name = "lblStable_";
            this.lblStable_.Size = new System.Drawing.Size(75, 25);
            this.lblStable_.TabIndex = 62;
            this.lblStable_.Text = "STABLE";
            this.lblStable_.Visible = false;
            // 
            // lblHold
            // 
            this.lblHold.AutoSize = true;
            this.lblHold.BackColor = System.Drawing.Color.Transparent;
            this.lblHold.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHold.ForeColor = System.Drawing.Color.Transparent;
            this.lblHold.Location = new System.Drawing.Point(14, 141);
            this.lblHold.Name = "lblHold";
            this.lblHold.Size = new System.Drawing.Size(62, 25);
            this.lblHold.TabIndex = 61;
            this.lblHold.Text = "HOLD";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Cursor = System.Windows.Forms.Cursors.Default;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Location = new System.Drawing.Point(565, 124);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 75);
            this.button6.TabIndex = 60;
            this.button6.Text = "GROSS\r\nNET";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(177, 29);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(161, 41);
            this.label26.TabIndex = 48;
            this.label26.Text = "AD-310PC";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(92, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.BackColor = System.Drawing.Color.Transparent;
            this.lblNet.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNet.ForeColor = System.Drawing.Color.Transparent;
            this.lblNet.Location = new System.Drawing.Point(14, 219);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(46, 25);
            this.lblNet.TabIndex = 37;
            this.lblNet.Text = "NET";
            // 
            // lblZero
            // 
            this.lblZero.AutoSize = true;
            this.lblZero.BackColor = System.Drawing.Color.Transparent;
            this.lblZero.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblZero.ForeColor = System.Drawing.Color.Transparent;
            this.lblZero.Location = new System.Drawing.Point(14, 180);
            this.lblZero.Name = "lblZero";
            this.lblZero.Size = new System.Drawing.Size(59, 25);
            this.lblZero.TabIndex = 36;
            this.lblZero.Text = "ZERO";
            // 
            // lblStable
            // 
            this.lblStable.AutoSize = true;
            this.lblStable.BackColor = System.Drawing.Color.Transparent;
            this.lblStable.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStable.ForeColor = System.Drawing.Color.Transparent;
            this.lblStable.Location = new System.Drawing.Point(14, 102);
            this.lblStable.Margin = new System.Windows.Forms.Padding(0);
            this.lblStable.Name = "lblStable";
            this.lblStable.Size = new System.Drawing.Size(75, 25);
            this.lblStable.TabIndex = 35;
            this.lblStable.Text = "STABLE";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.CausesValidation = false;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("SegmentA1", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(90, 102);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.MaxLength = 1000;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(413, 143);
            this.textBox1.TabIndex = 30;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "off";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.WordWrap = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Cursor = System.Windows.Forms.Cursors.Default;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Location = new System.Drawing.Point(643, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 75);
            this.button5.TabIndex = 29;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.Location = new System.Drawing.Point(643, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 28;
            this.button4.Text = "HOLD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(643, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 27;
            this.button3.Text = "ZERO\r\nTARE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(565, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 26;
            this.button2.Text = "ON";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(120)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(565, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 25;
            this.button1.Text = "CLEAR\r\nTARE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(6, 20);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(66, 23);
            this.button12.TabIndex = 14;
            this.button12.Text = "불러오기";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(6, 49);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(348, 196);
            this.listBox2.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(16, 18);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 21);
            this.textBox7.TabIndex = 23;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(284, 18);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(58, 21);
            this.button13.TabIndex = 25;
            this.button13.Text = "변경";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(16, 19);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 65);
            this.button25.TabIndex = 14;
            this.button25.Text = "설정\r\n\r\n불러오기";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox17.Location = new System.Drawing.Point(14, 193);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(220, 29);
            this.textBox17.TabIndex = 22;
            this.textBox17.Text = "시간과 폭은 0.1초 단위로 설정.\r\n0.0일 경우 Hysteresis는 사용되지 않음.";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 1;
            this.numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown4.Location = new System.Drawing.Point(87, 138);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown4.TabIndex = 20;
            this.numericUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Location = new System.Drawing.Point(12, 64);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(0, 12);
            this.label55.TabIndex = 18;
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.DecimalPlaces = 1;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown5.Location = new System.Drawing.Point(87, 99);
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown5.TabIndex = 17;
            this.numericUpDown5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // comboBox19
            // 
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Items.AddRange(new object[] {
            "상향 2단계 판정",
            "상하한치 판정",
            "하향 2단계 판정"});
            this.comboBox19.Location = new System.Drawing.Point(87, 61);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(121, 20);
            this.comboBox19.TabIndex = 9;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(7, 144);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(17, 12);
            this.label56.TabIndex = 8;
            this.label56.Text = "폭";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(7, 101);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(29, 12);
            this.label57.TabIndex = 7;
            this.label57.Text = "시간";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(6, 64);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(29, 12);
            this.label58.TabIndex = 6;
            this.label58.Text = "모드";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Location = new System.Drawing.Point(6, 33);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(93, 12);
            this.label59.TabIndex = 5;
            this.label59.Text = "Hysteresis 설정";
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(241, 201);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(50, 23);
            this.button30.TabIndex = 4;
            this.button30.Text = "적용";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // dispTimer
            // 
            this.dispTimer.Tick += new System.EventHandler(this.dispTimer_Tick);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(17, 39);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(27, 12);
            this.label30.TabIndex = 0;
            this.label30.Text = "Port";
            // 
            // comboBox12
            // 
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox12.Location = new System.Drawing.Point(89, 120);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(84, 20);
            this.comboBox12.TabIndex = 8;
            this.comboBox12.Text = "Even";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(17, 179);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 12);
            this.label32.TabIndex = 38;
            this.label32.Text = "Terminator";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(17, 95);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(50, 12);
            this.label36.TabIndex = 2;
            this.label36.Text = "Databits";
            // 
            // comboBox13
            // 
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "CRLF",
            "CR"});
            this.comboBox13.Location = new System.Drawing.Point(89, 176);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(84, 20);
            this.comboBox13.TabIndex = 37;
            this.comboBox13.Text = "CRLF";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(17, 67);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(55, 12);
            this.label40.TabIndex = 1;
            this.label40.Text = "Baudrate";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(17, 151);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(50, 12);
            this.label41.TabIndex = 4;
            this.label41.Text = "Stopbits";
            // 
            // comboBox14
            // 
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBox14.Location = new System.Drawing.Point(89, 92);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(84, 20);
            this.comboBox14.TabIndex = 7;
            this.comboBox14.Text = "7";
            // 
            // comboBox15
            // 
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Location = new System.Drawing.Point(89, 36);
            this.comboBox15.MaxDropDownItems = 20;
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(84, 20);
            this.comboBox15.Sorted = true;
            this.comboBox15.TabIndex = 5;
            this.comboBox15.Text = "COM1";
            // 
            // comboBox17
            // 
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBox17.Location = new System.Drawing.Point(89, 148);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(84, 20);
            this.comboBox17.TabIndex = 9;
            this.comboBox17.Text = "1";
            // 
            // comboBox18
            // 
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBox18.Location = new System.Drawing.Point(89, 64);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(84, 20);
            this.comboBox18.TabIndex = 6;
            this.comboBox18.Text = "2400";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(17, 123);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 12);
            this.label42.TabIndex = 3;
            this.label42.Text = "Parity";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(570, 339);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 16);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "통상 모드";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(648, 339);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 16);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.Text = "설정 모드";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // timer1sec
            // 
            this.timer1sec.Interval = 1000;
            this.timer1sec.Tick += new System.EventHandler(this.timer1sec_Tick);
            // 
            // tabVer
            // 
            this.tabVer.Controls.Add(this.groupBoxVer);
            this.tabVer.Location = new System.Drawing.Point(4, 22);
            this.tabVer.Name = "tabVer";
            this.tabVer.Size = new System.Drawing.Size(733, 266);
            this.tabVer.TabIndex = 11;
            this.tabVer.Text = "정보";
            this.tabVer.UseVisualStyleBackColor = true;
            this.tabVer.Enter += new System.EventHandler(this.tabVer_Enter);
            // 
            // groupBoxVer
            // 
            this.groupBoxVer.Controls.Add(this.pictureBox2);
            this.groupBoxVer.Controls.Add(this.lblVer);
            this.groupBoxVer.Controls.Add(this.label25);
            this.groupBoxVer.Controls.Add(this.linkLabel1);
            this.groupBoxVer.Controls.Add(this.label21);
            this.groupBoxVer.Controls.Add(this.label18);
            this.groupBoxVer.Controls.Add(this.pictureBox1);
            this.groupBoxVer.Controls.Add(this.label15);
            this.groupBoxVer.Location = new System.Drawing.Point(11, 11);
            this.groupBoxVer.Name = "groupBoxVer";
            this.groupBoxVer.Size = new System.Drawing.Size(710, 240);
            this.groupBoxVer.TabIndex = 1;
            this.groupBoxVer.TabStop = false;
            this.groupBoxVer.Text = "제품 정보";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AD310AD.Properties.Resources.ADK_PD_Small_QR_;
            this.pictureBox2.Location = new System.Drawing.Point(66, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(586, 73);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVer.Location = new System.Drawing.Point(184, 98);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(64, 11);
            this.lblVer.TabIndex = 54;
            this.lblVer.Text = "ROM 버전 :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label25.Location = new System.Drawing.Point(73, 98);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(85, 11);
            this.label25.TabIndex = 53;
            this.label25.Text = "제품 버전 : 2.00";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.linkLabel1.Location = new System.Drawing.Point(291, 134);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(135, 11);
            this.linkLabel1.TabIndex = 50;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(http://www.andk.co.kr)";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(73, 134);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(418, 11);
            this.label21.TabIndex = 52;
            this.label21.Text = "본 프로그램의 저작권은 한국에이·엔·디(주)                                  에 있습니다.";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(178, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(189, 47);
            this.label18.TabIndex = 49;
            this.label18.Text = "AD-310PC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(73, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("굴림", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.Location = new System.Drawing.Point(73, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 10);
            this.label15.TabIndex = 9;
            this.label15.Text = "한국에이·엔·디(주)";
            // 
            // tabInit
            // 
            this.tabInit.Controls.Add(this.groupBoxInit2);
            this.tabInit.Controls.Add(this.groupBoxInit);
            this.tabInit.Location = new System.Drawing.Point(4, 22);
            this.tabInit.Name = "tabInit";
            this.tabInit.Size = new System.Drawing.Size(733, 266);
            this.tabInit.TabIndex = 10;
            this.tabInit.Text = "초기화";
            this.tabInit.UseVisualStyleBackColor = true;
            // 
            // groupBoxInit2
            // 
            this.groupBoxInit2.Controls.Add(this.textBox5);
            this.groupBoxInit2.Controls.Add(this.button11);
            this.groupBoxInit2.Enabled = false;
            this.groupBoxInit2.Location = new System.Drawing.Point(372, 11);
            this.groupBoxInit2.Name = "groupBoxInit2";
            this.groupBoxInit2.Size = new System.Drawing.Size(350, 240);
            this.groupBoxInit2.TabIndex = 1;
            this.groupBoxInit2.TabStop = false;
            this.groupBoxInit2.Text = "활성화 하려면 설정 모드로 변경";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox5.Location = new System.Drawing.Point(144, 89);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(169, 72);
            this.textBox5.TabIndex = 56;
            this.textBox5.Text = "초기화 적용 범위\r\n\r\n- 통신설정\r\n- 기본설정\r\n- 외부출력\r\n- 교정";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(43, 86);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 75);
            this.button11.TabIndex = 5;
            this.button11.Text = "모든 설정\r\n\r\n초기화";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // groupBoxInit
            // 
            this.groupBoxInit.Controls.Add(this.textBox10);
            this.groupBoxInit.Controls.Add(this.button23);
            this.groupBoxInit.Enabled = false;
            this.groupBoxInit.Location = new System.Drawing.Point(11, 11);
            this.groupBoxInit.Name = "groupBoxInit";
            this.groupBoxInit.Size = new System.Drawing.Size(350, 240);
            this.groupBoxInit.TabIndex = 0;
            this.groupBoxInit.TabStop = false;
            this.groupBoxInit.Text = "활성화 하려면 설정 모드로 변경";
            // 
            // textBox10
            // 
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox10.Location = new System.Drawing.Point(146, 91);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(169, 62);
            this.textBox10.TabIndex = 55;
            this.textBox10.Text = "초기화 적용 범위\r\n\r\n- 통신설정\r\n- 기본설정(좌)\r\n- 외부출력";
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(45, 86);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 75);
            this.button23.TabIndex = 6;
            this.button23.Text = "F 펑션\r\n\r\n초기화";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // tabGoCal
            // 
            this.tabGoCal.Controls.Add(this.button17);
            this.tabGoCal.Controls.Add(this.groupBoxCal);
            this.tabGoCal.Location = new System.Drawing.Point(4, 22);
            this.tabGoCal.Name = "tabGoCal";
            this.tabGoCal.Padding = new System.Windows.Forms.Padding(3);
            this.tabGoCal.Size = new System.Drawing.Size(733, 266);
            this.tabGoCal.TabIndex = 3;
            this.tabGoCal.Text = "교정";
            this.tabGoCal.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Enabled = false;
            this.button17.Location = new System.Drawing.Point(644, 88);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 75);
            this.button17.TabIndex = 39;
            this.button17.Text = "CAL 정보\r\n\r\n불러오기";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // groupBoxCal
            // 
            this.groupBoxCal.Controls.Add(this.lblResultCalF);
            this.groupBoxCal.Controls.Add(this.lblResult0);
            this.groupBoxCal.Controls.Add(this.label24);
            this.groupBoxCal.Controls.Add(this.textBox13);
            this.groupBoxCal.Controls.Add(this.cmdUnit);
            this.groupBoxCal.Controls.Add(this.label14);
            this.groupBoxCal.Controls.Add(this.calCalF);
            this.groupBoxCal.Controls.Add(this.calDigit);
            this.groupBoxCal.Controls.Add(this.calPoint);
            this.groupBoxCal.Controls.Add(this.calCapa);
            this.groupBoxCal.Controls.Add(this.label16);
            this.groupBoxCal.Controls.Add(this.label19);
            this.groupBoxCal.Controls.Add(this.label17);
            this.groupBoxCal.Controls.Add(this.button18);
            this.groupBoxCal.Controls.Add(this.button15);
            this.groupBoxCal.Controls.Add(this.label23);
            this.groupBoxCal.Controls.Add(this.label20);
            this.groupBoxCal.Controls.Add(this.label22);
            this.groupBoxCal.Controls.Add(this.button16);
            this.groupBoxCal.Enabled = false;
            this.groupBoxCal.Location = new System.Drawing.Point(11, 11);
            this.groupBoxCal.Name = "groupBoxCal";
            this.groupBoxCal.Size = new System.Drawing.Size(610, 240);
            this.groupBoxCal.TabIndex = 38;
            this.groupBoxCal.TabStop = false;
            this.groupBoxCal.Text = "활성화 하려면 CAL 정보를 불러옵니다.";
            // 
            // lblResultCalF
            // 
            this.lblResultCalF.AutoSize = true;
            this.lblResultCalF.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResultCalF.ForeColor = System.Drawing.Color.Silver;
            this.lblResultCalF.Location = new System.Drawing.Point(552, 180);
            this.lblResultCalF.Name = "lblResultCalF";
            this.lblResultCalF.Size = new System.Drawing.Size(25, 15);
            this.lblResultCalF.TabIndex = 74;
            this.lblResultCalF.Text = "...";
            // 
            // lblResult0
            // 
            this.lblResult0.AutoSize = true;
            this.lblResult0.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResult0.ForeColor = System.Drawing.Color.Silver;
            this.lblResult0.Location = new System.Drawing.Point(392, 147);
            this.lblResult0.Name = "lblResult0";
            this.lblResult0.Size = new System.Drawing.Size(25, 15);
            this.lblResult0.TabIndex = 73;
            this.lblResult0.Text = "...";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(48, 181);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(419, 12);
            this.label24.TabIndex = 72;
            this.label24.Text = "3. SPAN 값을 입력하고 로드셀에 분동을 올린 후 \"CALF\" 버튼을 클릭합니다.";
            // 
            // textBox13
            // 
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox13.Location = new System.Drawing.Point(269, 204);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(177, 24);
            this.textBox13.TabIndex = 71;
            this.textBox13.Text = "Span(측정점-제로점)의 표시 값\r\n소수점 위치는 현재 설정값에 연동";
            // 
            // cmdUnit
            // 
            this.cmdUnit.FormattingEnabled = true;
            this.cmdUnit.Items.AddRange(new object[] {
            "없음",
            "g",
            "kg",
            "t"});
            this.cmdUnit.Location = new System.Drawing.Point(134, 115);
            this.cmdUnit.Name = "cmdUnit";
            this.cmdUnit.Size = new System.Drawing.Size(116, 20);
            this.cmdUnit.TabIndex = 68;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(67, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 67;
            this.label14.Text = "단위";
            // 
            // calCalF
            // 
            this.calCalF.Location = new System.Drawing.Point(134, 207);
            this.calCalF.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.calCalF.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.calCalF.Name = "calCalF";
            this.calCalF.Size = new System.Drawing.Size(116, 21);
            this.calCalF.TabIndex = 66;
            this.calCalF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calDigit
            // 
            this.calDigit.FormattingEnabled = true;
            this.calDigit.Items.AddRange(new object[] {
            "1 눈금",
            "2 눈금",
            "5 눈금",
            "10 눈금",
            "20 눈금",
            "50 눈금"});
            this.calDigit.Location = new System.Drawing.Point(134, 69);
            this.calDigit.Name = "calDigit";
            this.calDigit.Size = new System.Drawing.Size(116, 20);
            this.calDigit.TabIndex = 65;
            // 
            // calPoint
            // 
            this.calPoint.FormattingEnabled = true;
            this.calPoint.Items.AddRange(new object[] {
            "0000",
            "000.0",
            "00.00",
            "0.000"});
            this.calPoint.Location = new System.Drawing.Point(134, 92);
            this.calPoint.Name = "calPoint";
            this.calPoint.Size = new System.Drawing.Size(116, 20);
            this.calPoint.TabIndex = 64;
            // 
            // calCapa
            // 
            this.calCapa.Location = new System.Drawing.Point(134, 45);
            this.calCapa.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.calCapa.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.calCapa.Name = "calCapa";
            this.calCapa.Size = new System.Drawing.Size(116, 21);
            this.calCapa.TabIndex = 38;
            this.calCapa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 8F);
            this.label16.Location = new System.Drawing.Point(67, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 11);
            this.label16.TabIndex = 21;
            this.label16.Text = "CAPA";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 9F);
            this.label19.Location = new System.Drawing.Point(65, 209);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 12);
            this.label19.TabIndex = 35;
            this.label19.Text = "SPAN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("굴림", 8F);
            this.label17.Location = new System.Drawing.Point(67, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 11);
            this.label17.TabIndex = 23;
            this.label17.Text = "DIV";
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(311, 143);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 33;
            this.button18.Text = "CAL0";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(473, 176);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 25;
            this.button15.Text = "CALF";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(48, 148);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(257, 12);
            this.label23.TabIndex = 32;
            this.label23.Text = "2. 무부하 상태에서 \"CAL0\" 버튼을 클릭합니다.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 8F);
            this.label20.Location = new System.Drawing.Point(67, 99);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 11);
            this.label20.TabIndex = 26;
            this.label20.Text = "소수점";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(48, 23);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(243, 12);
            this.label22.TabIndex = 31;
            this.label22.Text = "1. 설정값 변경 후 \"적용\" 버튼을 클릭합니다.";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(297, 18);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 28;
            this.button16.Text = "적용";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // tabComp
            // 
            this.tabComp.Controls.Add(this.button22);
            this.tabComp.Controls.Add(this.button10);
            this.tabComp.Controls.Add(this.groupBoxComp);
            this.tabComp.Location = new System.Drawing.Point(4, 22);
            this.tabComp.Name = "tabComp";
            this.tabComp.Size = new System.Drawing.Size(733, 266);
            this.tabComp.TabIndex = 9;
            this.tabComp.Text = "외부출력";
            this.tabComp.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Enabled = false;
            this.button22.Location = new System.Drawing.Point(644, 141);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 75);
            this.button22.TabIndex = 28;
            this.button22.Text = "적용";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(644, 60);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 75);
            this.button10.TabIndex = 27;
            this.button10.Text = "설정\r\n\r\n불러오기";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBoxComp
            // 
            this.groupBoxComp.Controls.Add(this.label48);
            this.groupBoxComp.Controls.Add(this.label51);
            this.groupBoxComp.Controls.Add(this.label45);
            this.groupBoxComp.Controls.Add(this.cmdCmpOn);
            this.groupBoxComp.Controls.Add(this.label46);
            this.groupBoxComp.Controls.Add(this.textBox6);
            this.groupBoxComp.Controls.Add(this.cmdCmpValue);
            this.groupBoxComp.Controls.Add(this.label47);
            this.groupBoxComp.Controls.Add(this.cmdCompZero);
            this.groupBoxComp.Controls.Add(this.cmdCmpMode);
            this.groupBoxComp.Enabled = false;
            this.groupBoxComp.Location = new System.Drawing.Point(11, 11);
            this.groupBoxComp.Name = "groupBoxComp";
            this.groupBoxComp.Size = new System.Drawing.Size(610, 240);
            this.groupBoxComp.TabIndex = 25;
            this.groupBoxComp.TabStop = false;
            this.groupBoxComp.Text = "활성화 하려면 설정을 불러옵니다.";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(48, 61);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 12);
            this.label48.TabIndex = 6;
            this.label48.Text = "설정 값 보다";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(258, 61);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(29, 12);
            this.label51.TabIndex = 24;
            this.label51.Text = "출력";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(48, 168);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 12);
            this.label45.TabIndex = 9;
            this.label45.Text = "제로  근처";
            // 
            // cmdCmpOn
            // 
            this.cmdCmpOn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmdCmpOn.FormattingEnabled = true;
            this.cmdCmpOn.Items.AddRange(new object[] {
            "높을 때",
            "낮을 때"});
            this.cmdCmpOn.Location = new System.Drawing.Point(131, 58);
            this.cmdCmpOn.Name = "cmdCmpOn";
            this.cmdCmpOn.Size = new System.Drawing.Size(121, 20);
            this.cmdCmpOn.TabIndex = 7;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(48, 131);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(29, 12);
            this.label46.TabIndex = 8;
            this.label46.Text = "모드";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6.Location = new System.Drawing.Point(258, 94);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(186, 13);
            this.textBox6.TabIndex = 23;
            this.textBox6.Text = "소수점 위치는 현재 설정 값에 연동";
            // 
            // cmdCmpValue
            // 
            this.cmdCmpValue.Location = new System.Drawing.Point(131, 90);
            this.cmdCmpValue.Name = "cmdCmpValue";
            this.cmdCmpValue.Size = new System.Drawing.Size(121, 21);
            this.cmdCmpValue.TabIndex = 11;
            this.cmdCmpValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(48, 93);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(45, 12);
            this.label47.TabIndex = 7;
            this.label47.Text = "설정 값";
            // 
            // cmdCompZero
            // 
            this.cmdCompZero.Location = new System.Drawing.Point(131, 164);
            this.cmdCompZero.Name = "cmdCompZero";
            this.cmdCompZero.Size = new System.Drawing.Size(121, 21);
            this.cmdCompZero.TabIndex = 12;
            this.cmdCompZero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdCmpMode
            // 
            this.cmdCmpMode.FormattingEnabled = true;
            this.cmdCmpMode.Items.AddRange(new object[] {
            "상향 2단계 판정",
            "상하한치 판정",
            "하향 2단계 판정"});
            this.cmdCmpMode.Location = new System.Drawing.Point(131, 128);
            this.cmdCmpMode.Name = "cmdCmpMode";
            this.cmdCmpMode.Size = new System.Drawing.Size(121, 20);
            this.cmdCmpMode.TabIndex = 10;
            // 
            // tabSetBasic
            // 
            this.tabSetBasic.Controls.Add(this.groupBoxBasic2);
            this.tabSetBasic.Controls.Add(this.button21);
            this.tabSetBasic.Controls.Add(this.btnLoad1);
            this.tabSetBasic.Controls.Add(this.groupBoxBasic);
            this.tabSetBasic.Controls.Add(this.label37);
            this.tabSetBasic.Location = new System.Drawing.Point(4, 22);
            this.tabSetBasic.Name = "tabSetBasic";
            this.tabSetBasic.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetBasic.Size = new System.Drawing.Size(733, 266);
            this.tabSetBasic.TabIndex = 5;
            this.tabSetBasic.Text = "기본설정";
            this.tabSetBasic.UseVisualStyleBackColor = true;
            // 
            // groupBoxBasic2
            // 
            this.groupBoxBasic2.Controls.Add(this.label71);
            this.groupBoxBasic2.Controls.Add(this.label69);
            this.groupBoxBasic2.Controls.Add(this.textBox25);
            this.groupBoxBasic2.Controls.Add(this.label50);
            this.groupBoxBasic2.Controls.Add(this.cmdZeroTracking);
            this.groupBoxBasic2.Controls.Add(this.cmdZeroRange);
            this.groupBoxBasic2.Controls.Add(this.label72);
            this.groupBoxBasic2.Controls.Add(this.textBox9);
            this.groupBoxBasic2.Controls.Add(this.cmdZeroTime);
            this.groupBoxBasic2.Controls.Add(this.label78);
            this.groupBoxBasic2.Controls.Add(this.label70);
            this.groupBoxBasic2.Controls.Add(this.textBox24);
            this.groupBoxBasic2.Controls.Add(this.cmdPOZ);
            this.groupBoxBasic2.Controls.Add(this.label35);
            this.groupBoxBasic2.Enabled = false;
            this.groupBoxBasic2.Location = new System.Drawing.Point(317, 11);
            this.groupBoxBasic2.Name = "groupBoxBasic2";
            this.groupBoxBasic2.Size = new System.Drawing.Size(300, 240);
            this.groupBoxBasic2.TabIndex = 54;
            this.groupBoxBasic2.TabStop = false;
            this.groupBoxBasic2.Text = "활성화 하려면 설정을 불러옵니다.";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(26, 201);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(73, 12);
            this.label71.TabIndex = 57;
            this.label71.Text = "파워 온 제로";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(26, 34);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(85, 12);
            this.label69.TabIndex = 52;
            this.label69.Text = "제로 확보 범위";
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox25.Location = new System.Drawing.Point(28, 177);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(225, 11);
            this.textBox25.TabIndex = 56;
            this.textBox25.Text = "영점 트래킹 시간을 합쳐 시행";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(26, 93);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(97, 12);
            this.label50.TabIndex = 61;
            this.label50.Text = "영점 트래킹 시간";
            // 
            // cmdZeroTracking
            // 
            this.cmdZeroTracking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdZeroTracking.DecimalPlaces = 1;
            this.cmdZeroTracking.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cmdZeroTracking.Location = new System.Drawing.Point(141, 150);
            this.cmdZeroTracking.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            65536});
            this.cmdZeroTracking.Name = "cmdZeroTracking";
            this.cmdZeroTracking.Size = new System.Drawing.Size(112, 21);
            this.cmdZeroTracking.TabIndex = 65;
            this.cmdZeroTracking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmdZeroRange
            // 
            this.cmdZeroRange.Location = new System.Drawing.Point(141, 31);
            this.cmdZeroRange.Name = "cmdZeroRange";
            this.cmdZeroRange.Size = new System.Drawing.Size(112, 21);
            this.cmdZeroRange.TabIndex = 53;
            this.cmdZeroRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(259, 156);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(28, 12);
            this.label72.TabIndex = 58;
            this.label72.Text = "digit";
            // 
            // textBox9
            // 
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox9.Location = new System.Drawing.Point(28, 116);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(225, 24);
            this.textBox9.TabIndex = 62;
            this.textBox9.Text = "영점트래킹 폭과 조합하여 시행\r\n단위는 초, 0.0은 시행 안함.";
            // 
            // cmdZeroTime
            // 
            this.cmdZeroTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdZeroTime.DecimalPlaces = 1;
            this.cmdZeroTime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cmdZeroTime.Location = new System.Drawing.Point(141, 89);
            this.cmdZeroTime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cmdZeroTime.Name = "cmdZeroTime";
            this.cmdZeroTime.Size = new System.Drawing.Size(112, 21);
            this.cmdZeroTime.TabIndex = 64;
            this.cmdZeroTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(259, 34);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(15, 12);
            this.label78.TabIndex = 60;
            this.label78.Text = "%";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(26, 156);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(85, 12);
            this.label70.TabIndex = 55;
            this.label70.Text = "영점 트래킹 폭";
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox24.Location = new System.Drawing.Point(28, 58);
            this.textBox24.Multiline = true;
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(225, 24);
            this.textBox24.TabIndex = 54;
            this.textBox24.Text = "영점 키를 받아들이는 범위로 영점 교정 값을 \r\n중심으로 최대 측정값에 비하여 %로 표시함";
            // 
            // cmdPOZ
            // 
            this.cmdPOZ.FormattingEnabled = true;
            this.cmdPOZ.Items.AddRange(new object[] {
            "OFF",
            "ON"});
            this.cmdPOZ.Location = new System.Drawing.Point(141, 198);
            this.cmdPOZ.Name = "cmdPOZ";
            this.cmdPOZ.Size = new System.Drawing.Size(112, 20);
            this.cmdPOZ.TabIndex = 59;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(259, 93);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(17, 12);
            this.label35.TabIndex = 63;
            this.label35.Text = "초";
            // 
            // button21
            // 
            this.button21.Enabled = false;
            this.button21.Location = new System.Drawing.Point(644, 141);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 75);
            this.button21.TabIndex = 53;
            this.button21.Text = "적용";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // btnLoad1
            // 
            this.btnLoad1.Enabled = false;
            this.btnLoad1.Location = new System.Drawing.Point(644, 60);
            this.btnLoad1.Name = "btnLoad1";
            this.btnLoad1.Size = new System.Drawing.Size(75, 75);
            this.btnLoad1.TabIndex = 52;
            this.btnLoad1.Text = "설정\r\n\r\n불러오기";
            this.btnLoad1.UseVisualStyleBackColor = true;
            this.btnLoad1.Click += new System.EventHandler(this.btnLoad1_Click);
            // 
            // groupBoxBasic
            // 
            this.groupBoxBasic.Controls.Add(this.textBox4);
            this.groupBoxBasic.Controls.Add(this.label34);
            this.groupBoxBasic.Controls.Add(this.label1);
            this.groupBoxBasic.Controls.Add(this.cmbCutoff);
            this.groupBoxBasic.Controls.Add(this.cmbHoldtime);
            this.groupBoxBasic.Controls.Add(this.cmbHoldmode);
            this.groupBoxBasic.Controls.Add(this.label39);
            this.groupBoxBasic.Enabled = false;
            this.groupBoxBasic.Location = new System.Drawing.Point(11, 11);
            this.groupBoxBasic.Name = "groupBoxBasic";
            this.groupBoxBasic.Size = new System.Drawing.Size(300, 240);
            this.groupBoxBasic.TabIndex = 51;
            this.groupBoxBasic.TabStop = false;
            this.groupBoxBasic.Text = "활성화 하려면 설정을 불러옵니다.";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("굴림", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(32, 165);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(225, 24);
            this.textBox4.TabIndex = 66;
            this.textBox4.Text = "평균화 시간은 샘플홀드에서만 작동하며,\r\n0.0초 ~ 9.9초까지 설정 가능.";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(31, 58);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 12);
            this.label34.TabIndex = 6;
            this.label34.Text = "디지털 필터";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "평균화 시간";
            // 
            // cmbCutoff
            // 
            this.cmbCutoff.FormattingEnabled = true;
            this.cmbCutoff.Items.AddRange(new object[] {
            "없음",
            "2.5 Hz",
            "2.0 Hz",
            "1.5 Hz",
            "1.0 Hz",
            "0.7 Hz",
            "0.5 Hz",
            "0.35 Hz",
            "0.25 Hz",
            "0.20 Hz",
            "0.15 Hz",
            "0.10 Hz"});
            this.cmbCutoff.Location = new System.Drawing.Point(136, 55);
            this.cmbCutoff.Name = "cmbCutoff";
            this.cmbCutoff.Size = new System.Drawing.Size(121, 20);
            this.cmbCutoff.TabIndex = 5;
            // 
            // cmbHoldtime
            // 
            this.cmbHoldtime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbHoldtime.DecimalPlaces = 1;
            this.cmbHoldtime.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cmbHoldtime.Location = new System.Drawing.Point(136, 135);
            this.cmbHoldtime.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            65536});
            this.cmbHoldtime.Name = "cmbHoldtime";
            this.cmbHoldtime.Size = new System.Drawing.Size(121, 21);
            this.cmbHoldtime.TabIndex = 49;
            this.cmbHoldtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbHoldmode
            // 
            this.cmbHoldmode.FormattingEnabled = true;
            this.cmbHoldmode.Items.AddRange(new object[] {
            "홀드 하지 않음",
            "샘플 홀드",
            "피크 홀드",
            "버튼 홀드",
            "양극성, 피크 홀드"});
            this.cmbHoldmode.Location = new System.Drawing.Point(136, 92);
            this.cmbHoldmode.Name = "cmbHoldmode";
            this.cmbHoldmode.Size = new System.Drawing.Size(121, 20);
            this.cmbHoldmode.TabIndex = 5;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(31, 95);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(57, 12);
            this.label39.TabIndex = 6;
            this.label39.Text = "홀드 모드";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(19, 45);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(0, 12);
            this.label37.TabIndex = 8;
            // 
            // tabSetRS
            // 
            this.tabSetRS.Controls.Add(this.button20);
            this.tabSetRS.Controls.Add(this.groupBoxRS);
            this.tabSetRS.Controls.Add(this.button7);
            this.tabSetRS.Location = new System.Drawing.Point(4, 22);
            this.tabSetRS.Name = "tabSetRS";
            this.tabSetRS.Padding = new System.Windows.Forms.Padding(3);
            this.tabSetRS.Size = new System.Drawing.Size(733, 266);
            this.tabSetRS.TabIndex = 0;
            this.tabSetRS.Text = "통신설정";
            this.tabSetRS.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Enabled = false;
            this.button20.Location = new System.Drawing.Point(644, 141);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 75);
            this.button20.TabIndex = 15;
            this.button20.Text = "적용";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // groupBoxRS
            // 
            this.groupBoxRS.Controls.Add(this.label27);
            this.groupBoxRS.Controls.Add(this.cmdTerminator);
            this.groupBoxRS.Controls.Add(this.label2);
            this.groupBoxRS.Controls.Add(this.label33);
            this.groupBoxRS.Controls.Add(this.cmdStopbits);
            this.groupBoxRS.Controls.Add(this.cmdBaudrate);
            this.groupBoxRS.Controls.Add(this.cmdParity);
            this.groupBoxRS.Controls.Add(this.label29);
            this.groupBoxRS.Controls.Add(this.label28);
            this.groupBoxRS.Controls.Add(this.cmdDatabits);
            this.groupBoxRS.Enabled = false;
            this.groupBoxRS.Location = new System.Drawing.Point(11, 11);
            this.groupBoxRS.Name = "groupBoxRS";
            this.groupBoxRS.Size = new System.Drawing.Size(610, 240);
            this.groupBoxRS.TabIndex = 42;
            this.groupBoxRS.TabStop = false;
            this.groupBoxRS.Text = "활성화 하려면 설정을 불러옵니다.";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(53, 44);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(55, 12);
            this.label27.TabIndex = 1;
            this.label27.Text = "Baudrate";
            // 
            // cmdTerminator
            // 
            this.cmdTerminator.FormattingEnabled = true;
            this.cmdTerminator.Items.AddRange(new object[] {
            "CRLF",
            "CR"});
            this.cmdTerminator.Location = new System.Drawing.Point(194, 192);
            this.cmdTerminator.Name = "cmdTerminator";
            this.cmdTerminator.Size = new System.Drawing.Size(84, 20);
            this.cmdTerminator.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "Terminator";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(53, 156);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(50, 12);
            this.label33.TabIndex = 4;
            this.label33.Text = "Stopbits";
            // 
            // cmdStopbits
            // 
            this.cmdStopbits.FormattingEnabled = true;
            this.cmdStopbits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmdStopbits.Location = new System.Drawing.Point(194, 154);
            this.cmdStopbits.Name = "cmdStopbits";
            this.cmdStopbits.Size = new System.Drawing.Size(84, 20);
            this.cmdStopbits.TabIndex = 9;
            // 
            // cmdBaudrate
            // 
            this.cmdBaudrate.FormattingEnabled = true;
            this.cmdBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmdBaudrate.Location = new System.Drawing.Point(194, 41);
            this.cmdBaudrate.Name = "cmdBaudrate";
            this.cmdBaudrate.Size = new System.Drawing.Size(84, 20);
            this.cmdBaudrate.TabIndex = 6;
            // 
            // cmdParity
            // 
            this.cmdParity.FormattingEnabled = true;
            this.cmdParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cmdParity.Location = new System.Drawing.Point(194, 116);
            this.cmdParity.Name = "cmdParity";
            this.cmdParity.Size = new System.Drawing.Size(84, 20);
            this.cmdParity.TabIndex = 8;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(53, 118);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(37, 12);
            this.label29.TabIndex = 3;
            this.label29.Text = "Parity";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(53, 80);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(50, 12);
            this.label28.TabIndex = 2;
            this.label28.Text = "Databits";
            // 
            // cmdDatabits
            // 
            this.cmdDatabits.FormattingEnabled = true;
            this.cmdDatabits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmdDatabits.Location = new System.Drawing.Point(194, 78);
            this.cmdDatabits.Name = "cmdDatabits";
            this.cmdDatabits.Size = new System.Drawing.Size(84, 20);
            this.cmdDatabits.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(644, 60);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 75);
            this.button7.TabIndex = 14;
            this.button7.Text = "설정\r\n\r\n불러오기";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabSetPC
            // 
            this.tabSetPC.Controls.Add(this.groupBoxPC);
            this.tabSetPC.Location = new System.Drawing.Point(4, 22);
            this.tabSetPC.Name = "tabSetPC";
            this.tabSetPC.Size = new System.Drawing.Size(733, 266);
            this.tabSetPC.TabIndex = 8;
            this.tabSetPC.Text = "PC설정";
            this.tabSetPC.UseVisualStyleBackColor = true;
            // 
            // groupBoxPC
            // 
            this.groupBoxPC.Controls.Add(this.label8);
            this.groupBoxPC.Controls.Add(this.cmbParity);
            this.groupBoxPC.Controls.Add(this.label44);
            this.groupBoxPC.Controls.Add(this.label10);
            this.groupBoxPC.Controls.Add(this.cmbTerminator);
            this.groupBoxPC.Controls.Add(this.label9);
            this.groupBoxPC.Controls.Add(this.label12);
            this.groupBoxPC.Controls.Add(this.cmbDatabits);
            this.groupBoxPC.Controls.Add(this.cmbPort);
            this.groupBoxPC.Controls.Add(this.cmbStopbits);
            this.groupBoxPC.Controls.Add(this.cmbBaudrate);
            this.groupBoxPC.Controls.Add(this.label11);
            this.groupBoxPC.Location = new System.Drawing.Point(11, 11);
            this.groupBoxPC.Name = "groupBoxPC";
            this.groupBoxPC.Size = new System.Drawing.Size(710, 240);
            this.groupBoxPC.TabIndex = 39;
            this.groupBoxPC.TabStop = false;
            this.groupBoxPC.Text = "PC측 통신 설정 후 ON";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "Port";
            // 
            // cmbParity
            // 
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cmbParity.Location = new System.Drawing.Point(201, 127);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(84, 20);
            this.cmbParity.TabIndex = 8;
            this.cmbParity.TextChanged += new System.EventHandler(this.cmbParity_TextChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(53, 186);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(66, 12);
            this.label44.TabIndex = 38;
            this.label44.Text = "Terminator";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "Databits";
            // 
            // cmbTerminator
            // 
            this.cmbTerminator.FormattingEnabled = true;
            this.cmbTerminator.Items.AddRange(new object[] {
            "CRLF",
            "CR"});
            this.cmbTerminator.Location = new System.Drawing.Point(201, 183);
            this.cmbTerminator.Name = "cmbTerminator";
            this.cmbTerminator.Size = new System.Drawing.Size(84, 20);
            this.cmbTerminator.TabIndex = 37;
            this.cmbTerminator.TextChanged += new System.EventHandler(this.cmbTerminator_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Baudrate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "Stopbits";
            // 
            // cmbDatabits
            // 
            this.cmbDatabits.FormattingEnabled = true;
            this.cmbDatabits.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cmbDatabits.Location = new System.Drawing.Point(201, 99);
            this.cmbDatabits.Name = "cmbDatabits";
            this.cmbDatabits.Size = new System.Drawing.Size(84, 20);
            this.cmbDatabits.TabIndex = 7;
            this.cmbDatabits.TextChanged += new System.EventHandler(this.cmbDatabits_TextChanged);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(201, 43);
            this.cmbPort.MaxDropDownItems = 20;
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(84, 20);
            this.cmbPort.Sorted = true;
            this.cmbPort.TabIndex = 5;
            this.cmbPort.TextChanged += new System.EventHandler(this.cmbPort_TextChanged);
            // 
            // cmbStopbits
            // 
            this.cmbStopbits.FormattingEnabled = true;
            this.cmbStopbits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbStopbits.Location = new System.Drawing.Point(201, 155);
            this.cmbStopbits.Name = "cmbStopbits";
            this.cmbStopbits.Size = new System.Drawing.Size(84, 20);
            this.cmbStopbits.TabIndex = 9;
            this.cmbStopbits.TextChanged += new System.EventHandler(this.cmbStopbits_TextChanged);
            // 
            // cmbBaudrate
            // 
            this.cmbBaudrate.FormattingEnabled = true;
            this.cmbBaudrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.cmbBaudrate.Location = new System.Drawing.Point(201, 71);
            this.cmbBaudrate.Name = "cmbBaudrate";
            this.cmbBaudrate.Size = new System.Drawing.Size(84, 20);
            this.cmbBaudrate.TabIndex = 6;
            this.cmbBaudrate.TextChanged += new System.EventHandler(this.cmbBaudrate_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "Parity";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSetPC);
            this.tabControl1.Controls.Add(this.tabSetRS);
            this.tabControl1.Controls.Add(this.tabSetBasic);
            this.tabControl1.Controls.Add(this.tabComp);
            this.tabControl1.Controls.Add(this.tabGoCal);
            this.tabControl1.Controls.Add(this.tabInit);
            this.tabControl1.Controls.Add(this.tabVer);
            this.tabControl1.Location = new System.Drawing.Point(0, 370);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(741, 292);
            this.tabControl1.TabIndex = 13;
            // 
            // timerInit
            // 
            this.timerInit.Interval = 2000;
            this.timerInit.Tick += new System.EventHandler(this.timerinit_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 662);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(757, 700);
            this.MinimumSize = new System.Drawing.Size(757, 400);
            this.Name = "Form1";
            this.Text = "AD-310PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            this.tabVer.ResumeLayout(false);
            this.groupBoxVer.ResumeLayout(false);
            this.groupBoxVer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabInit.ResumeLayout(false);
            this.groupBoxInit2.ResumeLayout(false);
            this.groupBoxInit2.PerformLayout();
            this.groupBoxInit.ResumeLayout(false);
            this.groupBoxInit.PerformLayout();
            this.tabGoCal.ResumeLayout(false);
            this.groupBoxCal.ResumeLayout(false);
            this.groupBoxCal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calCalF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calCapa)).EndInit();
            this.tabComp.ResumeLayout(false);
            this.groupBoxComp.ResumeLayout(false);
            this.groupBoxComp.PerformLayout();
            this.tabSetBasic.ResumeLayout(false);
            this.tabSetBasic.PerformLayout();
            this.groupBoxBasic2.ResumeLayout(false);
            this.groupBoxBasic2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmdZeroTracking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmdZeroTime)).EndInit();
            this.groupBoxBasic.ResumeLayout(false);
            this.groupBoxBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHoldtime)).EndInit();
            this.tabSetRS.ResumeLayout(false);
            this.groupBoxRS.ResumeLayout(false);
            this.groupBoxRS.PerformLayout();
            this.tabSetPC.ResumeLayout(false);
            this.groupBoxPC.ResumeLayout(false);
            this.groupBoxPC.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox3;
        protected internal System.Windows.Forms.Timer modeTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblZero;
        private System.Windows.Forms.Label lblStable;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Timer dispTimer;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label lblHold;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Timer timer1sec;
        private System.Windows.Forms.Label lblHold_;
        private System.Windows.Forms.Label lblNet_;
        private System.Windows.Forms.Label lblZero_;
        private System.Windows.Forms.Label lblStable_;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TabPage tabVer;
        private System.Windows.Forms.GroupBox groupBoxVer;
        private System.Windows.Forms.TabPage tabInit;
        private System.Windows.Forms.GroupBox groupBoxInit;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TabPage tabGoCal;
        private System.Windows.Forms.GroupBox groupBoxCal;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ComboBox cmdUnit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown calCalF;
        private System.Windows.Forms.ComboBox calDigit;
        private System.Windows.Forms.ComboBox calPoint;
        private System.Windows.Forms.NumericUpDown calCapa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TabPage tabComp;
        private System.Windows.Forms.GroupBox groupBoxComp;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cmdCmpOn;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox cmdCmpValue;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox cmdCompZero;
        private System.Windows.Forms.ComboBox cmdCmpMode;
        private System.Windows.Forms.TabPage tabSetBasic;
        private System.Windows.Forms.GroupBox groupBoxBasic;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.NumericUpDown cmdZeroTracking;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.NumericUpDown cmdZeroTime;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.ComboBox cmdPOZ;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox cmdZeroRange;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCutoff;
        private System.Windows.Forms.NumericUpDown cmbHoldtime;
        private System.Windows.Forms.ComboBox cmbHoldmode;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TabPage tabSetRS;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.GroupBox groupBoxRS;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cmdTerminator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmdStopbits;
        private System.Windows.Forms.ComboBox cmdBaudrate;
        private System.Windows.Forms.ComboBox cmdParity;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmdDatabits;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabPage tabSetPC;
        private System.Windows.Forms.GroupBox groupBoxPC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTerminator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbDatabits;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.ComboBox cmbStopbits;
        private System.Windows.Forms.ComboBox cmbBaudrate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button btnLoad1;
        private System.Windows.Forms.GroupBox groupBoxBasic2;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblResultCalF;
        private System.Windows.Forms.Label lblResult0;
        private System.Windows.Forms.GroupBox groupBoxInit2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timerInit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label15;
    }
}

