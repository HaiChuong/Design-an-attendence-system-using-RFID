using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using QLSV.DAO;

namespace QLSV
{
    public partial class frmConnect : Form
    {
        public event EventHandler<EventAttendance> eventAttendance;
 
        public frmConnect()
        {
            InitializeComponent();
            SerialPortManager.Instance.SerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            comboBox2.Items.AddRange(BaudRate);
        }

        private void btnConnectSerial_Click(object sender, EventArgs e)
        {
            if (!SerialPortManager.Instance.SerialPort.IsOpen)
            {
                SerialPortManager.Instance.OpenPort(comboBox1.Text, Convert.ToInt32(comboBox2.Text), Parity.None, 8, StopBits.One);
                SerialPortManager.Instance.SerialPort.Write("00-01-00-00-14f");
            }
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string Data = "";
            Data = SerialPortManager.Instance.SerialPort.ReadLine();
            txbRecieve.Text += Data;
            string[] chuoiConArray = Process.TachChuoiMe(Data);
            string lenght_str = (Data.Length - 2).ToString();


            if (chuoiConArray[0] == "11" && chuoiConArray[1] == "01" && chuoiConArray[4] == lenght_str) 
            {
                eventAttendance?.Invoke(this, new EventAttendance(chuoiConArray[2], chuoiConArray[3]));
            }
            if (chuoiConArray[0] == "11" && chuoiConArray[1] == "02" && chuoiConArray[4] == lenght_str)
            {

                fAdmin form2 = Application.OpenForms["fAdmin"] as fAdmin;
                if (form2 != null)
                {
                    form2.setTextIdCard(chuoiConArray[3]); 
                }
                
            }

        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames();
            comboBox2.SelectedIndex = 3;
        }

        private void btnDisconnectSerial_Click(object sender, EventArgs e)
        {
            SerialPortManager.Instance.ClosePort();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txbSend.Text;
            SerialPortManager.Instance.SerialPort.Write(str);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //     comboBox1.DataSource = SerialPort.GetPortNames();
            if (comboBox1.Items.Count == 0)
                comboBox1.Text = "";
            if (!SerialPortManager.Instance.SerialPort.IsOpen)
            {

                label5.Text = ("Chưa kết nối");
                label5.ForeColor = Color.Red;
            }
            else if (SerialPortManager.Instance.SerialPort.IsOpen)
            {

                label5.Text = ("Đã kết nối");
                label5.ForeColor = Color.Green;

            }
        }

        private void frmConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                
                e.Cancel = true;
                
                this.Hide();
            }
        }
    }
    public class EventAttendance : EventArgs
    {
        public string statusStr { get; set; }
        public string idCard { get; set; }

        public EventAttendance (string str1, string str2)
        {
            statusStr = str1;
            idCard = str2;
        }
    }

}
