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
    public partial class settingsForm : Form
    {
        public static int defaultWorkTime = 30;
        public static int defaultBreakTime = 5;
        public static int defaultLongBreakTime = 15;
        mainForm parentForm;
        public settingsForm(mainForm parent)
        {
            InitializeComponent();

            workTrackBar.Value = defaultWorkTime;
            breakTrackBar.Value = defaultBreakTime;
            LongBreakTrackBar.Value = defaultLongBreakTime; 

            workLabel.Text = workTrackBar.Value.ToString();
            breakLabel.Text = breakTrackBar.Value.ToString();    
            longBreakLabel.Text = LongBreakTrackBar.Value.ToString();
            parentForm = parent;

        }

        private void workTrackBar_Scroll(object sender, EventArgs e)
        {
            workLabel.Text = workTrackBar.Value.ToString();
        }

        private void breakTrackBar_Scroll(object sender, EventArgs e)
        {
            breakLabel.Text = breakTrackBar.Value.ToString();
        }

        private void LongBreakTrackBar_Scroll(object sender, EventArgs e)
        {
            longBreakLabel.Text = LongBreakTrackBar.Value.ToString();
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            defaultWorkTime = workTrackBar.Value;
            defaultBreakTime = breakTrackBar.Value;
            defaultLongBreakTime = LongBreakTrackBar.Value;
            parentForm.SetTimesToDefault();
            this.Hide();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
