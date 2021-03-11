using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace AlarmClockApp
{
    public partial class FrmAlarm : Form
    {
        private DateTime setDay;
        private DateTime setTime;
        private bool setAlarm;
        WindowsMediaPlayer myPlayer;

        public FrmAlarm()
        {
            InitializeComponent();
        }

        private void FrmAlarm_Load(object sender, EventArgs e)
        {
            myPlayer = new WindowsMediaPlayer();
            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.ForeColor = Color.Gray;
            dtpTimePicker.Format = DateTimePickerFormat.Custom;
            dtpTimePicker.CustomFormat = "tt hh:mm";

            myTimer.Interval = 1000;
            myTimer.Tick += MyTimer_Tick;
            myTimer.Start();

            TabClock.SelectedTab = TabDigitalClock;
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            DateTime cTime = DateTime.Now;
            lblDate.Text = cTime.ToShortDateString();
            lblTime.Text = cTime.ToLongTimeString();

            if (setAlarm)
            {
                if (setDay == DateTime.Today &&
                    cTime.Hour == setTime.Hour && cTime.Minute == setTime.Minute)
                {
                    setAlarm = false;
                    myPlayer.URL = @"Music\alarm.mp3";
                    myPlayer.controls.play();
                    MessageBox.Show("Alarm!", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnClearAlarm_Click(sender, e);
                }
            }
        }
        private void BtnSetAlarm_Click(object sender, EventArgs e)
        {
            setDay = DateTime.Parse(dtpDatePicker.Text);
            setTime = DateTime.Parse(dtpTimePicker.Text);

            setAlarm = true;
            lblAlarmSet.ForeColor = Color.Red;
            lblAlarm.ForeColor = Color.Blue;
            lblAlarmSet.Text = "Alarm : " + setDay.ToShortDateString() + " "
                + setTime.ToLongTimeString();
            TabClock.SelectedTab = TabDigitalClock;
        }

        private void BtnClearAlarm_Click(object sender, EventArgs e)
        {
            setAlarm = false;
            lblAlarmSet.ForeColor = Color.Gray;
            lblAlarm.ForeColor = Color.Gray;
            lblAlarmSet.Text = "Alarm : ";
            TabClock.SelectedTab = TabDigitalClock;
        }
    }
}
