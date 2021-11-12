namespace EyeSaver
{
    partial class settingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workTrackBar = new System.Windows.Forms.TrackBar();
            this.breakTrackBar = new System.Windows.Forms.TrackBar();
            this.workLabel = new System.Windows.Forms.Label();
            this.breakLabel = new System.Windows.Forms.Label();
            this.LongBreakTrackBar = new System.Windows.Forms.TrackBar();
            this.longBreakLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.applySettingsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.workTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongBreakTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // workTrackBar
            // 
            this.workTrackBar.Location = new System.Drawing.Point(45, 125);
            this.workTrackBar.Maximum = 60;
            this.workTrackBar.Minimum = 1;
            this.workTrackBar.Name = "workTrackBar";
            this.workTrackBar.Size = new System.Drawing.Size(104, 45);
            this.workTrackBar.TabIndex = 0;
            this.workTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.workTrackBar.Value = 1;
            this.workTrackBar.Scroll += new System.EventHandler(this.workTrackBar_Scroll);
            // 
            // breakTrackBar
            // 
            this.breakTrackBar.Location = new System.Drawing.Point(234, 125);
            this.breakTrackBar.Maximum = 60;
            this.breakTrackBar.Minimum = 1;
            this.breakTrackBar.Name = "breakTrackBar";
            this.breakTrackBar.Size = new System.Drawing.Size(104, 45);
            this.breakTrackBar.TabIndex = 1;
            this.breakTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.breakTrackBar.Value = 1;
            this.breakTrackBar.Scroll += new System.EventHandler(this.breakTrackBar_Scroll);
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Location = new System.Drawing.Point(76, 98);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(38, 15);
            this.workLabel.TabIndex = 3;
            this.workLabel.Text = "label1";
            // 
            // breakLabel
            // 
            this.breakLabel.AutoSize = true;
            this.breakLabel.Location = new System.Drawing.Point(263, 98);
            this.breakLabel.Name = "breakLabel";
            this.breakLabel.Size = new System.Drawing.Size(38, 15);
            this.breakLabel.TabIndex = 4;
            this.breakLabel.Text = "label2";
            // 
            // LongBreakTrackBar
            // 
            this.LongBreakTrackBar.Location = new System.Drawing.Point(388, 125);
            this.LongBreakTrackBar.Maximum = 60;
            this.LongBreakTrackBar.Minimum = 1;
            this.LongBreakTrackBar.Name = "LongBreakTrackBar";
            this.LongBreakTrackBar.Size = new System.Drawing.Size(104, 45);
            this.LongBreakTrackBar.TabIndex = 2;
            this.LongBreakTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.LongBreakTrackBar.Value = 1;
            this.LongBreakTrackBar.Scroll += new System.EventHandler(this.LongBreakTrackBar_Scroll);
            // 
            // longBreakLabel
            // 
            this.longBreakLabel.AutoSize = true;
            this.longBreakLabel.Location = new System.Drawing.Point(421, 98);
            this.longBreakLabel.Name = "longBreakLabel";
            this.longBreakLabel.Size = new System.Drawing.Size(38, 15);
            this.longBreakLabel.TabIndex = 5;
            this.longBreakLabel.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Work";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(253, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Break";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(389, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Long break";
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Location = new System.Drawing.Point(466, 175);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(75, 23);
            this.applySettingsButton.TabIndex = 9;
            this.applySettingsButton.Text = "Apply";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.applySettingsButton_Click);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 210);
            this.Controls.Add(this.applySettingsButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longBreakLabel);
            this.Controls.Add(this.breakLabel);
            this.Controls.Add(this.workLabel);
            this.Controls.Add(this.LongBreakTrackBar);
            this.Controls.Add(this.breakTrackBar);
            this.Controls.Add(this.workTrackBar);
            this.Name = "settingsForm";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LongBreakTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar workTrackBar;
        private System.Windows.Forms.TrackBar breakTrackBar;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label breakLabel;
        private System.Windows.Forms.TrackBar LongBreakTrackBar;
        private System.Windows.Forms.Label longBreakLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applySettingsButton;
    }
}