using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShopApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
            MainForm_Resize(sender, e);
        }

        private void mnuDivCode_Click(object sender, EventArgs e)
        {
            FormDivCode form = new FormDivCode();
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }
        private void mnuMember_Click(object sender, EventArgs e)
        {
            FormMember form = new FormMember();
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MetroMessageBox.Show(this, "종료하시겠습니까?", "종료",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else e.Cancel = true; // 종료 안함 
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            menuStrip1.Width = this.Width;
            menuStrip1.Height = this.Height;
        }

        
    }
}
