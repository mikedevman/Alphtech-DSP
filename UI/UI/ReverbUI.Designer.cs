namespace UI
{
    partial class ReverbUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReverbUI));
            buttonONReverb = new Button();
            labelMixReverb = new Label();
            DelayMix = new CustomTrackBar();
            labelFeedbackReverb = new Label();
            ReverbFeedback = new CustomTrackBar();
            ((System.ComponentModel.ISupportInitialize)DelayMix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReverbFeedback).BeginInit();
            SuspendLayout();
            // 
            // buttonONReverb
            // 
            buttonONReverb.BackColor = Color.DarkGray;
            buttonONReverb.Location = new Point(146, 24);
            buttonONReverb.Name = "buttonONReverb";
            buttonONReverb.Size = new Size(51, 40);
            buttonONReverb.TabIndex = 2;
            buttonONReverb.Text = "OFF";
            buttonONReverb.UseVisualStyleBackColor = false;
            buttonONReverb.Click += buttonONReverb_Click;
            // 
            // labelMixReverb
            // 
            labelMixReverb.AutoSize = true;
            labelMixReverb.BackColor = Color.FromArgb(25, 25, 26);
            labelMixReverb.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelMixReverb.ForeColor = Color.WhiteSmoke;
            labelMixReverb.Location = new Point(85, 95);
            labelMixReverb.Name = "labelMixReverb";
            labelMixReverb.Size = new Size(40, 23);
            labelMixReverb.TabIndex = 9;
            labelMixReverb.Text = "Mix";
            // 
            // DelayMix
            // 
            DelayMix.BackColor = Color.FromArgb(25, 25, 26);
            DelayMix.Location = new Point(51, 121);
            DelayMix.Name = "DelayMix";
            DelayMix.Size = new Size(105, 56);
            DelayMix.TabIndex = 10;
            DelayMix.Scroll += DelayMix_Scroll;
            // 
            // labelFeedbackReverb
            // 
            labelFeedbackReverb.AutoSize = true;
            labelFeedbackReverb.BackColor = Color.FromArgb(25, 25, 26);
            labelFeedbackReverb.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelFeedbackReverb.ForeColor = Color.WhiteSmoke;
            labelFeedbackReverb.Location = new Point(191, 95);
            labelFeedbackReverb.Name = "labelFeedbackReverb";
            labelFeedbackReverb.Size = new Size(86, 23);
            labelFeedbackReverb.TabIndex = 11;
            labelFeedbackReverb.Text = "Feedback";
            // 
            // ReverbFeedback
            // 
            ReverbFeedback.BackColor = Color.FromArgb(25, 25, 26);
            ReverbFeedback.Location = new Point(178, 121);
            ReverbFeedback.Name = "ReverbFeedback";
            ReverbFeedback.Size = new Size(114, 56);
            ReverbFeedback.TabIndex = 12;
            ReverbFeedback.Scroll += ReverbFeedback_Scroll;
            // 
            // ReverbUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(345, 591);
            Controls.Add(ReverbFeedback);
            Controls.Add(labelFeedbackReverb);
            Controls.Add(DelayMix);
            Controls.Add(labelMixReverb);
            Controls.Add(buttonONReverb);
            Name = "ReverbUI";
            Text = "ReverbUI";
            ((System.ComponentModel.ISupportInitialize)DelayMix).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReverbFeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonONReverb;
        private Label labelMixReverb;
        private CustomTrackBar DelayMix;
        private Label labelFeedbackReverb;
        private CustomTrackBar ReverbFeedback;
    }
}