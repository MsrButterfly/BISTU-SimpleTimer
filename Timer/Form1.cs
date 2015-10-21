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

namespace Timer {
    public partial class Timer: Form {
        int seconds;
        int initS;

        public Timer() {
            InitializeComponent();
            seconds = initS = 0;
        }

        private void StartButton_Click(object sender, EventArgs e) {
            switch (StartButton.Text) {
                case "START":
                    try {
                        initS = seconds = Int32.Parse(SecondsBox.Text) + Int32.Parse(MinutesBox.Text) * 60;
                        StartButton.Text = "RESET";
                        SecondsBox.ReadOnly = true;
                        timer1.Start();
                    } catch (Exception) {
                        MessageBox.Show("输入的数字格式有误。");
                        return;
                    }
                    break;
                case "RESET":
                    StartButton.Text = "START";
                    MinutesBox.ReadOnly = false;
                    SecondsBox.ReadOnly = false;
                    SetColor(Color.ForestGreen);
                    timer1.Stop();
                    SetTimeBoxNumber(initS);
                    return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            seconds--;
            if (seconds == -1) {
                MinutesBox.ReadOnly = false;
                SecondsBox.ReadOnly = false;
                SetColor(Color.ForestGreen);
                timer1.Stop();
            } else {
                if (seconds == 0) {
                    SetColor(Color.Maroon);
                    WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();
                    wmp.URL = @"End.wav";
                    wmp.controls.play();
                    Console.ReadLine();
                } else if (seconds <= 10) {
                    SetColor(Color.Chocolate);
                } else {
                    SetColor(Color.ForestGreen);
                }
                SetTimeBoxNumber(seconds);
            }
        }

        private void AboutButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Simple timer\n\n- BISTU Student Union - Department of Information Technology\n- March 17th, 2013");
        }

        private void SetTimeBoxNumber(int number) {
            var minutes = (number / 60).ToString();
            var seconds = (number % 60).ToString();
            if (minutes.Length == 1) {
                minutes = "0" + minutes;
            }
            if (seconds.Length == 1) {
                seconds = "0" + seconds;
            }
            MinutesBox.Text = minutes;
            SecondsBox.Text = seconds;
        }

        private void SetColor(Color color) {
            MinutesBox.BackColor = color;
            SecondsBox.BackColor = color;
            BackColor = color;
        }
    }
}
