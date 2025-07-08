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
            DelayMix = new CustomTrackBar();
            DelayFeedback = new CustomTrackBar();
            labelMixDelay = new Label();
            labelFeedbackDelay = new Label();
            ((System.ComponentModel.ISupportInitialize)DelayMix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DelayFeedback).BeginInit();
            SuspendLayout();
            // 
            // buttonONDelay
            // 
            buttonONDelay.BackColor = Color.DarkGray;
            buttonONDelay.Location = new Point(205, 43);
            buttonONDelay.Name = "buttonONDelay";
            buttonONDelay.Size = new Size(51, 40);
            buttonONDelay.TabIndex = 1;
            buttonONDelay.Text = "OFF";
            buttonONDelay.UseVisualStyleBackColor = false;
            buttonONDelay.Click += buttonONDelay_Click;
            // 
            // DelayMix
            // 
            DelayMix.BackColor = Color.FromArgb(41, 41, 41);
            DelayMix.Location = new Point(87, 148);
            DelayMix.Name = "DelayMix";
            DelayMix.Size = new Size(130, 56);
            DelayMix.TabIndex = 3;
            DelayMix.Scroll += DelayMix_Scroll;
            // 
            // DelayFeedback
            // 
            DelayFeedback.BackColor = Color.FromArgb(41, 41, 41);
            DelayFeedback.Location = new Point(234, 148);
            DelayFeedback.Name = "DelayFeedback";
            DelayFeedback.Size = new Size(130, 56);
            DelayFeedback.TabIndex = 4;
            DelayFeedback.Scroll += DelayFeedback_Scroll;
            // 
            // labelMixDelay
            // 
            labelMixDelay.AutoSize = true;
            labelMixDelay.BackColor = Color.FromArgb(41, 41, 41);
            labelMixDelay.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelMixDelay.ForeColor = Color.WhiteSmoke;
            labelMixDelay.Location = new Point(133, 122);
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
            labelFeedbackDelay.Location = new Point(259, 122);
            labelFeedbackDelay.Name = "labelFeedbackDelay";
            labelFeedbackDelay.Size = new Size(86, 23);
            labelFeedbackDelay.TabIndex = 9;
            labelFeedbackDelay.Text = "Feedback";
            // 
            // DelayUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(444, 685);
            Controls.Add(labelFeedbackDelay);
            Controls.Add(labelMixDelay);
            Controls.Add(DelayFeedback);
            Controls.Add(DelayMix);
            Controls.Add(buttonONDelay);
            Name = "DelayUI";
            Text = "DelayUI";
            ((System.ComponentModel.ISupportInitialize)DelayMix).EndInit();
            ((System.ComponentModel.ISupportInitialize)DelayFeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonONDelay;
        private CustomTrackBar DelayMix;
        private CustomTrackBar DelayFeedback;
        private Label labelMixDelay;
        private Label labelFeedbackDelay;
    }
}