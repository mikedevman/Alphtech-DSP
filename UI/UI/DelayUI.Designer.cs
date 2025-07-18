﻿namespace UI
{
    partial class DelayUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DelayUI));
            buttonONDelay = new Button();
            labelMixDelay = new Label();
            labelFeedbackDelay = new Label();
            labelTimeDelay = new Label();
            timeDelay = new TrackBar();
            label1 = new Label();
            mixDelay = new TrackBar();
            feedbackDelay = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)timeDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mixDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)feedbackDelay).BeginInit();
            SuspendLayout();
            // 
            // buttonONDelay
            // 
            buttonONDelay.BackColor = Color.DarkGray;
            buttonONDelay.Location = new Point(210, 42);
            buttonONDelay.Name = "buttonONDelay";
            buttonONDelay.Size = new Size(51, 40);
            buttonONDelay.TabIndex = 1;
            buttonONDelay.Text = "OFF";
            buttonONDelay.UseVisualStyleBackColor = false;
            buttonONDelay.Click += buttonONDelay_Click;
            // 
            // labelMixDelay
            // 
            labelMixDelay.AutoSize = true;
            labelMixDelay.BackColor = Color.FromArgb(41, 41, 41);
            labelMixDelay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelMixDelay.ForeColor = Color.WhiteSmoke;
            labelMixDelay.Location = new Point(202, 101);
            labelMixDelay.Name = "labelMixDelay";
            labelMixDelay.Size = new Size(40, 23);
            labelMixDelay.TabIndex = 8;
            labelMixDelay.Text = "Mix";
            // 
            // labelFeedbackDelay
            // 
            labelFeedbackDelay.AutoSize = true;
            labelFeedbackDelay.BackColor = Color.FromArgb(41, 41, 41);
            labelFeedbackDelay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelFeedbackDelay.ForeColor = Color.WhiteSmoke;
            labelFeedbackDelay.Location = new Point(279, 101);
            labelFeedbackDelay.Name = "labelFeedbackDelay";
            labelFeedbackDelay.Size = new Size(86, 23);
            labelFeedbackDelay.TabIndex = 9;
            labelFeedbackDelay.Text = "Feedback";
            // 
            // labelTimeDelay
            // 
            labelTimeDelay.AutoSize = true;
            labelTimeDelay.BackColor = Color.FromArgb(41, 41, 41);
            labelTimeDelay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelTimeDelay.ForeColor = Color.WhiteSmoke;
            labelTimeDelay.Location = new Point(96, 101);
            labelTimeDelay.Name = "labelTimeDelay";
            labelTimeDelay.Size = new Size(50, 23);
            labelTimeDelay.TabIndex = 10;
            labelTimeDelay.Text = "Time";
            // 
            // timeDelay
            // 
            timeDelay.BackColor = Color.FromArgb(41, 41, 41);
            timeDelay.Location = new Point(74, 127);
            timeDelay.Name = "timeDelay";
            timeDelay.Size = new Size(98, 56);
            timeDelay.TabIndex = 11;
            timeDelay.Scroll += timeDelay_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(41, 41, 41);
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(202, 331);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 12;
            // 
            // mixDelay
            // 
            mixDelay.BackColor = Color.FromArgb(41, 41, 41);
            mixDelay.Location = new Point(178, 127);
            mixDelay.Name = "mixDelay";
            mixDelay.Size = new Size(90, 56);
            mixDelay.TabIndex = 13;
            mixDelay.Scroll += mixDelay_Scroll;
            // 
            // feedbackDelay
            // 
            feedbackDelay.BackColor = Color.FromArgb(41, 41, 41);
            feedbackDelay.Location = new Point(271, 127);
            feedbackDelay.Name = "feedbackDelay";
            feedbackDelay.Size = new Size(94, 56);
            feedbackDelay.TabIndex = 14;
            feedbackDelay.Scroll += feedbackDelay_Scroll;
            // 
            // DelayUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(444, 685);
            Controls.Add(feedbackDelay);
            Controls.Add(mixDelay);
            Controls.Add(label1);
            Controls.Add(timeDelay);
            Controls.Add(labelTimeDelay);
            Controls.Add(labelFeedbackDelay);
            Controls.Add(labelMixDelay);
            Controls.Add(buttonONDelay);
            Name = "DelayUI";
            Text = "DelayUI";
            ((System.ComponentModel.ISupportInitialize)timeDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)mixDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)feedbackDelay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonONDelay;
        private Label labelMixDelay;
        private Label labelFeedbackDelay;
        private Label labelTimeDelay;
        private TrackBar timeDelay;
        private Label label1;
        private TrackBar mixDelay;
        private TrackBar feedbackDelay;
    }
}