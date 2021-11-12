using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeSaver
{
    public partial class Form1 : Form
    {
        public enum PomodoroMode
        {
            Work = 0,
            Break = 1,
            LongBreak = 2
        };


        public enum ModeMinutesSetting
        {
            Work = 30,
            Break = 3,
            LongBreak = 15
        }

        int currentMode = 0;
        int currentInterval = 0;

        int minutes = 2;
        int seconds = 0;

        public Form1()
        {
            InitializeComponent();

            UpdateTimerLabelText();
            UpdateModeLabel();

        }


        private void startButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(minutes >= 0)
            {
                if (seconds == 0)
                {
                    minutes--;
                    seconds = 60;
                }

                if (seconds > 0)
                    seconds--;

                UpdateTimerLabelText();
            }
            else
            {
                timer.Stop();
                if(currentMode == (int) PomodoroMode.Work)
                {
                    currentMode = (int) PomodoroMode.Break;
                    UpdateModeLabel();
                }
            }
        }

        private void UpdateModeLabel()
        {
            switch (currentMode)
            {
                case (int)PomodoroMode.Work:
                    label2.Text = "Work";
                    label2.ForeColor = Color.Red;
                    break;

                case (int)PomodoroMode.Break:
                    label2.Text = "Break";
                    label2.ForeColor = Color.LightGreen;
                    break;

                case (int)PomodoroMode.LongBreak:
                    label2.Text = "Long break";
                    label2.ForeColor = Color.DarkGreen;
                    break;
            }
        }

        private void UpdateTimerLabelText()
        {
            var minutesText = minutes < 10 ? $"0{minutes}" : $"{minutes}";
            var secondsText = seconds < 10 ? $"0{seconds}" : $"{seconds}";
            timerLabel.Text = $"{minutesText} : {secondsText}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            seconds = 0;
            switch(currentMode)
            {
                case (int) PomodoroMode.Work:
                    minutes = (int) ModeMinutesSetting.Work;
                    break;

                case (int)PomodoroMode.Break:
                    minutes = (int)ModeMinutesSetting.Break;
                    break;

                case (int)PomodoroMode.LongBreak:
                    minutes = (int)ModeMinutesSetting.LongBreak;
                    break;
            }
            UpdateTimerLabelText();
        }
    }
}