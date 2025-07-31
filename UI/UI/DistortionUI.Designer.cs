namespace UI
{
    partial class DistortionUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DistortionUI));
            buttonONDistortion = new Button();
            labelGain = new Label();
            Gain = new TrackBar();
            labelValueDistortionGain = new Label();
            ((System.ComponentModel.ISupportInitialize)Gain).BeginInit();
            SuspendLayout();
            // 
            // buttonONDistortion
            // 
            buttonONDistortion.BackColor = Color.DarkGray;
            buttonONDistortion.Cursor = Cursors.Hand;
            buttonONDistortion.Location = new Point(170, 50);
            buttonONDistortion.Name = "buttonONDistortion";
            buttonONDistortion.Size = new Size(51, 40);
            buttonONDistortion.TabIndex = 4;
            buttonONDistortion.Text = "OFF";
            buttonONDistortion.UseVisualStyleBackColor = false;
            buttonONDistortion.Click += buttonONDistortion_Click;
            // 
            // labelGain
            // 
            labelGain.AutoSize = true;
            labelGain.BackColor = Color.FromArgb(20, 19, 19);
            labelGain.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelGain.ForeColor = Color.WhiteSmoke;
            labelGain.Location = new Point(154, 116);
            labelGain.Name = "labelGain";
            labelGain.Size = new Size(46, 23);
            labelGain.TabIndex = 15;
            labelGain.Text = "Gain";
            // 
            // Gain
            // 
            Gain.BackColor = Color.FromArgb(20, 19, 19);
            Gain.Cursor = Cursors.Hand;
            Gain.Location = new Point(145, 142);
            Gain.Name = "Gain";
            Gain.Size = new Size(98, 56);
            Gain.TabIndex = 16;
            Gain.Scroll += Gain_Scroll;
            // 
            // labelValueDistortionGain
            // 
            labelValueDistortionGain.AutoSize = true;
            labelValueDistortionGain.BackColor = Color.FromArgb(20, 19, 19);
            labelValueDistortionGain.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueDistortionGain.ForeColor = Color.WhiteSmoke;
            labelValueDistortionGain.Location = new Point(195, 116);
            labelValueDistortionGain.Name = "labelValueDistortionGain";
            labelValueDistortionGain.Size = new Size(35, 23);
            labelValueDistortionGain.TabIndex = 32;
            labelValueDistortionGain.Text = "1.0";
            // 
            // DistortionUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(391, 634);
            Controls.Add(labelValueDistortionGain);
            Controls.Add(Gain);
            Controls.Add(labelGain);
            Controls.Add(buttonONDistortion);
            DoubleBuffered = true;
            Name = "DistortionUI";
            Text = "DistortionUI";
            FormClosing += DistortionUI_FormClosing;
            ((System.ComponentModel.ISupportInitialize)Gain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonONDistortion;
        private Label labelGain;
        private TrackBar Gain;
        private Label labelValueDistortionGain;
    }
}