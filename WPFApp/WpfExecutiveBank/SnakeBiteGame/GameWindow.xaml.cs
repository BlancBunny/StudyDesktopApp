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
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;

namespace SnakeBiteGame
{
    /// <summary>
    /// GameWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class GameWindow : Window
    {
        Random r = new Random();
        Ellipse[] snakes = new Ellipse[30];
        Ellipse egg = new Ellipse();
        private int size = 12;          // Egg와 Body 크기
        private int visibleCount = 5;   // 처음에 보이는 뱀 길이 
        private string move = "";       // 뱀의 이동 방향
        private int eaten = 0;          // 먹은 알의 개수
        DispatcherTimer timer = new DispatcherTimer();
        Stopwatch stopWatch = new Stopwatch();
        private bool startFlag = false;
        

        public GameWindow()
        {
            InitializeComponent();
            lblGameOver.Visibility = Visibility.Collapsed;
        }
        private void Window_Initialized(object sender, EventArgs e)
        {
            InitSnake();
            InitEgg();
            
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        private void InitSnake()
        {
            for (int i = 0; i < 30; i++)
            {
                snakes[i] = new Ellipse();
                snakes[i].Width = size;
                snakes[i].Height = size;
                if (i == 0) snakes[i].Fill = Brushes.Chocolate; // 머리 
                else if (i % 5 == 0) snakes[i].Fill = Brushes.YellowGreen;
                else snakes[i].Fill = Brushes.Gold;
                snakes[i].Stroke = Brushes.Black;
                cvsGame.Children.Add(snakes[i]);
            }

            for (int i = visibleCount; i < 30; i++)
            {
                snakes[i].Visibility = Visibility.Hidden;
            }

            int x = r.Next(1, 500 / size) * size;
            int y = r.Next(1, 400 / size) * size;
            CreateSnake(x, y);
        }

        private void CreateSnake(int x, int y)
        {
            for (int i = 0; i < visibleCount; i++)
            {
                snakes[i].Tag = new Point(x, y + i * size);
                Canvas.SetLeft(snakes[i], x);
                Canvas.SetTop(snakes[i], y + i * size);
            }
        }

        private void InitEgg()
        {
            egg = new Ellipse();
            egg.Tag = new Point( 
                r.Next(1, 500 / size) * size,     
                r.Next(1, 400 / size) * size);
            egg.Width = size;
            egg.Height = size;
            egg.Stroke = Brushes.Black;
            egg.Fill = Brushes.Red;

            Point p = (Point)egg.Tag;
            cvsGame.Children.Add(egg);
            Canvas.SetLeft(egg, p.X);
            Canvas.SetTop(egg, p.Y);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Point p0 = (Point)snakes[0].Tag;
            if (move != "")
            {
                startFlag = true;

                // 벽에 닿았는지 검사 
                if (p0.X > 500 || p0.X < 0 || p0.Y > 400 || p0.Y < 0) GameOver();

                // 꼬리 1 ~ i까지 생성
                for (int i = visibleCount; i >= 1; i--) 
                {
                    Point p = (Point)snakes[i - 1].Tag;
                    snakes[i].Tag = new Point(p.X, p.Y); 
                }
                
                // 꼬리 0 생성
                Point pnt = (Point)snakes[0].Tag;
                if (move == "Right") snakes[0].Tag = new Point(pnt.X + size, pnt.Y);
                else if (move == "Left") snakes[0].Tag = new Point(pnt.X - size, pnt.Y);
                else if (move == "Up") snakes[0].Tag = new Point(pnt.X, pnt.Y - size);
                else if (move == "Down") snakes[0].Tag = new Point(pnt.X, pnt.Y + size);

                p0 = (Point)snakes[0].Tag;
                
                // 꼬리 0과 꼬리 1~i 겹침 검색 
                for (int i = visibleCount; i >= 1; i--)
                {
                    Point pi = (Point)snakes[i].Tag;
                    if (p0.X == pi.X && p0.Y == pi.Y) GameOver();
                }

                
                EatEgg();
                
            }

            if (startFlag == true)
            {
                TimeSpan ts = stopWatch.Elapsed;
                txtTime.Text = string.Format($"{ts.Minutes}:{ts.Seconds}:{ts.Milliseconds/10}");
                DrawSnakes();
            }

        }

        private void GameOver()
        {
            // 게임 오버 조건 체크 GameOver(); 
            // 1. 뱀 머리가 벽에 닿았을 때 
            // 2. 뱀 머리가 뱀 몸통 부분에 닿았을 때 
            timer.Stop();
            stopWatch.Stop();
            DrawSnakes();
            move = "";
            lblGameOver.Visibility = Visibility.Visible;
        }

        private void EatEgg()
        {
            Point pS = (Point)snakes[0].Tag;
            Point pE = (Point)egg.Tag;

            if (pS.X == pE.X && pS.Y == pE.Y) // 뱀의 머리 위치와 알의 위치가 같다면
            {
                egg.Visibility = Visibility.Hidden;
                visibleCount++; // 꼬리 개수 1 증가
                snakes[visibleCount - 1].Visibility = Visibility.Visible;
                txtScore.Text = "Eggs : " + (++eaten).ToString();

                if (visibleCount == 30) // 승리 조건 : 뱀의 길이 30 
                {
                    timer.Stop();
                    stopWatch.Stop();
                    DrawSnakes();
                    TimeSpan ts = stopWatch.Elapsed;
                    string tElpased = 
                        string.Format($"Time : {ts.Minutes}:{ts.Seconds}:{ts.Milliseconds / 10}");
                    MessageBox.Show("우승!!" + tElpased + " sec");
                    this.Close();
                }

                Point p = new Point(r.Next(1, 500 / size) * size,
                    r.Next(1, 400 / size) * size);
                egg.Tag = p;
                egg.Visibility = Visibility.Visible;
                Canvas.SetLeft(egg, p.X);
                Canvas.SetTop(egg, p.Y);
            }
        }

        private void DrawSnakes()
        {
            for (int i = 0; i < visibleCount; i++)
            {
                Point p = (Point)snakes[i].Tag;
                Canvas.SetLeft(snakes[i], p.X);
                Canvas.SetTop(snakes[i], p.Y);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (move == "") // 맨 처음 무언가 눌러지면 sw 시작
                stopWatch.Start();

            if (e.Key == Key.Right) move = "Right";
            else if (e.Key == Key.Left) move = "Left";
            else if (e.Key == Key.Up) move = "Up";
            else if (e.Key == Key.Down) move = "Down";
            else if (e.Key == Key.Escape) move = ""; 
        }
        
        
    }
}
