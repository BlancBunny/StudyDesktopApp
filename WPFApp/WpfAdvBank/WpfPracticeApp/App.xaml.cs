﻿using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfPracticeApp
{
    /// <summary>
    /// App.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var navWin = new MetroNavigationWindow
            {
                Title = "Adventure Works Customer Service"
            };
            navWin.Show();
            navWin.Navigate(new MainMenu());
        }
    }
}
