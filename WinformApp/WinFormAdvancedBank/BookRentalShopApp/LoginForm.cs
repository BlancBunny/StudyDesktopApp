using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("로그인");
            if (string.IsNullOrEmpty(txtUserID.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this,"아이디/패스워드를 입력하세요", "오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.connString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    
                    SqlCommand cmd = new SqlCommand();
                    
                    // SQL Injection 해킹 방지
                    SqlParameter param = new SqlParameter();
                    
                    SqlDataReader reader = cmd.ExecuteReader();

                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"Error : {ex.Message}", "오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
                return;
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtPassword.Focus();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnLogin_Click(sender, e);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUserID.Focus();
        }
    }
}
