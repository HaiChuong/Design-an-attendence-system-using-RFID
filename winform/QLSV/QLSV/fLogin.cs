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
    public partial class fLogin : Form
    {
        public bool AccoutDAO { get; private set; }

        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string s_user = txbUserName.Text;
            string s_pass = txbPassWord.Text;
            if (Login(s_user, s_pass))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(s_user);
                fTableManager fManager = new fTableManager(loginAccount);
                this.Hide();
                
                fManager.ShowDialog();
                txbPassWord.Text = "";
                this.Show();

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }

        }
        bool Login(string user_name, string password)
        {

 
            return AccountDAO.Instance.Login(user_name, password);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
