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

namespace BmiCalcApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnBmiCalc_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtHeight.Text) || string.IsNullOrEmpty(txtWeight.Text)) {
                lblResult.Content = "키와 체중을 입력하세요.";
                return;
            }
            double height = double.Parse(txtHeight.Text) / 100.0;
            double weight = double.Parse(txtWeight.Text);
            double bmi = weight / (height * height);
            lblResult.Content = string.Format($"당신의 BMI는 {bmi} 입니다");
            
        }
    }
}
