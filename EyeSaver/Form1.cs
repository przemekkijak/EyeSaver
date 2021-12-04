using System;
using System.Drawing;
using System.Windows.Forms;

namespace EyeSaver
{
    public partial class mainForm : Form
    {
        public enum PomodoroMode
        {
            Work = 0,
            Break = 1,
            LongBreak = 2
        };

        public static int MaxIntervals = 4;

        private PomodoroMode currentMode; 
        int currentInterval = 0;
        //TODO-PK long interval as settings

        int minutes;
        int seconds;

        public mainForm()
        {
            minutes = settingsForm.defaultWorkTime;
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
                if(minutes > 0 && seconds == 0)
                {
                    minutes--;
                    seconds = 60;
                }

                if (minutes == 0 && seconds == 0)
                {
                    minutes = -1;
                    return;
                }

                seconds--;
                UpdateTimerLabelText();
            }
            else
            {
                timer.Stop();
                DisplayNotification();
                ChangeMode();
            }
        }

        private void UpdateModeLabel()
        {
            switch (currentMode)
            {
                case PomodoroMode.Work:
                    label2.Text = "Work";
                    label2.ForeColor = Color.Red;
                    break;

                case PomodoroMode.Break:
                    label2.Text = "Break";
                    label2.ForeColor = Color.LightGreen;
                    break;

                case PomodoroMode.LongBreak:
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
            settingsForm f2 = new settingsForm(this);
            f2.ShowDialog();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            SetTimeToDefault();
        }

        public void SetTimeToDefault()
        {
            timer.Stop();
            seconds = 0;
            switch (currentMode)
            {
                case PomodoroMode.Work:
                    minutes = settingsForm.defaultWorkTime;
                    break;

                case PomodoroMode.Break:
                    minutes = settingsForm.defaultBreakTime;
                    break;

                case PomodoroMode.LongBreak:
                    minutes = settingsForm.defaultLongBreakTime;
                    break;
            }
            UpdateTimerLabelText();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void DisplayNotification()
        {
            switch(currentMode)
            {
                case PomodoroMode.Work:
                    notifyIcon1.ShowBalloonTip(3000, "Take a break", "Let you eyes rest for few minutes", ToolTipIcon.None);
                    break;

                case PomodoroMode.Break:
                    notifyIcon1.ShowBalloonTip(3000, "Break is over", "Get back to work", ToolTipIcon.None);
                    break;

                case PomodoroMode.LongBreak:
                    notifyIcon1.ShowBalloonTip(3000, "Time for long rest", "You finished planned intervals, take a long break", ToolTipIcon.None);
                    break;

            }
        }

        private void ChangeMode()
        {
            if (currentMode == (int) PomodoroMode.Work)
            {
                if (currentInterval == MaxIntervals)
                {
                    currentInterval = 0;
                    currentMode = PomodoroMode.LongBreak;
                }
                else
                {
                    currentInterval++;
                    currentMode = PomodoroMode.Break;
                }
            }
            else
            {
                currentMode = PomodoroMode.Work;
            }
        }
    }
}