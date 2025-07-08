namespace UI
{
    partial class AmpUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmpUI));
            buttonON = new Button();
            Mid = new CustomTrackBar();
            Volume = new CustomTrackBar();
            Treble = new CustomTrackBar();
            Gain = new CustomTrackBar();
            Bass = new CustomTrackBar();
            labelVolume = new Label();
            labelGain = new Label();
            labelTreble = new Label();
            labelMid = new Label();
            labelBass = new Label();
            ((System.ComponentModel.ISupportInitialize)Mid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Treble).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bass).BeginInit();
            SuspendLayout();
            // 
            // buttonON
            // 
            buttonON.BackColor = Color.DarkGray;
            buttonON.Location = new Point(1013, 104);
            buttonON.Name = "buttonON";
            buttonON.Size = new Size(51, 40);
            buttonON.TabIndex = 0;
            buttonON.Text = "OFF";
            buttonON.UseVisualStyleBackColor = false;
            buttonON.Click += buttonON_Click;
            // 
            // Mid
            // 
            Mid.BackColor = SystemColors.ActiveCaptionText;
            Mid.Location = new Point(531, 104);
            Mid.Name = "Mid";
            Mid.Size = new Size(130, 56);
            Mid.TabIndex = 1;
            // 
            // Volume
            // 
            Volume.BackColor = SystemColors.ActiveCaptionText;
            Volume.Location = new Point(121, 104);
            Volume.Name = "Volume";
            Volume.Size = new Size(130, 56);
            Volume.TabIndex = 2;
            Volume.Scroll += Volume_Scroll;
            // 
            // Treble
            // 
            Treble.BackColor = SystemColors.ActiveCaptionText;
            Treble.Location = new Point(393, 104);
            Treble.Name = "Treble";
            Treble.Size = new Size(130, 56);
            Treble.TabIndex = 3;
            Treble.Scroll += Treble_Scroll;
            // 
            // Gain
            // 
            Gain.BackColor = SystemColors.ActiveCaptionText;
            Gain.Location = new Point(257, 104);
            Gain.Name = "Gain";
            Gain.Size = new Size(130, 56);
            Gain.TabIndex = 4;
            Gain.Scroll += Gain_Scroll;
            // 
            // Bass
            // 
            Bass.BackColor = SystemColors.ActiveCaptionText;
            Bass.Location = new Point(667, 104);
            Bass.Name = "Bass";
            Bass.Size = new Size(130, 56);
            Bass.TabIndex = 5;
            Bass.Scroll += Bass_Scroll;
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.BackColor = SystemColors.InactiveCaptionText;
            labelVolume.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelVolume.ForeColor = Color.WhiteSmoke;
            labelVolume.Location = new Point(159, 104);
            labelVolume.Name = "labelVolume";
            labelVolume.Size = new Size(70, 23);
            labelVolume.TabIndex = 6;
            labelVolume.Text = "Volume";
            // 
            // labelGain
            // 
            labelGain.AutoSize = true;
            labelGain.BackColor = SystemColors.InactiveCaptionText;
            labelGain.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelGain.ForeColor = Color.WhiteSmoke;
            labelGain.Location = new Point(302, 104);
            labelGain.Name = "labelGain";
            labelGain.Size = new Size(46, 23);
            labelGain.TabIndex = 7;
            labelGain.Text = "Gain";
            // 
            // labelTreble
            // 
            labelTreble.AutoSize = true;
            labelTreble.BackColor = SystemColors.InactiveCaptionText;
            labelTreble.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelTreble.ForeColor = Color.WhiteSmoke;
            labelTreble.Location = new Point(431, 104);
            labelTreble.Name = "labelTreble";
            labelTreble.Size = new Size(60, 23);
            labelTreble.TabIndex = 8;
            labelTreble.Text = "Treble";
            // 
            // labelMid
            // 
            labelMid.AutoSize = true;
            labelMid.BackColor = SystemColors.InactiveCaptionText;
            labelMid.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelMid.ForeColor = Color.WhiteSmoke;
            labelMid.Location = new Point(576, 104);
            labelMid.Name = "labelMid";
            labelMid.Size = new Size(42, 23);
            labelMid.TabIndex = 9;
            labelMid.Text = "Mid";
            // 
            // labelBass
            // 
            labelBass.AutoSize = true;
            labelBass.BackColor = SystemColors.InactiveCaptionText;
            labelBass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelBass.ForeColor = Color.WhiteSmoke;
            labelBass.Location = new Point(712, 104);
            labelBass.Name = "labelBass";
            labelBass.Size = new Size(44, 23);
            labelBass.TabIndex = 10;
            labelBass.Text = "Bass";
            // 
            // AmpUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1131, 797);
            Controls.Add(labelBass);
            Controls.Add(labelMid);
            Controls.Add(labelTreble);
            Controls.Add(labelGain);
            Controls.Add(labelVolume);
            Controls.Add(Bass);
            Controls.Add(Gain);
            Controls.Add(Treble);
            Controls.Add(Volume);
            Controls.Add(Mid);
            Controls.Add(buttonON);
            Name = "AmpUI";
            ((System.ComponentModel.ISupportInitialize)Mid).EndInit();
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ((System.ComponentModel.ISupportInitialize)Treble).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gain).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonON;
        private CustomTrackBar Volume;
        private CustomTrackBar Gain;
        private CustomTrackBar Treble;
        private CustomTrackBar Mid;
        private CustomTrackBar Bass;
        private Label labelVolume;
        private Label labelGain;
        private Label labelTreble;
        private Label labelMid;
        private Label labelBass;
    }
}
