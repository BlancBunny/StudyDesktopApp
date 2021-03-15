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
using System.Windows.Threading;

namespace AnalogClockApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point Center { get; set; }
        private double Radius { get; set; }
        private int HourHand { get; set; }
        private int MinHand { get; set; }
        private int SecHand { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            SetClock();
            SetTimer();
        }
        private void SetClock()
        {
            Center = new Point(canvas1.Width / 2, canvas1.Height / 2);
            Radius = canvas1.Width / 2;
            HourHand = (int)(Radius * 0.45);
            MinHand = (int)(Radius * 0.55);
            SecHand = (int)(Radius * 0.65);
        }
        private void SetTimer()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;
            canvas1.Children.Clear();
            DrawClockFace(); // 시계판
            double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
            double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
            double radSec = (c.Second + c.Millisecond/1000.0) * 6 * Math.PI / 180;
            DrawHands(radHr, radMin, radSec); // 시계바늘

        }

        private void DrawClockFace()
        {
            aClock.Stroke = Brushes.LightSteelBlue;
            aClock.StrokeThickness = 30;
            canvas1.Children.Add(aClock);
        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            DrawLine(HourHand * Math.Sin(radHr), -HourHand * Math.Cos(radHr)
                , 0, 0, Brushes.RoyalBlue, 8, new Thickness(Center.X, Center.Y, 0, 0)); // 시침
            DrawLine(MinHand * Math.Sin(radMin), -MinHand * Math.Cos(radMin)
                , 0, 0, Brushes.SkyBlue, 6, new Thickness(Center.X, Center.Y, 0, 0)); // 분침
            DrawLine(SecHand * Math.Sin(radSec), -SecHand * Math.Cos(radSec)
                , 0, 0, Brushes.OrangeRed, 3, new Thickness(Center.X, Center.Y, 0, 0)); // 초침

            Ellipse core = new Ellipse();
            core.Margin = new Thickness(canvas1.Width / 2 - 10,
                canvas1.Height / 2 - 10, 0, 0);
            core.Stroke = Brushes.SteelBlue;
            core.Fill = Brushes.LightSteelBlue;
            core.Width = 20;
            core.Height = 20;
            canvas1.Children.Add(core);
        }

        private void DrawLine(double x1, double y1, int x2, int y2, SolidColorBrush color, int thick, Thickness margin)
        {
            Line line = new Line();
            line.X1 = x1; line.Y1 = y1; line.X2 = x2; line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thick;
            line.Margin = margin;
            line.StrokeStartLineCap = PenLineCap.Round;
            canvas1.Children.Add(line);
        }

        
        // Initialized : 프로그램 실행 전 / Loaded : 프로그램 실행 후
    }
}
