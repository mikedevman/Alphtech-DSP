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
            labelMixChorus.Location = new Point(202, 126);
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
            labelRateChorus.Location = new Point(105, 126);
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
            labelDepthChorus.Location = new Point(290, 126);
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
            chorusBaseDelay.Location = new Point(85, 45);
            chorusBaseDelay.Name = "chorusBaseDelay";
            chorusBaseDelay.Size = new Size(73, 56);
            chorusBaseDelay.TabIndex = 22;
            chorusBaseDelay.Scroll += chorusBaseDelay_Scroll;
            // 
            // chorusFeedback
            // 
            chorusFeedback.BackColor = Color.FromArgb(24, 20, 20);
            chorusFeedback.Location = new Point(260, 45);
            chorusFeedback.Name = "chorusFeedback";
            chorusFeedback.Size = new Size(79, 56);
            chorusFeedback.TabIndex = 23;
            chorusFeedback.Scroll += chorusFeedback_Scroll;
            // 
            // chorusRate
            // 
            chorusRate.BackColor = Color.FromArgb(24, 20, 20);
            chorusRate.Location = new Point(81, 148);
            chorusRate.Name = "chorusRate";
            chorusRate.Size = new Size(77, 56);
            chorusRate.TabIndex = 24;
            chorusRate.Scroll += chorusRate_Scroll;
            // 
            // chorusDepth
            // 
            chorusDepth.BackColor = Color.FromArgb(24, 20, 20);
            chorusDepth.Location = new Point(272, 148);
            chorusDepth.Name = "chorusDepth";
            chorusDepth.Size = new Size(76, 56);
            chorusDepth.TabIndex = 25;
            chorusDepth.Scroll += chorusDepth_Scroll;
            // 
            // chorusMix
            // 
            chorusMix.BackColor = Color.FromArgb(24, 20, 20);
            chorusMix.Location = new Point(178, 148);
            chorusMix.Name = "chorusMix";
            chorusMix.Size = new Size(78, 56);
            chorusMix.TabIndex = 26;
            chorusMix.Scroll += chorusMix_Scroll;
            // 
            // ChorusUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(448, 639);
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
    }
}