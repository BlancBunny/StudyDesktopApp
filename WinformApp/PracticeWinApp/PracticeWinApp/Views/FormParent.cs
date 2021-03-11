using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWinApp.Views
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void FormParent_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(800, 600);
            FormChild formchild = new FormChild();
            this.AddOwnedForm(formchild);
            formchild.Show();
        }
    }
}
