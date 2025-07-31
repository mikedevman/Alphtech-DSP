namespace UI
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
            labelValueDelayTime = new Label();
            labelValueDelayMix = new Label();
            labelValueDelayFeedback = new Label();
            ((System.ComponentModel.ISupportInitialize)timeDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mixDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)feedbackDelay).BeginInit();
            SuspendLayout();
            // 
            // buttonONDelay
            // 
            buttonONDelay.BackColor = Color.DarkGray;
            buttonONDelay.Cursor = Cursors.Hand;
            buttonONDelay.Location = new Point(202, 42);
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
            labelTimeDelay.Location = new Point(101, 101);
            labelTimeDelay.Name = "labelTimeDelay";
            labelTimeDelay.Size = new Size(50, 23);
            labelTimeDelay.TabIndex = 10;
            labelTimeDelay.Text = "Time";
            // 
            // timeDelay
            // 
            timeDelay.BackColor = Color.FromArgb(41, 41, 41);
            timeDelay.Cursor = Cursors.Hand;
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
            mixDelay.Cursor = Cursors.Hand;
            mixDelay.Location = new Point(173, 127);
            mixDelay.Name = "mixDelay";
            mixDelay.Size = new Size(95, 56);
            mixDelay.TabIndex = 13;
            mixDelay.Scroll += mixDelay_Scroll;
            // 
            // feedbackDelay
            // 
            feedbackDelay.BackColor = Color.FromArgb(41, 41, 41);
            feedbackDelay.Cursor = Cursors.Hand;
            feedbackDelay.Location = new Point(271, 127);
            feedbackDelay.Name = "feedbackDelay";
            feedbackDelay.Size = new Size(94, 56);
            feedbackDelay.TabIndex = 14;
            feedbackDelay.Scroll += feedbackDelay_Scroll;
            // 
            // labelValueDelayTime
            // 
            labelValueDelayTime.AutoSize = true;
            labelValueDelayTime.BackColor = Color.FromArgb(41, 41, 41);
            labelValueDelayTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueDelayTime.ForeColor = Color.WhiteSmoke;
            labelValueDelayTime.Location = new Point(114, 160);
            labelValueDelayTime.Name = "labelValueDelayTime";
            labelValueDelayTime.Size = new Size(20, 23);
            labelValueDelayTime.TabIndex = 15;
            labelValueDelayTime.Text = "1";
            // 
            // labelValueDelayMix
            // 
            labelValueDelayMix.AutoSize = true;
            labelValueDelayMix.BackColor = Color.FromArgb(41, 41, 41);
            labelValueDelayMix.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueDelayMix.ForeColor = Color.WhiteSmoke;
            labelValueDelayMix.Location = new Point(213, 160);
            labelValueDelayMix.Name = "labelValueDelayMix";
            labelValueDelayMix.Size = new Size(20, 23);
            labelValueDelayMix.TabIndex = 16;
            labelValueDelayMix.Text = "0";
            // 
            // labelValueDelayFeedback
            // 
            labelValueDelayFeedback.AutoSize = true;
            labelValueDelayFeedback.BackColor = Color.FromArgb(41, 41, 41);
            labelValueDelayFeedback.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueDelayFeedback.ForeColor = Color.WhiteSmoke;
            labelValueDelayFeedback.Location = new Point(312, 160);
            labelValueDelayFeedback.Name = "labelValueDelayFeedback";
            labelValueDelayFeedback.Size = new Size(20, 23);
            labelValueDelayFeedback.TabIndex = 17;
            labelValueDelayFeedback.Text = "0";
            // 
            // DelayUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(444, 685);
            Controls.Add(labelValueDelayFeedback);
            Controls.Add(labelValueDelayMix);
            Controls.Add(labelValueDelayTime);
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
        private Label labelValueDelayTime;
        private Label labelValueDelayMix;
        private Label labelValueDelayFeedback;
    }
}