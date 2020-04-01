using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace AD310AD
{
    public partial class Form2 : Form
    {
        Form1 main = new Form1();        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 사용 가능한 포트를 읽어온다.
            string[] nameArray = null;
            nameArray = SerialPort.GetPortNames();
            Array.Sort(nameArray, 1, 1);

            // 콤보박스에 표시
            foreach (string str in nameArray)
            {
                ((ComboBox)comboBox1).Items.Add(str);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            main.serialPort1.PortName = comboBox1.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            main.serialPort1.BaudRate = Convert.ToInt32(comboBox1.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            main.serialPort1.DataBits = Convert.ToInt32(comboBox1.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Even")
            {
                main.serialPort1.Parity = Parity.Even;
            }
            else if (comboBox1.Text == "Odd")
            {
                main.serialPort1.Parity = Parity.Odd;
            }
            else if (comboBox1.Text == "None")
            {
                main.serialPort1.Parity = Parity.None;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "1")
            {
                main.serialPort1.StopBits = StopBits.One;
            }
            else if (comboBox1.Text == "1.5")
            {
                main.serialPort1.StopBits = StopBits.OnePointFive;
            }
            else if (comboBox1.Text == "2")
            {
                main.serialPort1.StopBits = StopBits.Two;
            }
        }

        // F 펑션 읽어오기
        private void tabPage2_Click(object sender, EventArgs e)
        {
            // 이벤트 핸들러 수정
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 텍스트 박스 클리어 필요
            //Thread commandThread = new Thread(new ParameterizedThreadStart(dispMessage));
            //if (main.serialPort1.IsOpen)
            //{
            //    main.serialPort1.WriteLine("?F001\r\n");
            //}
            // textBox1.Clear() 가능?
            //commandThread.Start(

        }

        // F 커맨드 변경
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // CF 펑션 읽어오기
        private void tabPage3_Click(object sender, EventArgs e)
        {
            // 이벤트 핸들러 수정
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        // CF 커맨드 변경
        private void button7_Click(object sender, EventArgs e)
        {

        }

        //private void dispMessage(string str)
        //{
        //    if (this.textBox1.InvokeRequired)
        //    {
        //        msgCallback d = new msgCallback(dispMessage);
        //        this.Invoke(d, new object[] { str });
        //    }
        //    else
        //    {
        //        //this.textBox1.Clear();
        //        this.textBox1.AppendText(str);
        //    }
        //}

    }
}