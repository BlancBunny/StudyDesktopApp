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

namespace AddressInfoApp
{
    public partial class FrmMain : Form
    {
        string connString = $"Data Source=127.0.0.1;Initial Catalog=PMS;Persist Security Info=True;User ID=sa;Password=mssql_p@ssw0rd!";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtMobile.Text) || string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("값을 입력하세요.");
                txtName.Focus();
                return;
            }
            
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = $"INSERT INTO dbo.addressTbl " +
                    $" ( Name, " +
                    $" Mobile, " +
                    $" Address, " +
                    $" RegID, " +
                    $" RegDate) " +
                    $" VALUES " +
                    $" ( '{txtName.Text}', " +
                    $" '{txtMobile.Text.Replace("-", "")}', " +
                    $" '{txtAddress.Text}', " +
                    $" 'admin', " +
                    $" GETDATE() );";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("입력 성공");
                else MessageBox.Show("입력 실패");

            }

            RefreshData();
            ClearInput();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하세요.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = $"UPDATE addressTbl " +
                               $"SET " +
                               $"Name = '{txtName.Text}', " +
                               $"Mobile = '{txtMobile.Text.Replace("-","")}', " +
                               $"Address = '{txtAddress.Text}', " +
                               $"ModId = 'admin', " +
                               $"ModDate = GETDATE() " +
                               $"WHERE Idx = {result}; ";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("수정 성공!");
                }
                else MessageBox.Show("수정 실패!");
            }

            RefreshData();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("데이터를 선택하세요.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = $"DELETE FROM AddressTbl WHERE idx = {result}";
                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("삭제 성공!");
                }
                else MessageBox.Show("삭제 실패!");
            }

            RefreshData();
            ClearInput();
        }
        // 삭제 버튼에 질문 추가 
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtMobile.Focus(); // Enter

        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtAddress.Focus();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ClearInput();
            RefreshData();
            txtName.Focus();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed) conn.Open();
                string query = "SELECT idx " +
                               ", Name " +
                               ", Mobile " +
                               ", Address " +
                               "FROM AddressTbl; ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];
            }
        }

        private void ClearInput() {
            txtIdx.Text = "";
            txtName.Text = "";
            txtMobile.Text = "";
            txtAddress.Text = "";
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectData = dataGridView.Rows[e.RowIndex].Cells;
            txtIdx.Text = selectData[0].Value.ToString();
            txtName.Text = selectData[1].Value.ToString();
            txtMobile.Text = selectData[2].Value.ToString();
            txtAddress.Text = selectData[3].Value.ToString();
        }
    }
}
