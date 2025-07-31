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
            labelMixChorus = new Label();
            labelFeedbackChorus = new Label();
            labelRateChorus = new Label();
            labelDepthChorus = new Label();
            labelBaseDelayChorus = new Label();
            chorusBaseDelay = new TrackBar();
            chorusFeedback = new TrackBar();
            chorusRate = new TrackBar();
            chorusDepth = new TrackBar();
            chorusMix = new TrackBar();
            labelValueChorusBaseDelay = new Label();
            labelValueChorusFeedback = new Label();
            labelValueChorusRate = new Label();
            labelValueChorusMix = new Label();
            labelValueChorusDepth = new Label();
            ((System.ComponentModel.ISupportInitialize)chorusBaseDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chorusFeedback).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chorusRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chorusDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chorusMix).BeginInit();
            SuspendLayout();
            // 
            // buttonONChorus
            // 
            buttonONChorus.BackColor = Color.DarkGray;
            buttonONChorus.Cursor = Cursors.Hand;
            buttonONChorus.Location = new Point(185, 45);
            buttonONChorus.Name = "buttonONChorus";
            buttonONChorus.Size = new Size(51, 40);
            buttonONChorus.TabIndex = 3;
            buttonONChorus.Text = "OFF";
            buttonONChorus.UseVisualStyleBackColor = false;
            buttonONChorus.Click += buttonONChorus_Click;
            // 
            // labelMixChorus
            // 
            labelMixChorus.AutoSize = true;
            labelMixChorus.BackColor = Color.FromArgb(25, 25, 26);
            labelMixChorus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            labelMixChorus.ForeColor = Color.WhiteSmoke;
            labelMixChorus.Location = new Point(195, 116);
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
            labelFeedbackChorus.Location = new Point(266, 23);
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
            labelRateChorus.Location = new Point(105, 116);
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
            labelDepthChorus.Location = new Point(277, 116);
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
            labelBaseDelayChorus.Location = new Point(81, 23);
            labelBaseDelayChorus.Name = "labelBaseDelayChorus";
            labelBaseDelayChorus.Size = new Size(78, 19);
            labelBaseDelayChorus.TabIndex = 21;
            labelBaseDelayChorus.Text = "BaseDelay";
            // 
            // chorusBaseDelay
            // 
            chorusBaseDelay.BackColor = Color.FromArgb(24, 20, 20);
            chorusBaseDelay.Cursor = Cursors.Hand;
            chorusBaseDelay.Location = new Point(85, 45);
            chorusBaseDelay.Name = "chorusBaseDelay";
            chorusBaseDelay.Size = new Size(73, 56);
            chorusBaseDelay.TabIndex = 22;
            chorusBaseDelay.Scroll += chorusBaseDelay_Scroll;
            // 
            // chorusFeedback
            // 
            chorusFeedback.BackColor = Color.FromArgb(24, 20, 20);
            chorusFeedback.Cursor = Cursors.Hand;
            chorusFeedback.Location = new Point(260, 45);
            chorusFeedback.Name = "chorusFeedback";
            chorusFeedback.Size = new Size(79, 56);
            chorusFeedback.TabIndex = 23;
            chorusFeedback.Scroll += chorusFeedback_Scroll;
            // 
            // chorusRate
            // 
            chorusRate.BackColor = Color.FromArgb(24, 20, 20);
            chorusRate.Cursor = Cursors.Hand;
            chorusRate.Location = new Point(85, 138);
            chorusRate.Name = "chorusRate";
            chorusRate.Size = new Size(77, 56);
            chorusRate.TabIndex = 24;
            chorusRate.Scroll += chorusRate_Scroll;
            // 
            // chorusDepth
            // 
            chorusDepth.BackColor = Color.FromArgb(24, 20, 20);
            chorusDepth.Cursor = Cursors.Hand;
            chorusDepth.Location = new Point(260, 138);
            chorusDepth.Name = "chorusDepth";
            chorusDepth.Size = new Size(79, 56);
            chorusDepth.TabIndex = 25;
            chorusDepth.Scroll += chorusDepth_Scroll;
            // 
            // chorusMix
            // 
            chorusMix.BackColor = Color.FromArgb(24, 20, 20);
            chorusMix.Cursor = Cursors.Hand;
            chorusMix.Location = new Point(168, 138);
            chorusMix.Name = "chorusMix";
            chorusMix.Size = new Size(85, 56);
            chorusMix.TabIndex = 26;
            chorusMix.Scroll += chorusMix_Scroll;
            // 
            // labelValueChorusBaseDelay
            // 
            labelValueChorusBaseDelay.AutoSize = true;
            labelValueChorusBaseDelay.BackColor = Color.FromArgb(24, 20, 20);
            labelValueChorusBaseDelay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueChorusBaseDelay.ForeColor = Color.WhiteSmoke;
            labelValueChorusBaseDelay.Location = new Point(105, 78);
            labelValueChorusBaseDelay.Name = "labelValueChorusBaseDelay";
            labelValueChorusBaseDelay.Size = new Size(30, 23);
            labelValueChorusBaseDelay.TabIndex = 27;
            labelValueChorusBaseDelay.Text = "10";
            // 
            // labelValueChorusFeedback
            // 
            labelValueChorusFeedback.AutoSize = true;
            labelValueChorusFeedback.BackColor = Color.FromArgb(24, 20, 20);
            labelValueChorusFeedback.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueChorusFeedback.ForeColor = Color.WhiteSmoke;
            labelValueChorusFeedback.Location = new Point(291, 78);
            labelValueChorusFeedback.Name = "labelValueChorusFeedback";
            labelValueChorusFeedback.Size = new Size(20, 23);
            labelValueChorusFeedback.TabIndex = 28;
            labelValueChorusFeedback.Text = "0";
            // 
            // labelValueChorusRate
            // 
            labelValueChorusRate.AutoSize = true;
            labelValueChorusRate.BackColor = Color.FromArgb(24, 20, 20);
            labelValueChorusRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueChorusRate.ForeColor = Color.WhiteSmoke;
            labelValueChorusRate.Location = new Point(114, 171);
            labelValueChorusRate.Name = "labelValueChorusRate";
            labelValueChorusRate.Size = new Size(20, 23);
            labelValueChorusRate.TabIndex = 29;
            labelValueChorusRate.Text = "1";
            // 
            // labelValueChorusMix
            // 
            labelValueChorusMix.AutoSize = true;
            labelValueChorusMix.BackColor = Color.FromArgb(24, 20, 20);
            labelValueChorusMix.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueChorusMix.ForeColor = Color.WhiteSmoke;
            labelValueChorusMix.Location = new Point(201, 171);
            labelValueChorusMix.Name = "labelValueChorusMix";
            labelValueChorusMix.Size = new Size(20, 23);
            labelValueChorusMix.TabIndex = 30;
            labelValueChorusMix.Text = "0";
            // 
            // labelValueChorusDepth
            // 
            labelValueChorusDepth.AutoSize = true;
            labelValueChorusDepth.BackColor = Color.FromArgb(24, 20, 20);
            labelValueChorusDepth.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueChorusDepth.ForeColor = Color.WhiteSmoke;
            labelValueChorusDepth.Location = new Point(291, 171);
            labelValueChorusDepth.Name = "labelValueChorusDepth";
            labelValueChorusDepth.Size = new Size(20, 23);
            labelValueChorusDepth.TabIndex = 31;
            labelValueChorusDepth.Text = "0";
            // 
            // ChorusUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(448, 639);
            Controls.Add(labelValueChorusDepth);
            Controls.Add(labelValueChorusMix);
            Controls.Add(labelValueChorusRate);
            Controls.Add(labelValueChorusFeedback);
            Controls.Add(labelValueChorusBaseDelay);
            Controls.Add(chorusMix);
            Controls.Add(chorusDepth);
            Controls.Add(chorusRate);
            Controls.Add(chorusFeedback);
            Controls.Add(chorusBaseDelay);
            Controls.Add(labelBaseDelayChorus);
            Controls.Add(labelDepthChorus);
            Controls.Add(labelRateChorus);
            Controls.Add(labelFeedbackChorus);
            Controls.Add(labelMixChorus);
            Controls.Add(buttonONChorus);
            DoubleBuffered = true;
            Name = "ChorusUI";
            Text = "BossChorus";
            ((System.ComponentModel.ISupportInitialize)chorusBaseDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)chorusFeedback).EndInit();
            ((System.ComponentModel.ISupportInitialize)chorusRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)chorusDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)chorusMix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonONChorus;
        private Label labelMixChorus;
        private Label labelFeedbackChorus;
        private Label labelRateChorus;
        private Label labelDepthChorus;
        private Label labelBaseDelayChorus;
        private TrackBar chorusBaseDelay;
        private TrackBar chorusFeedback;
        private TrackBar chorusRate;
        private TrackBar chorusDepth;
        private TrackBar chorusMix;
        private Label labelValueChorusBaseDelay;
        private Label labelValueChorusFeedback;
        private Label labelValueChorusRate;
        private Label labelValueChorusMix;
        private Label labelValueChorusDepth;
    }
}