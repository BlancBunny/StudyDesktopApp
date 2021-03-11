using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string result;

            result = "입사일 : " + txtDate.Text + "\n";
            result += "우편번호 : " + txtZipCode.Text + "\n";
            result += "주소 : " + txtAddress.Text + "\n";
            result += "휴대폰번호 : " + txtMobile.Text + "\n";
            result += "주민등록번호 : " + txtRegisterNumber.Text + "\n";
            result += "이메일 : " + txtEmail.Text + "\n";

            MessageBox.Show(result, "개인정보");
        }
    }
}
