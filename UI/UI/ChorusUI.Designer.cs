namespace UI
{
    partial class ChorusUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChorusUI));
            buttonONChorus = new Button();
            ChorusRate = new CustomTrackBar();
            DepthChorus = new CustomTrackBar();
            BaseDelayChorus = new CustomTrackBar();
            ChorusMix = new CustomTrackBar();
            ChorusFeedback = new CustomTrackBar();
            labelMixChorus = new Label();
            labelFeedbackChorus = new Label();
            labelRateChorus = new Label();
            labelDepthChorus = new Label();
            labelBaseDelayChorus = new Label();
            ((System.ComponentModel.ISupportInitialize)ChorusRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DepthChorus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BaseDelayChorus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChorusMix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ChorusFeedback).BeginInit();
            SuspendLayout();
            // 
            // buttonONChorus
            // 
            buttonONChorus.BackColor = Color.DarkGray;
            buttonONChorus.Location = new Point(151, 42);
            buttonONChorus.Name = "buttonONChorus";
            buttonONChorus.Size = new Size(51, 40);
            buttonONChorus.TabIndex = 3;
            buttonONChorus.Text = "OFF";
            buttonONChorus.UseVisualStyleBackColor = false;
            buttonONChorus.Click += buttonONChorus_Click;
            // 
            // ChorusRate
            // 
            ChorusRate.BackColor = Color.FromArgb(25, 25, 26);
            ChorusRate.Location = new Point(69, 104);
            ChorusRate.Name = "ChorusRate";
            ChorusRate.Size = new Size(58, 56);
            ChorusRate.TabIndex = 11;
            ChorusRate.Scroll += ChorusRate_Scroll;
            // 
            // DepthChorus
            // 
            DepthChorus.BackColor = Color.FromArgb(25, 25, 26);
            DepthChorus.Location = new Point(144, 104);
            DepthChorus.Name = "DepthChorus";
            DepthChorus.Size = new Size(58, 56);
            DepthChorus.TabIndex = 12;
            DepthChorus.Scroll += DepthChorus_Scroll;
            // 
            // BaseDelayChorus
            // 
            BaseDelayChorus.BackColor = Color.FromArgb(25, 25, 26);
            BaseDelayChorus.Location = new Point(214, 104);
            BaseDelayChorus.Name = "BaseDelayChorus";
            BaseDelayChorus.Size = new Size(58, 56);
            BaseDelayChorus.TabIndex = 13;
            BaseDelayChorus.Scroll += BaseDelayChorus_Scroll;
            // 
            // ChorusMix
            // 
            ChorusMix.BackColor = Color.FromArgb(25, 25, 26);
            ChorusMix.Location = new Point(69, 42);
            ChorusMix.Name = "ChorusMix";
            ChorusMix.Size = new Size(58, 56);
            ChorusMix.TabIndex = 14;
            ChorusMix.Scroll += ChorusMix_Scroll;
            // 
            // ChorusFeedback
            // 
            ChorusFeedback.BackColor = Color.FromArgb(25, 25, 26);
            ChorusFeedback.Location = new Point(214, 42);
            ChorusFeedback.Name = "ChorusFeedback";
            ChorusFeedback.Size = new Size(58, 56);
            ChorusFeedback.TabIndex = 15;
            ChorusFeedback.Scroll += ChorusFeedback_Scroll;
            // 
            // labelMixChorus
            // 
            labelMixChorus.AutoSize = true;
            labelMixChorus.BackColor = Color.FromArgb(25, 25, 26);
            labelMixChorus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelMixChorus.ForeColor = Color.WhiteSmoke;
            labelMixChorus.Location = new Point(87, 28);
            labelMixChorus.Name = "labelMixChorus";
            labelMixChorus.Size = new Size(34, 19);
            labelMixChorus.TabIndex = 17;
            labelMixChorus.Text = "Mix";
            // 
            // labelFeedbackChorus
            // 
            labelFeedbackChorus.AutoSize = true;
            labelFeedbackChorus.BackColor = Color.FromArgb(25, 25, 26);
            labelFeedbackChorus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelFeedbackChorus.ForeColor = Color.WhiteSmoke;
            labelFeedbackChorus.Location = new Point(208, 28);
            labelFeedbackChorus.Name = "labelFeedbackChorus";
            labelFeedbackChorus.Size = new Size(73, 19);
            labelFeedbackChorus.TabIndex = 18;
            labelFeedbackChorus.Text = "Feedback";
            // 
            // labelRateChorus
            // 
            labelRateChorus.AutoSize = true;
            labelRateChorus.BackColor = Color.FromArgb(25, 25, 26);
            labelRateChorus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelRateChorus.ForeColor = Color.WhiteSmoke;
            labelRateChorus.Location = new Point(82, 104);
            labelRateChorus.Name = "labelRateChorus";
            labelRateChorus.Size = new Size(39, 19);
            labelRateChorus.TabIndex = 19;
            labelRateChorus.Text = "Rate";
            // 
            // labelDepthChorus
            // 
            labelDepthChorus.AutoSize = true;
            labelDepthChorus.BackColor = Color.FromArgb(25, 25, 26);
            labelDepthChorus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelDepthChorus.ForeColor = Color.WhiteSmoke;
            labelDepthChorus.Location = new Point(151, 104);
            labelDepthChorus.Name = "labelDepthChorus";
            labelDepthChorus.Size = new Size(49, 19);
            labelDepthChorus.TabIndex = 20;
            labelDepthChorus.Text = "Depth";
            // 
            // labelBaseDelayChorus
            // 
            labelBaseDelayChorus.AutoSize = true;
            labelBaseDelayChorus.BackColor = Color.FromArgb(25, 25, 26);
            labelBaseDelayChorus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelBaseDelayChorus.ForeColor = Color.WhiteSmoke;
            labelBaseDelayChorus.Location = new Point(206, 104);
            labelBaseDelayChorus.Name = "labelBaseDelayChorus";
            labelBaseDelayChorus.Size = new Size(78, 19);
            labelBaseDelayChorus.TabIndex = 21;
            labelBaseDelayChorus.Text = "BaseDelay";
            // 
            // BossChorus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(346, 510);
            Controls.Add(labelBaseDelayChorus);
            Controls.Add(labelDepthChorus);
            Controls.Add(labelRateChorus);
            Controls.Add(labelFeedbackChorus);
            Controls.Add(labelMixChorus);
            Controls.Add(ChorusFeedback);
            Controls.Add(ChorusMix);
            Controls.Add(BaseDelayChorus);
            Controls.Add(DepthChorus);
            Controls.Add(ChorusRate);
            Controls.Add(buttonONChorus);
            Name = "BossChorus";
            Text = "BossChorus";
            ((System.ComponentModel.ISupportInitialize)ChorusRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)DepthChorus).EndInit();
            ((System.ComponentModel.ISupportInitialize)BaseDelayChorus).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChorusMix).EndInit();
            ((System.ComponentModel.ISupportInitialize)ChorusFeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonONChorus;
        private CustomTrackBar ChorusRate;
        private CustomTrackBar DepthChorus;
        private CustomTrackBar BaseDelayChorus;
        private CustomTrackBar ChorusMix;
        private CustomTrackBar ChorusFeedback;
        private Label labelMixChorus;
        private Label labelFeedbackChorus;
        private Label labelRateChorus;
        private Label labelDepthChorus;
        private Label labelBaseDelayChorus;
    }
}