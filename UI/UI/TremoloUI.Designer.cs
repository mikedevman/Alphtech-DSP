namespace UI
{
    partial class TremoloUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TremoloUI));
            buttonONTremolo = new Button();
            rateTremolo = new TrackBar();
            labelRateTremolo = new Label();
            labelDepthTremolo = new Label();
            depthTremolo = new TrackBar();
            labelValueTremoloRate = new Label();
            labelValueTremoloDepth = new Label();
            ((System.ComponentModel.ISupportInitialize)rateTremolo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depthTremolo).BeginInit();
            SuspendLayout();
            // 
            // buttonONTremolo
            // 
            buttonONTremolo.BackColor = Color.DarkGray;
            buttonONTremolo.Cursor = Cursors.Hand;
            buttonONTremolo.Location = new Point(243, 58);
            buttonONTremolo.Name = "buttonONTremolo";
            buttonONTremolo.Size = new Size(51, 40);
            buttonONTremolo.TabIndex = 2;
            buttonONTremolo.Text = "OFF";
            buttonONTremolo.UseVisualStyleBackColor = false;
            buttonONTremolo.Click += buttonONTremolo_Click;
            // 
            // rateTremolo
            // 
            rateTremolo.BackColor = Color.FromArgb(59, 60, 61);
            rateTremolo.Cursor = Cursors.Hand;
            rateTremolo.Location = new Point(129, 138);
            rateTremolo.Name = "rateTremolo";
            rateTremolo.Size = new Size(98, 56);
            rateTremolo.TabIndex = 12;
            rateTremolo.Scroll += rateTremolo_Scroll;
            // 
            // labelRateTremolo
            // 
            labelRateTremolo.AutoSize = true;
            labelRateTremolo.BackColor = Color.FromArgb(59, 60, 61);
            labelRateTremolo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelRateTremolo.ForeColor = Color.WhiteSmoke;
            labelRateTremolo.Location = new Point(158, 112);
            labelRateTremolo.Name = "labelRateTremolo";
            labelRateTremolo.Size = new Size(46, 23);
            labelRateTremolo.TabIndex = 13;
            labelRateTremolo.Text = "Rate";
            // 
            // labelDepthTremolo
            // 
            labelDepthTremolo.AutoSize = true;
            labelDepthTremolo.BackColor = Color.FromArgb(59, 60, 61);
            labelDepthTremolo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelDepthTremolo.ForeColor = Color.WhiteSmoke;
            labelDepthTremolo.Location = new Point(317, 112);
            labelDepthTremolo.Name = "labelDepthTremolo";
            labelDepthTremolo.Size = new Size(60, 23);
            labelDepthTremolo.TabIndex = 14;
            labelDepthTremolo.Text = "Depth";
            // 
            // depthTremolo
            // 
            depthTremolo.BackColor = Color.FromArgb(59, 60, 61);
            depthTremolo.Cursor = Cursors.Hand;
            depthTremolo.Location = new Point(296, 138);
            depthTremolo.Name = "depthTremolo";
            depthTremolo.Size = new Size(98, 56);
            depthTremolo.TabIndex = 15;
            depthTremolo.Scroll += depthTremolo_Scroll;
            // 
            // labelValueTremoloRate
            // 
            labelValueTremoloRate.AutoSize = true;
            labelValueTremoloRate.BackColor = Color.FromArgb(59, 60, 61);
            labelValueTremoloRate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueTremoloRate.ForeColor = Color.WhiteSmoke;
            labelValueTremoloRate.Location = new Point(168, 180);
            labelValueTremoloRate.Name = "labelValueTremoloRate";
            labelValueTremoloRate.Size = new Size(20, 23);
            labelValueTremoloRate.TabIndex = 31;
            labelValueTremoloRate.Text = "1";
            // 
            // labelValueTremoloDepth
            // 
            labelValueTremoloDepth.AutoSize = true;
            labelValueTremoloDepth.BackColor = Color.FromArgb(59, 60, 61);
            labelValueTremoloDepth.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            labelValueTremoloDepth.ForeColor = Color.WhiteSmoke;
            labelValueTremoloDepth.Location = new Point(334, 180);
            labelValueTremoloDepth.Name = "labelValueTremoloDepth";
            labelValueTremoloDepth.Size = new Size(20, 23);
            labelValueTremoloDepth.TabIndex = 32;
            labelValueTremoloDepth.Text = "0";
            // 
            // TremoloUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(531, 731);
            Controls.Add(labelValueTremoloDepth);
            Controls.Add(labelValueTremoloRate);
            Controls.Add(depthTremolo);
            Controls.Add(labelDepthTremolo);
            Controls.Add(labelRateTremolo);
            Controls.Add(rateTremolo);
            Controls.Add(buttonONTremolo);
            DoubleBuffered = true;
            Name = "TremoloUI";
            Text = "Tremolo";
            ((System.ComponentModel.ISupportInitialize)rateTremolo).EndInit();
            ((System.ComponentModel.ISupportInitialize)depthTremolo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonONTremolo;
        private TrackBar rateTremolo;
        private Label labelRateTremolo;
        private Label labelDepthTremolo;
        private TrackBar depthTremolo;
        private Label labelValueTremoloRate;
        private Label labelValueTremoloDepth;
    }
}