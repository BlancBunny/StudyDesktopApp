using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string checkStates = "";
            List<CheckBox> cBox = new List<CheckBox>
            { chkApple, chkPear, chkStrawberry, chkBanana, chkOrange, chkGrape };

            foreach(var item in cBox)
            {
                checkStates += string.Format($"{item.Text} : {item.Checked}\n");
            }
            MessageBox.Show(checkStates, "checkStates");
            string summary = string.Format("좋아하는 과일은 : ");
            foreach(var item in cBox)
            {
                if (item.Checked) summary += item.Text + " ";
            }
            MessageBox.Show(summary, "summary");
        }
    }
}
