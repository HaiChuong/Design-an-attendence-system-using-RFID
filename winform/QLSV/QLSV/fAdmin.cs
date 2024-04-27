using OfficeOpenXml;
using QLSV.DAO;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fAdmin : Form
    {
        BindingSource listAccount = new BindingSource();
        BindingSource listSchedule = new BindingSource();
        private Account loginAccount;
    

        public Account LoginAccount 
        {
            get { return loginAccount; }
            set { loginAccount = value;  }
        }


        public fAdmin(Account acc) 
        {
            this.LoginAccount = acc;
            InitializeComponent();
          
            LoadAccountList();
            LoadScheduleList();
            AddAccountBinding();
            
            dtpkFromDate.Format = DateTimePickerFormat.Custom;
            dtpkFromDate.CustomFormat = "yyyy/MM/dd";
            dtpkToDate.Format = DateTimePickerFormat.Custom;
            dtpkToDate.CustomFormat = "yyyy/MM/dd";
           loadDateTimePickerBill();
            load_Student_list();
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (SerialPortManager.Instance.SerialPort.IsOpen)
            {
                SerialPortManager.Instance.SerialPort.Write("00-02-00-00-14f");
            }    
          
            
            

        }
        #region method
        void LoadAccountList()
        {
            DataTable data = new DataTable();
            data = AccountDAO.Instance.GetListAccount();
            listAccount.DataSource = data;
            dgvAccount.DataSource = listAccount;


        }
        void LoadFoodList()
        {
            string query = "select *from food";
            
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query, new object[] { "client" });
            dgvStudent.DataSource = data;
        }

        void loadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

        }

        void load_Student_list()
        {
            DataTable data = StudentDAO.Instance.GetListStudent();
            dgvStudent.DataSource = data;
        }
        void LoadScheduleList()
        {
            DataTable data = new DataTable();
            data = ThoiKhoaBieuDAO.Instance.GetListSchedule();
            dgvSchedule.DataSource = data;
      


        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never);
            txbDisplayName.DataBindings.Add("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never);
            txbTypeAccount.DataBindings.Add("Text", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never);
        }
      
        #endregion


        #region Event
        private void tc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tpFoodCatelogy_Click(object sender, EventArgs e)
        {

        }

        private void dgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
           data = AttendanceDAO.Instance.summary_Attendance(dtpkFromDate.Text, dtpkToDate.Text);
            dtgvBill.DataSource = data;
        }

        private void dtpkToDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tpBill_Click(object sender, EventArgs e)
        {

        }
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (StudentDAO.Instance.Count_student(txbIdCard.Text) > 0)
            {
                MessageBox.Show("Mã ID Card đã tồn tại, vui lòng sử dụng thẻ khác");
            }
            else
            {
                Student std = new Student(txbIdCard.Text, 0, txbName.Text, txbMail.Text, txbPhoneNumber.Text);
                StudentDAO.Instance.Insert_Student(std);
                load_Student_list();
            }
        }
        public void setTextIdCard(string text)
        {
            txbIdCard.Text = text;
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            if (StudentDAO.Instance.Count_student(txbIdCard.Text) == 0)
            {
                MessageBox.Show("Mã ID Card không tồn tại, vui lòng quẹt lại thẻ");
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc xóa thông tin sinh viên " + txbName.Text, "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    StudentDAO.Instance.Delete_Student(txbIdCard.Text);
                    load_Student_list();
                }

            }
        }

        private void attendanceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string card_id = txbIdCard.Text;
            string student_name = txbName.Text;
            string student_phone = txbPhoneNumber.Text;
            string student_mail = txbMail.Text;
            if (StudentDAO.Instance.updateStudent(card_id, Convert.ToInt32(txbID.Text), student_name, student_phone, student_mail))
            {
                MessageBox.Show("Cập nhật sinh viên thành công !");
                load_Student_list();
            }
            
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txbIdCard.Text = row.Cells[1].Value.ToString();
                txbID.Text = row.Cells[0].Value.ToString();
                txbName.Text = row.Cells[2].Value.ToString();
                txbPhoneNumber.Text = row.Cells[3].Value.ToString();
                txbMail.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnSeachFood_Click(object sender, EventArgs e)
        {
            dgvStudent.DataSource = StudentDAO.Instance.SearchStudentByName(txbNameSearch.Text);
        }

        private void btnShowFood_Click(object sender, EventArgs e)
        {
            load_Student_list();
        }

        private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = Convert.ToInt32(txbTypeAccount.Text);
            if (AccountDAO.Instance.insertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công !");
                LoadAccountList();
            }
        }

        private void btnDeleteAccout_Click(object sender, EventArgs e)
        {
            if (LoginAccount.UserName == txbUserName.Text)
            {
                MessageBox.Show("Không được xóa tài khoản đang đăng nhập");
            }
            else
            {
                if (AccountDAO.Instance.deleteAccount(txbUserName.Text))  
                {
                    MessageBox.Show("Xóa tài khoản thành công ");
                    LoadAccountList();
                }
            }
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = Convert.ToInt32(txbTypeAccount.Text);

            if (AccountDAO.Instance.editAccount(userName, displayName, type))
            {
                MessageBox.Show("Sửa thông tin tài khoản thành công !");
                LoadAccountList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                ExcelFuntion ex1 = new ExcelFuntion();
                ex1.ToExcel(dtgvBill, saveFileDialog1.FileName, "Điểm danh");
            }
        }

        private void btnExportStudent_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                ExcelFuntion ex1 = new ExcelFuntion();
                ex1.ToExcel(dgvStudent, saveFileDialog1.FileName, "DS sinh viên");
            }
        }

        private void btnImportStudent_Click(object sender, EventArgs e)
        {        
            
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath;
                    selectedFilePath = openFileDialog.FileName;
                    ExcelFuntion ex1 = new ExcelFuntion();
                    DataTable data = ex1.ReadExcelToDataTable(selectedFilePath);
                    for (int i = data.Rows.Count - 1; i >= 0; i--)
                    {

                        string idValue = data.Rows[i][0].ToString();
                        string name = data.Rows[i][2].ToString();

                        if (StudentDAO.Instance.Count_student(idValue) > 0)
                        {
                            string tb = "Mã thẻ RFID " + idValue + " bị trùng, bạn có muốn tiếp tục thêm vào ? ";
                            DialogResult dg = MessageBox.Show(tb, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (dg == DialogResult.OK)
                            {
                                Student std = new Student(idValue, 0, data.Rows[i][1].ToString(), data.Rows[i][3].ToString(), data.Rows[i][2].ToString());
                                StudentDAO.Instance.Insert_Student(std);
                            }

                        }
                        else
                        {
                            Student std = new Student(idValue, 0, data.Rows[i][1].ToString(), data.Rows[i][3].ToString(), data.Rows[i][2].ToString());
                            StudentDAO.Instance.Insert_Student(std);
                        }

                    }
                    MessageBox.Show("Tải thông tin sinh viên thành công !");
                }
            }
                     
            
            load_Student_list();
            
        }




        #endregion


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            


            string Data = "";
            Data = SerialPortManager.Instance.SerialPort.ReadLine();
      
         
            string[] chuoiConArray = Process.TachChuoiMe(Data);
            string lenght_str = (Data.Length - 2).ToString();
            

            if (chuoiConArray[0] == "11" && chuoiConArray[1] == "02" && chuoiConArray[4] == lenght_str) 
            {
                txbIdCard.Text = chuoiConArray[3];
            }
            else 
            {
                
            }
        }
        
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialPortManager.Instance.SerialPort.IsOpen)
            {
                SerialPortManager.Instance.SerialPort.Write("00-01-00-00-14f");
            }
                
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (AccountDAO.Instance.resetPassword(txbUserName.Text))
            {
                MessageBox.Show("Reset mật khẩu tài khoản thành công ");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadScheduleList();
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                DataGridViewRow row = dgvSchedule.Rows[e.RowIndex];
               
                
                txbThu.Text = row.Cells[0].Value.ToString();

             
                string[] tach_chuoi_1 = row.Cells[1].Value.ToString().Split(':');
                nmrInHour.Value = int.Parse( tach_chuoi_1[0]);
                nmrInMin.Value = int.Parse(tach_chuoi_1[1]);
            
                string[] tach_chuoi2 = row.Cells[2].Value.ToString().Split(':');
                nmrOutHour.Value = int.Parse(tach_chuoi2[0]);
                nmrOutMin.Value = int.Parse(tach_chuoi2[1]);
            }
        }

        private void btnEditSche_Click(object sender, EventArgs e)
        {
            string inTime = nmrInHour.Value.ToString() + ":" + nmrInMin.Value.ToString() + ":00";
            string outTime = nmrOutHour.Value.ToString() + ":" + nmrOutMin.Value.ToString() + ":00";
            

            if (ThoiKhoaBieuDAO.Instance.editSche(txbThu.Text, inTime, outTime))
            {
                MessageBox.Show("Sửa thời khóa biểu thành công !");
                LoadScheduleList();
                fTableManager form2 = Application.OpenForms["fTableManager"] as fTableManager; 
                if (form2 != null)
                {
                    form2.loadSche(); 
                }
            }
            else
            {
                MessageBox.Show("Sửa thời khóa biểu thất bại, vui lòng kiểm tra lại !");
            }    
        }
    }
}
