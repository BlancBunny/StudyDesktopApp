using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTestApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtNormalFormat.Text = "Willa Cather";
            txtLNFNFormat.Text = "Cather, Willa";
        }

        //private void lsbPerson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (txtNormalFormat != null && txtLNFNFormat != null)
        //    {
        //        var temp = lsbPerson.SelectedItem as Person;
        //        txtNormalFormat.Text = $"{temp.FirstName} {temp.LastName}";
        //        txtLNFNFormat.Text = $"{temp.LastName}, {temp.FirstName}";
        //    }
        //}
    }
}
