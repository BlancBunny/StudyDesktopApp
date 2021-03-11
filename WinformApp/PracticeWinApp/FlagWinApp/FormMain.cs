using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagWinApp
{
    public partial class FormMain : Form
    {
        private bool isHello = false;
        public FormMain()
        {
            InitializeComponent();
            isHello = true;
        }

        private void BtnGreeting_Click(object sender, EventArgs e)
        {
            if (isHello == true)
            {
                lblGreeting.Text = "Good Morning";
                isHello = false;
                btnGreeting.Text = "저녁인사";
            }
            else if (isHello == false)
            {
                lblGreeting.Text = "Good Bye";
                isHello = true;
                btnGreeting.Text = "아침인사";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblGreeting.Text = string.Empty;
        }
    }
}
