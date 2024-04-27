using QLSV.DAO;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fAccountProfile : Form
    {
        public event EventHandler<LabelTextChangedEvent> labelTextChanged;
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fAccountProfile(Account acc)
        {
            this.LoginAccount = acc;
            InitializeComponent();
            txbUserName.Text = acc.UserName;
            txtDisplayName.Text = acc.DisplayName;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            if (txbPassWord.Text == loginAccount.PassWord)
            {
                if (txtNewPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu mới để cập nhật thông tin");
                }
                else
                {
                    if (txtNewPassword.Text == txtReNewPassword.Text)
                    {
                        AccountDAO.Instance.UpdateAccount(txbUserName.Text, txtDisplayName.Text, txtNewPassword.Text);
                        labelTextChanged?.Invoke(this, new LabelTextChangedEvent(txtDisplayName.Text));
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Nhập sai mật khẩu mới");
                    }
                }

            }
            else
            {
                MessageBox.Show("Mật khẩu cũ chưa đúng");
            }
        }

        private void fAccountProfile_Load(object sender, EventArgs e)
        {

        }
    }
    public class LabelTextChangedEvent : EventArgs
    { 
        public string NewText { get; set; }
        
        public LabelTextChangedEvent (String str)
        {
            NewText = str;
        }
    }
}
