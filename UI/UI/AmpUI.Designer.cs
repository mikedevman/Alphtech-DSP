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
            labelVolume = new Label();
            labelGain = new Label();
            labelTreble = new Label();
            labelMid = new Label();
            labelBass = new Label();
            Volume = new TrackBar();
            Bass = new TrackBar();
            Gain = new TrackBar();
            Treble = new TrackBar();
            Mid = new TrackBar();
            addEffectslabel = new TextBox();
            buttonDelay = new Button();
            buttonChorus = new Button();
            loadBackingTrack = new Button();
            labelLoadedFile = new TextBox();
            playBackingTrack = new Button();
            volumeBackingTrack = new TrackBar();
            labelBackingTrackVolume = new TextBox();
            buttonTremolo = new Button();
            buttonOverdrive = new Button();
            buttonDistortion = new Button();
            record = new Button();
            choosePreset = new ComboBox();
            labelChoosePreset = new TextBox();
            buttonSaveCustomPreset = new Button();
            buttonLoadCustomPreset = new Button();
            labelVolumeValue = new Label();
            labelGainValue = new Label();
            labelTrebleValue = new Label();
            labelMidValue = new Label();
            labelBassValue = new Label();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Treble).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Mid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)volumeBackingTrack).BeginInit();
            SuspendLayout();
            // 
            // buttonON
            // 
            buttonON.BackColor = Color.DarkGray;
            buttonON.Cursor = Cursors.Hand;
            buttonON.Location = new Point(1013, 104);
            buttonON.Name = "buttonON";
            buttonON.Size = new Size(51, 40);
            buttonON.TabIndex = 0;
            buttonON.Text = "OFF";
            buttonON.UseVisualStyleBackColor = false;
            buttonON.Click += buttonON_Click;
            // 
            // labelVolume
            // 
            labelVolume.AutoSize = true;
            labelVolume.BackColor = SystemColors.InactiveCaptionText;
            labelVolume.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelVolume.ForeColor = Color.WhiteSmoke;
            labelVolume.Location = new Point(135, 132);
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
            labelGain.Location = new Point(262, 132);
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
            labelTreble.Location = new Point(388, 132);
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
            labelMid.Location = new Point(515, 133);
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
            labelBass.Location = new Point(642, 132);
            labelBass.Name = "labelBass";
            labelBass.Size = new Size(44, 23);
            labelBass.TabIndex = 10;
            labelBass.Text = "Bass";
            // 
            // Volume
            // 
            Volume.BackColor = SystemColors.InactiveCaptionText;
            Volume.Cursor = Cursors.Hand;
            Volume.Location = new Point(126, 99);
            Volume.Name = "Volume";
            Volume.Size = new Size(130, 56);
            Volume.TabIndex = 11;
            Volume.Scroll += Volume_Scroll;
            // 
            // Bass
            // 
            Bass.BackColor = SystemColors.InactiveCaptionText;
            Bass.Cursor = Cursors.Hand;
            Bass.Location = new Point(629, 99);
            Bass.Name = "Bass";
            Bass.Size = new Size(130, 56);
            Bass.TabIndex = 12;
            Bass.Scroll += Bass_Scroll;
            // 
            // Gain
            // 
            Gain.BackColor = SystemColors.InactiveCaptionText;
            Gain.Cursor = Cursors.Hand;
            Gain.Location = new Point(252, 99);
            Gain.Name = "Gain";
            Gain.Size = new Size(130, 56);
            Gain.TabIndex = 14;
            Gain.Scroll += Gain_Scroll;
            // 
            // Treble
            // 
            Treble.BackColor = SystemColors.InactiveCaptionText;
            Treble.Cursor = Cursors.Hand;
            Treble.Location = new Point(379, 99);
            Treble.Name = "Treble";
            Treble.Size = new Size(130, 56);
            Treble.TabIndex = 15;
            Treble.Scroll += Treble_Scroll;
            // 
            // Mid
            // 
            Mid.BackColor = SystemColors.InactiveCaptionText;
            Mid.Cursor = Cursors.Hand;
            Mid.Location = new Point(506, 99);
            Mid.Name = "Mid";
            Mid.Size = new Size(130, 56);
            Mid.TabIndex = 16;
            Mid.Scroll += Mid_Scroll;
            // 
            // addEffectslabel
            // 
            addEffectslabel.BackColor = Color.DimGray;
            addEffectslabel.BorderStyle = BorderStyle.None;
            addEffectslabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            addEffectslabel.ForeColor = Color.White;
            addEffectslabel.Location = new Point(12, 856);
            addEffectslabel.Name = "addEffectslabel";
            addEffectslabel.Size = new Size(135, 31);
            addEffectslabel.TabIndex = 17;
            addEffectslabel.Text = "Add Effects:";
            // 
            // buttonDelay
            // 
            buttonDelay.BackColor = Color.FromArgb(212, 204, 188);
            buttonDelay.Cursor = Cursors.Hand;
            buttonDelay.Location = new Point(153, 851);
            buttonDelay.Name = "buttonDelay";
            buttonDelay.Size = new Size(94, 48);
            buttonDelay.TabIndex = 18;
            buttonDelay.Text = "Delay";
            buttonDelay.UseVisualStyleBackColor = false;
            buttonDelay.Click += buttonDelay_Click;
            // 
            // buttonChorus
            // 
            buttonChorus.BackColor = Color.FromArgb(48, 164, 196);
            buttonChorus.Cursor = Cursors.Hand;
            buttonChorus.Location = new Point(253, 851);
            buttonChorus.Name = "buttonChorus";
            buttonChorus.Size = new Size(94, 48);
            buttonChorus.TabIndex = 20;
            buttonChorus.Text = "Chorus";
            buttonChorus.UseVisualStyleBackColor = false;
            buttonChorus.Click += buttonChorus_Click;
            // 
            // loadBackingTrack
            // 
            loadBackingTrack.BackColor = Color.DarkGray;
            loadBackingTrack.Cursor = Cursors.Hand;
            loadBackingTrack.Location = new Point(528, 844);
            loadBackingTrack.Name = "loadBackingTrack";
            loadBackingTrack.Size = new Size(117, 62);
            loadBackingTrack.TabIndex = 21;
            loadBackingTrack.Text = "Load Backing Track";
            loadBackingTrack.UseVisualStyleBackColor = false;
            loadBackingTrack.Click += loadBackingTrack_Click;
            // 
            // labelLoadedFile
            // 
            labelLoadedFile.BackColor = Color.DimGray;
            labelLoadedFile.BorderStyle = BorderStyle.None;
            labelLoadedFile.Font = new Font("Segoe UI", 10F);
            labelLoadedFile.ForeColor = Color.White;
            labelLoadedFile.Location = new Point(528, 912);
            labelLoadedFile.Name = "labelLoadedFile";
            labelLoadedFile.Size = new Size(703, 23);
            labelLoadedFile.TabIndex = 22;
            labelLoadedFile.TextChanged += labelLoadedFile_TextChanged;
            // 
            // playBackingTrack
            // 
            playBackingTrack.BackColor = Color.LightGreen;
            playBackingTrack.Cursor = Cursors.Hand;
            playBackingTrack.Location = new Point(651, 844);
            playBackingTrack.Name = "playBackingTrack";
            playBackingTrack.Size = new Size(73, 62);
            playBackingTrack.TabIndex = 23;
            playBackingTrack.Text = "Play";
            playBackingTrack.UseVisualStyleBackColor = false;
            playBackingTrack.Click += playBackingTrack_Click;
            // 
            // volumeBackingTrack
            // 
            volumeBackingTrack.Cursor = Cursors.Hand;
            volumeBackingTrack.Location = new Point(752, 843);
            volumeBackingTrack.Name = "volumeBackingTrack";
            volumeBackingTrack.Size = new Size(130, 56);
            volumeBackingTrack.TabIndex = 24;
            volumeBackingTrack.Scroll += volumeBackingTrack_Scroll;
            // 
            // labelBackingTrackVolume
            // 
            labelBackingTrackVolume.BackColor = Color.DimGray;
            labelBackingTrackVolume.BorderStyle = BorderStyle.None;
            labelBackingTrackVolume.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelBackingTrackVolume.ForeColor = Color.White;
            labelBackingTrackVolume.Location = new Point(730, 883);
            labelBackingTrackVolume.Name = "labelBackingTrackVolume";
            labelBackingTrackVolume.Size = new Size(703, 23);
            labelBackingTrackVolume.TabIndex = 25;
            labelBackingTrackVolume.Text = "Backing Track's Volume";
            // 
            // buttonTremolo
            // 
            buttonTremolo.BackColor = Color.FromArgb(12, 124, 132);
            buttonTremolo.Cursor = Cursors.Hand;
            buttonTremolo.Location = new Point(353, 851);
            buttonTremolo.Name = "buttonTremolo";
            buttonTremolo.Size = new Size(94, 48);
            buttonTremolo.TabIndex = 26;
            buttonTremolo.Text = "Tremolo";
            buttonTremolo.UseVisualStyleBackColor = false;
            buttonTremolo.Click += buttonTremolo_Click;
            // 
            // buttonOverdrive
            // 
            buttonOverdrive.BackColor = Color.FromArgb(252, 204, 92);
            buttonOverdrive.Cursor = Cursors.Hand;
            buttonOverdrive.Location = new Point(201, 905);
            buttonOverdrive.Name = "buttonOverdrive";
            buttonOverdrive.Size = new Size(94, 48);
            buttonOverdrive.TabIndex = 27;
            buttonOverdrive.Text = "Overdrive";
            buttonOverdrive.UseVisualStyleBackColor = false;
            buttonOverdrive.Click += buttonOverdrive_Click;
            // 
            // buttonDistortion
            // 
            buttonDistortion.BackColor = Color.FromArgb(232, 116, 36);
            buttonDistortion.Cursor = Cursors.Hand;
            buttonDistortion.Location = new Point(304, 905);
            buttonDistortion.Name = "buttonDistortion";
            buttonDistortion.Size = new Size(94, 48);
            buttonDistortion.TabIndex = 28;
            buttonDistortion.Text = "Distortion";
            buttonDistortion.UseVisualStyleBackColor = false;
            buttonDistortion.Click += buttonDistortion_Click;
            // 
            // record
            // 
            record.BackColor = Color.DarkGray;
            record.Cursor = Cursors.Hand;
            record.Location = new Point(1036, 843);
            record.Name = "record";
            record.Size = new Size(98, 55);
            record.TabIndex = 29;
            record.Text = "Record";
            record.UseVisualStyleBackColor = false;
            record.Click += record_Click;
            // 
            // choosePreset
            // 
            choosePreset.FormattingEnabled = true;
            choosePreset.Location = new Point(1146, 174);
            choosePreset.Name = "choosePreset";
            choosePreset.Size = new Size(151, 28);
            choosePreset.TabIndex = 30;
            choosePreset.SelectedIndexChanged += choosePreset_SelectedIndexChanged;
            // 
            // labelChoosePreset
            // 
            labelChoosePreset.BackColor = Color.DimGray;
            labelChoosePreset.BorderStyle = BorderStyle.None;
            labelChoosePreset.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelChoosePreset.ForeColor = Color.White;
            labelChoosePreset.Location = new Point(1146, 145);
            labelChoosePreset.Name = "labelChoosePreset";
            labelChoosePreset.Size = new Size(201, 23);
            labelChoosePreset.TabIndex = 31;
            labelChoosePreset.Text = "Choose Amp Preset";
            // 
            // buttonSaveCustomPreset
            // 
            buttonSaveCustomPreset.BackColor = Color.DarkGray;
            buttonSaveCustomPreset.Cursor = Cursors.Hand;
            buttonSaveCustomPreset.Location = new Point(1157, 236);
            buttonSaveCustomPreset.Name = "buttonSaveCustomPreset";
            buttonSaveCustomPreset.Size = new Size(123, 55);
            buttonSaveCustomPreset.TabIndex = 32;
            buttonSaveCustomPreset.Text = "Save Custom Amp Preset";
            buttonSaveCustomPreset.UseVisualStyleBackColor = false;
            buttonSaveCustomPreset.Click += buttonSavePreset_Click;
            // 
            // buttonLoadCustomPreset
            // 
            buttonLoadCustomPreset.BackColor = Color.DarkGray;
            buttonLoadCustomPreset.Cursor = Cursors.Hand;
            buttonLoadCustomPreset.Location = new Point(1157, 297);
            buttonLoadCustomPreset.Name = "buttonLoadCustomPreset";
            buttonLoadCustomPreset.Size = new Size(123, 55);
            buttonLoadCustomPreset.TabIndex = 33;
            buttonLoadCustomPreset.Text = "Load Custom Amp Preset";
            buttonLoadCustomPreset.UseVisualStyleBackColor = false;
            buttonLoadCustomPreset.Click += buttonLoadCustomPreset_Click;
            // 
            // labelVolumeValue
            // 
            labelVolumeValue.AutoSize = true;
            labelVolumeValue.BackColor = SystemColors.InactiveCaptionText;
            labelVolumeValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelVolumeValue.ForeColor = Color.WhiteSmoke;
            labelVolumeValue.Location = new Point(201, 133);
            labelVolumeValue.Name = "labelVolumeValue";
            labelVolumeValue.Size = new Size(20, 23);
            labelVolumeValue.TabIndex = 34;
            labelVolumeValue.Text = "0";
            // 
            // labelGainValue
            // 
            labelGainValue.AutoSize = true;
            labelGainValue.BackColor = SystemColors.InactiveCaptionText;
            labelGainValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelGainValue.ForeColor = Color.WhiteSmoke;
            labelGainValue.Location = new Point(304, 133);
            labelGainValue.Name = "labelGainValue";
            labelGainValue.Size = new Size(20, 23);
            labelGainValue.TabIndex = 35;
            labelGainValue.Text = "0";
            // 
            // labelTrebleValue
            // 
            labelTrebleValue.AutoSize = true;
            labelTrebleValue.BackColor = SystemColors.InactiveCaptionText;
            labelTrebleValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelTrebleValue.ForeColor = Color.WhiteSmoke;
            labelTrebleValue.Location = new Point(445, 133);
            labelTrebleValue.Name = "labelTrebleValue";
            labelTrebleValue.Size = new Size(20, 23);
            labelTrebleValue.TabIndex = 36;
            labelTrebleValue.Text = "0";
            // 
            // labelMidValue
            // 
            labelMidValue.AutoSize = true;
            labelMidValue.BackColor = SystemColors.InactiveCaptionText;
            labelMidValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelMidValue.ForeColor = Color.WhiteSmoke;
            labelMidValue.Location = new Point(554, 133);
            labelMidValue.Name = "labelMidValue";
            labelMidValue.Size = new Size(20, 23);
            labelMidValue.TabIndex = 37;
            labelMidValue.Text = "0";
            // 
            // labelBassValue
            // 
            labelBassValue.AutoSize = true;
            labelBassValue.BackColor = SystemColors.InactiveCaptionText;
            labelBassValue.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            labelBassValue.ForeColor = Color.WhiteSmoke;
            labelBassValue.Location = new Point(683, 133);
            labelBassValue.Name = "labelBassValue";
            labelBassValue.Size = new Size(20, 23);
            labelBassValue.TabIndex = 38;
            labelBassValue.Text = "0";
            // 
            // AmpUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.DimGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1307, 959);
            Controls.Add(labelBassValue);
            Controls.Add(labelMidValue);
            Controls.Add(labelTrebleValue);
            Controls.Add(labelGainValue);
            Controls.Add(labelVolumeValue);
            Controls.Add(buttonLoadCustomPreset);
            Controls.Add(buttonSaveCustomPreset);
            Controls.Add(labelChoosePreset);
            Controls.Add(choosePreset);
            Controls.Add(record);
            Controls.Add(buttonDistortion);
            Controls.Add(buttonOverdrive);
            Controls.Add(buttonTremolo);
            Controls.Add(labelBackingTrackVolume);
            Controls.Add(volumeBackingTrack);
            Controls.Add(playBackingTrack);
            Controls.Add(labelLoadedFile);
            Controls.Add(loadBackingTrack);
            Controls.Add(buttonChorus);
            Controls.Add(buttonDelay);
            Controls.Add(addEffectslabel);
            Controls.Add(labelVolume);
            Controls.Add(labelBass);
            Controls.Add(labelMid);
            Controls.Add(labelTreble);
            Controls.Add(labelGain);
            Controls.Add(buttonON);
            Controls.Add(Volume);
            Controls.Add(Gain);
            Controls.Add(Treble);
            Controls.Add(Mid);
            Controls.Add(Bass);
            DoubleBuffered = true;
            Name = "AmpUI";
            Text = "Alphtech DSP";
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bass).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gain).EndInit();
            ((System.ComponentModel.ISupportInitialize)Treble).EndInit();
            ((System.ComponentModel.ISupportInitialize)Mid).EndInit();
            ((System.ComponentModel.ISupportInitialize)volumeBackingTrack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonON;
        private Label labelVolume;
        private Label labelGain;
        private Label labelTreble;
        private Label labelMid;
        private Label labelBass;
        private TrackBar Volume;
        private TrackBar Bass;
        private TrackBar Gain;
        private TrackBar Treble;
        private TrackBar Mid;
        private TextBox addEffectslabel;
        private Button buttonDelay;
        private Button buttonChorus;
        private Button loadBackingTrack;
        private TextBox labelLoadedFile;
        private Button playBackingTrack;
        private TrackBar volumeBackingTrack;
        private TextBox labelBackingTrackVolume;
        private Button buttonTremolo;
        private Button buttonOverdrive;
        private Button buttonDistortion;
        private Button record;
        private ComboBox choosePreset;
        private TextBox labelChoosePreset;
        private Button buttonSaveCustomPreset;
        private Button buttonLoadCustomPreset;
        private Label labelVolumeValue;
        private Label labelGainValue;
        private Label labelTrebleValue;
        private Label labelMidValue;
        private Label labelBassValue;
    }
}
