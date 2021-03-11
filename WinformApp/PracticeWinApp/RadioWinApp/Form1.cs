using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbKorea.Checked = true;
            rdbMale.Checked = true;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            if (rdbKorea.Checked)
                result = "국적 : 대한민국 ";
            else if (rdbChina.Checked)
                result = "국적 : 중국 ";
            else if (rdbJapan.Checked)
                result = "국적 : 일본 ";
            else if (rdbOthers.Checked)
                result = "국적 : 그 외 국가 ";

            if (rdbMale.Checked)
                result += "성별 : 남성";
            else if (rdbFemale.Checked)
                result += "성별 : 여성";

            MessageBox.Show(result, "결과");
        }
    }
}
