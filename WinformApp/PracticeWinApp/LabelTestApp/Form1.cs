using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblAutoSize.Text = lblManualSize.Text = string.Empty;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti odit voluptatum odio repellat necessitatibus quia sit neque fugit rem nisi! Excepturi molestiae repellendus eum pariatur architecto atque eligendi vero ab.";
            string sample2 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti odit voluptatum odio repellat necessitatibus quia sit neque fugit rem nisi! Excepturi molestiae repellendus eum pariatur architecto atque eligendi vero ab.";

            lblAutoSize.Text = sample1;
            lblManualSize.Text = sample2;
        }
    }
}
// Lorem ipsum dolor sit amet consectetur adipisicing elit. Corrupti odit voluptatum odio repellat necessitatibus quia sit neque fugit rem nisi! Excepturi molestiae repellendus eum pariatur architecto atque eligendi vero ab.