using QLSV.DAO;
using QLSV.DTO;
using QuanLy.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace QLSV
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;
        public event EventHandler<EventAttendance1> eventScandRFID;
        private string dayOfWeek;
        
        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangAccount(loginAccount.Type); }
        }


        public fTableManager(Account acc)
        {

            InitializeComponent();
            this.LoginAccount = acc;
            tsmAccountInfor.Text = "Thông tin tài khoản ( " + loginAccount.DisplayName + " )";  
            load_Attendance_table();
            Control.CheckForIllegalCrossThreadCalls = false;
            if (acc.Type == 0)
            {
                adminToolStripMenuItem.Enabled = false;
            }
            else
            {
                adminToolStripMenuItem.Enabled = true;
            }
        }




        #region Method
        void ChangAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            
        }




        #endregion


        private void fTableManager_Load(object sender, EventArgs e)
        {
            loadSche();
      
        }

        



        void load_Attendance_table()
        {
            lsvAttendancing.Items.Clear();
            List<QLSV.DTO.Attendance> listAttendanceInfo = AttendanceDAO.Instance.load_AttendanceTable();
            foreach (QLSV.DTO.Attendance item in listAttendanceInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.ID.ToString());
                lsvItem.SubItems.Add(item.Card_id.ToString());
                lsvItem.SubItems.Add(item.Student_name.ToString());
                lsvItem.SubItems.Add(item.Status_att.ToString());
                lsvItem.SubItems.Add(item.DateCheckIn.ToString());
                lsvItem.SubItems.Add(item.DateCheckOut.ToString());
                lsvAttendancing.Items.Add(lsvItem);
            }
        }
        public void loadSche()
        {
            CultureInfo viCulture = new CultureInfo("vi-VN");
            DateTime currentTime = DateTime.Now;
            string thu = currentTime.ToString("dddd");
            switch (thu)
            {
                case "Monday":
                    thu = "Thứ Hai";
                    break;
                case "Tuesday":
                    thu = "Thứ Ba";
                    break;
                case "Wednesday":
                    thu = "Thứ Tư";
                    break;
                case "Thursday":
                    thu = "Thứ Năm";
                    break;
                case "Friday":
                    thu = "Thứ Sáu";
                    break;
                case "Saturday":
                    thu = "Thứ Bảy";
                    break;
                case "Sunday":
                    thu = "Chủ nhật";
                    break;
            }
            dayOfWeek = thu;
            ThoiKhoaBieu tkb = ThoiKhoaBieuDAO.Instance.GetThoiKhoaBieuByThu(thu);
            string inTime = tkb.ThoiGianVaoHoc.ToString();

            
            string formattedTime = $"Hôm nay là {currentTime.ToString("dddd", viCulture)}, ngày {currentTime.Day}, tháng {currentTime.Month}, năm {currentTime.Year}, thời gian vào học {tkb.ThoiGianVaoHoc}, thời gian tan học {tkb.ThoiGianTanHoc} ";
            lbNow.Text = formattedTime;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin(LoginAccount);
            
            f.ShowDialog();
            
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account loginAccount1 = AccountDAO.Instance.GetAccountByUserName(loginAccount.UserName);

            fAccountProfile fAccPro = new fAccountProfile(loginAccount1);
           
            fAccPro.labelTextChanged += FAccPro_TextChanged;
            fAccPro.ShowDialog();
            this.Show();
        }

        private void FAccPro_TextChanged(object sender, LabelTextChangedEvent e)
        {
            tsmAccountInfor.Text = "Thông tin tài khoản ( " + e.NewText + " )";
        }


      
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string convertNameStudent(string name)
        {
            string normalizedString = name.Normalize(NormalizationForm.FormD);
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char c in normalizedString)
            {
                UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                    stringBuilder.Append(c);
            }
            normalizedString = stringBuilder.ToString().Normalize(NormalizationForm.FormC);  
            
            string[] words = normalizedString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            
            string lastName = words.Length >= 2 ? words[words.Length - 2] : string.Empty;
            string firstName = words.Length >= 1 ? words[words.Length - 1] : string.Empty;
            string full_name = lastName +" "+ firstName;
            return full_name;

        }

        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void kếtNốiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnect f = new frmConnect();
            f.eventAttendance += F_eventAttendance;
        
            f.ShowDialog();
        }

        private void F_eventScanRFID(object sender, EventAttendance e)
        {
            eventScandRFID?.Invoke(this, new EventAttendance1(e.statusStr, e.idCard));
        }

        private void F_eventAttendance(object sender, EventAttendance e)
        {
            string str;
            if (StudentDAO.Instance.Count_student(e.idCard) > 0)
            {
                AttendanceDAO.Instance.Update_CheckInOut(e.idCard,dayOfWeek);
                str = StudentDAO.Instance.getStudentNamebyCardId(e.idCard);
                str = convertNameStudent(str);
                str = "00-11-00-" + str + "-";
                str = str + (str.Length + 2).ToString() + "f";
                int count = str.Length;
                SerialPortManager.Instance.SerialPort.Write(str); 
                load_Attendance_table();
            }
            else
            {

               
                str = "Ma the chua DK  ";
                str = "00-11-00-" + str + "-";
                str = str + (str.Length + 2).ToString() + "f";
                int count = str.Length;
                SerialPortManager.Instance.SerialPort.Write(str); 
            }
        }
    }

    public class EventAttendance1 : EventArgs
    {
        public string statusStr1 { get; set; }
        public string idCard1 { get; set; }

        public EventAttendance1(string str1, string str2)
        {
            statusStr1 = str1;
            idCard1 = str2;
        }
    }
}
