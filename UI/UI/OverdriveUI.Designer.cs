namespace UI
{
    partial class OverdriveUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverdriveUI));
            buttonONOverdrive = new Button();
            Gain = new TrackBar();
            labelGain = new Label();
            ((System.ComponentModel.ISupportInitialize)Gain).BeginInit();
            SuspendLayout();
            // 
            // buttonONOverdrive
            // 
            buttonONOverdrive.BackColor = Color.DarkGray;
            buttonONOverdrive.Cursor = Cursors.Hand;
            buttonONOverdrive.Location = new Point(196, 50);
            buttonONOverdrive.Name = "buttonONOverdrive";
            buttonONOverdrive.Size = new Size(51, 40);
            buttonONOverdrive.TabIndex = 3;
            buttonONOverdrive.Text = "OFF";
            buttonONOverdrive.UseVisualStyleBackColor = false;
            buttonONOverdrive.Click += buttonONOverdrive_Click;
            // 
            // Gain
            // 
            Gain.BackColor = Color.FromArgb(20, 19, 19);
            Gain.Cursor = Cursors.Hand;
            Gain.Location = new Point(173, 151);
            Gain.Name = "Gain";
            Gain.Size = new Size(98, 56);
            Gain.TabIndex = 13;
            Gain.Scroll += Gain_Scroll;
            // 
            // labelGain
            // 
            labelGain.AutoSize = true;
            labelGain.BackColor = Color.FromArgb(20, 19, 19);
            labelGain.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelGain.ForeColor = Color.WhiteSmoke;
            labelGain.Location = new Point(196, 125);
            labelGain.Name = "labelGain";
            labelGain.Size = new Size(46, 23);
            labelGain.TabIndex = 14;
            labelGain.Text = "Gain";
            // 
            // OverdriveUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(441, 715);
            Controls.Add(labelGain);
            Controls.Add(Gain);
            Controls.Add(buttonONOverdrive);
            Name = "OverdriveUI";
            Text = "OverdriveUI";
            ((System.ComponentModel.ISupportInitialize)Gain).EndInit();
            ResumeLayout(false);
            PerformLayout();

            this.FormClosing += OverdriveUI_FormClosing;
        }

        #endregion

        private Button buttonONOverdrive;
        private TrackBar Gain;
        private Label labelGain;
    }
}