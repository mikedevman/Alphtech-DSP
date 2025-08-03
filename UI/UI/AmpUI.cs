using Alphtech_DSP;
using AlphtechDSP;
using NAudio.Wave;
namespace UI
{
    public partial class AmpUI : Form
    {
        private bool isPoweredOn = false;
        private AudioProcessing audio;
        private Amp amp = new Amp();
        private DelayUI delayWindow;
        private ChorusUI chorusWindow;
        private TremoloUI tremoloWindow;
        private OverdriveUI overdriveWindow;
        private DistortionUI distortionWindow;
        private bool delayWasEnabled = false;
        private bool chorusWasEnabled = false;
        private bool tremoloWasEnabled = false;
        private string selectedFilePath = "";
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private bool isPaused = false;

        public AmpUI()
        {
            InitializeComponent();

            choosePreset.Items.Clear();
            choosePreset.Items.Add("(choose preset)");
            choosePreset.Items.AddRange(Enum.GetNames(typeof(PresetType)));
            choosePreset.SelectedIndex = 0;

            Volume.Minimum = 0;
            Volume.Maximum = 100;
            Volume.Value = 0;

            Gain.Minimum = 0;
            Gain.Maximum = 100;
            Gain.Value = 0;

            Treble.Minimum = 0;
            Treble.Maximum = 100;
            Treble.Value = 0;

            Mid.Minimum = 0;
            Mid.Maximum = 100;
            Mid.Value = 0;

            Bass.Minimum = 0;
            Bass.Maximum = 100;
            Bass.Value = 0;

            volumeBackingTrack.Minimum = 0;
            volumeBackingTrack.Maximum = 100;
            volumeBackingTrack.Value = 75;

            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
        }

        // button to turn the amplifier on or off
        private void buttonON_Click(object sender, EventArgs e)
        {
            if (isPoweredOn == false)
            {
                // if amplifier is on, start effect instances and set the button state
                if (audio != null)
                {
                    Delay currentDelay = audio.GetDelay();
                    delayWasEnabled = currentDelay.GetEnabled();

                    Chorus currentChorus = audio.GetChorus();
                    chorusWasEnabled = currentChorus.GetEnabled();

                    Tremolo currentTremolo = audio.GetTremolo();
                    tremoloWasEnabled = currentTremolo.GetEnabled();
                }

                // create a new AudioProcessing instance and set the amp settings
                audio = new AudioProcessing();
                amp = audio.GetAmp();
                UpdateAmpSettings();

                // create and add effects to the audio processing chain
                Delay delay = audio.GetDelay();
                delay.SetEnabled(delayWasEnabled);

                Chorus chorus = audio.GetChorus();
                chorus.SetEnabled(chorusWasEnabled);

                Tremolo tremolo = audio.GetTremolo();
                tremolo.SetEnabled(tremoloWasEnabled);

                // start the audio processing
                audio.Start();
                buttonON.BackColor = Color.Red;
                buttonON.Text = "ON";
                isPoweredOn = true;

                // update the UI for delay, chorus, and tremolo windows if they are open
                if (delayWindow != null)
                {
                    if (delayWindow.IsDisposed == false)
                    {
                        delayWindow.SetDelay(audio.GetDelay());
                    }
                }

                if (chorusWindow != null)
                {
                    if (chorusWindow.IsDisposed == false)
                    {
                        chorusWindow.SetChorus(audio.GetChorus());
                    }
                }

                if (tremoloWindow != null)
                {
                    if (tremoloWindow.IsDisposed == false)
                    {
                        tremoloWindow.SetTremolo(audio.GetTremolo());
                    }
                }
            }
            else
            {
                if (audio != null)
                {
                    Delay currentDelay = audio.GetDelay();
                    delayWasEnabled = currentDelay.GetEnabled();

                    Chorus currentChorus = audio.GetChorus();
                    chorusWasEnabled = currentChorus.GetEnabled();

                    Tremolo currentTremolo = audio.GetTremolo();
                    tremoloWasEnabled = currentTremolo.GetEnabled();
                }

                // if amplifier is off, stop the audio processing and dispose of the audio instance
                audio.Stop();
                audio.Dispose();
                buttonON.BackColor = Color.DarkGray;
                buttonON.Text = "OFF";
                isPoweredOn = false;
            }
        }

        // update the amplifier settings based on the UI controls
        private void UpdateAmpSettings()
        {
            if (amp != null)
            {
                amp.SetVolume(Volume.Value / 100f);
                amp.SetGain(Gain.Value / 100f);
                amp.SetTreble(Treble.Value / 100f);
                amp.SetMid(Mid.Value / 100f);
                amp.SetBass(Bass.Value / 100f);
            }
        }

        // trackbar scroll for volume
        private void Volume_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetVolume(Volume.Value / 100f);
            }
            labelVolumeValue.Text = Volume.Value.ToString();
        }

        // trackbar scroll for gain
        private void Gain_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetGain(Gain.Value / 100f);
            }
            labelGainValue.Text = Gain.Value.ToString();
        }

        // trackbar scroll for treble
        private void Treble_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetTreble(Treble.Value / 100f);
            }
            labelTrebleValue.Text = Treble.Value.ToString();
        }

        // trackbar scroll for mid
        private void Mid_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetMid(Mid.Value / 100f);
            }
            labelMidValue.Text = Mid.Value.ToString();
        }

        // trackbar scroll for bass
        private void Bass_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetBass(Bass.Value / 100f);
            }
            labelBassValue.Text = Bass.Value.ToString();
        }

        // button to open the delay effect UI
        private void buttonDelay_Click(object sender, EventArgs e)
        {
            if (delayWindow == null)
            {
                delayWindow = new DelayUI();
                delayWindow.Show();
            }
            if (delayWindow.IsDisposed)
            {
                delayWindow = new DelayUI();
            }
            delayWindow.Show();
            delayWindow.BringToFront();
            if (isPoweredOn == true)
            {
                if (audio != null)
                {
                    delayWindow.SetDelay(audio.GetDelay());
                }
            }
        }

        // button to open the chorus effect UI
        private void buttonChorus_Click(object sender, EventArgs e)
        {
            if (chorusWindow == null)
            {
                chorusWindow = new ChorusUI();
                chorusWindow.Show();
            }
            if (chorusWindow.IsDisposed)
            {
                chorusWindow = new ChorusUI();
            }
            chorusWindow.Show();
            chorusWindow.BringToFront();
            if (isPoweredOn == true)
            {
                if (audio != null)
                {
                    chorusWindow.SetChorus(audio.GetChorus());
                }
            }
        }

        // button to open the tremolo effect UI
        private void buttonTremolo_Click(object sender, EventArgs e)
        {
            if (tremoloWindow == null)
            {
                tremoloWindow = new TremoloUI();
                tremoloWindow.Show();
            }
            if (tremoloWindow.IsDisposed)
            {
                tremoloWindow = new TremoloUI();
            }
            tremoloWindow.Show();
            tremoloWindow.BringToFront();
            if (isPoweredOn == true)
            {
                if (audio != null)
                {
                    tremoloWindow.SetTremolo(audio.GetTremolo());
                }
            }
        }

        // button to open the overdrive effect UI
        private void buttonOverdrive_Click(object sender, EventArgs e)
        {
            if (overdriveWindow == null)
            {
                if (audio != null)
                {
                    overdriveWindow = new OverdriveUI(audio.GetGainEffect());
                    overdriveWindow.Show();
                }
            }
            if (overdriveWindow != null && overdriveWindow.IsDisposed)
            {
                overdriveWindow = new OverdriveUI(audio.GetGainEffect());
            }
            if (overdriveWindow != null)
            {
                overdriveWindow.Show();
                overdriveWindow.BringToFront();
            }
        }

        // button to open the distortion effect UI
        private void buttonDistortion_Click(object sender, EventArgs e)
        {
            if (distortionWindow == null)
            {
                if (audio != null)
                {
                    distortionWindow = new DistortionUI(audio.GetGainEffect());
                    distortionWindow.Show();
                }
            }
            if (distortionWindow != null && distortionWindow.IsDisposed)
            {
                distortionWindow = new DistortionUI(audio.GetGainEffect());
            }
            if (distortionWindow != null)
            {
                distortionWindow.Show();
                distortionWindow.BringToFront();
            }
        }

        // button to load a backing track
        private void loadBackingTrack_Click(object sender, EventArgs e)
        {
            // create an OpenFileDialog to select a WAV file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WAV files (*.wav) |*.wav;";
            openFileDialog.InitialDirectory = @"C:\Users\Admin\Documents\Alphtech DSP\Alphtech DSP\backing tracks";

            // show the dialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // if an output device is already playing, stop it and dispose of it
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    outputDevice = null;
                    playBackingTrack.BackColor = Color.LightGreen;
                    playBackingTrack.Text = "Play";
                }

                // select the file and update the label to show the file name
                selectedFilePath = openFileDialog.FileName;
                labelLoadedFile.Text = Path.GetFileName(selectedFilePath);
            }
        }

        // update the label text when the loaded file changes
        private void labelLoadedFile_TextChanged(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null && !string.IsNullOrEmpty(label.Text))
            {
                string filename = Path.GetFileName(label.Text);
                label.Text = $"{filename}";
            }
        }

        // button to play or pause the backing track
        private void playBackingTrack_Click(object sender, EventArgs e)
        {
            // check if a file is selected, if not return
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                return;
            }

            try
            {
                // if the output device is null, create a new AudioFileReader and WaveOutEvent
                Button button = sender as Button;
                if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    outputDevice.Pause();
                    isPaused = true;
                    button.BackColor = Color.LightGreen;
                    button.Text = "Play";
                }
                else if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Paused)
                {
                    outputDevice.Play();
                    isPaused = false;
                    button.BackColor = Color.Gray;
                    button.Text = "Pause";
                }
                else
                {
                    audioFile = new AudioFileReader(selectedFilePath);
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    isPaused = false;

                    button.BackColor = Color.Gray;
                    button.Text = "Pause";
                }
            }
            catch
            {
            }
        }

        // trackbar scroll for backing track volume
        private void volumeBackingTrack_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                if (audioFile != null)
                {
                    float volume = volumeBackingTrack.Value / 100f;
                    audioFile.Volume = volume;
                }
            }
        }

        // button to record audio
        private void record_Click(object sender, EventArgs e)
        {
            if (audio == null)
            {
                return;
            }

            if (!isPoweredOn)
            {
                return;
            }

            // check if the audio is already recording, if not start recording, otherwise stop recording
            if (!audio.IsRecording)
            {
                audio.StartRecording();
                record.Text = "Stop";
                record.BackColor = Color.Red;
            }
            else
            {
                string savedFile = audio.StopRecording();
                record.Text = "Record";
                record.BackColor = Color.DarkGray;

                // show a message box with the saved file path
                System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Admin\Documents\Alphtech DSP\Alphtech DSP\recordings");
            }
        }

        // choose a preset from the dropdown
        private void choosePreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choosePreset.SelectedIndex == 0)
                return;

            string selected = choosePreset.SelectedItem.ToString();
            PresetType type = (PresetType)Enum.Parse(typeof(PresetType), selected);
            Preset preset = Presets.GetPreset(type);

            // apply the selected preset to the amplifier
            amp.LoadState(preset);

            // update the amp UI to reflect the preset changes
            UpdateAmpUIState();
        }

        // update the UI state of the amplifier
        private void UpdateAmpUIState()
        {
            // clamp volume and gain to their respective ranges
            Volume.Value = Math.Clamp((int)(amp.GetVolume() * 100), Volume.Minimum, Volume.Maximum);
            Gain.Value = Math.Clamp((int)(amp.GetGain() * 100), Gain.Minimum, Gain.Maximum);

            Treble.Value = (int)(amp.GetTreble() * 100);
            Mid.Value = (int)(amp.GetMid() * 100);
            Bass.Value = (int)(amp.GetBass() * 100);

            // update the labels to show the current values
            labelVolumeValue.Text = Volume.Value.ToString();
            labelGainValue.Text = Gain.Value.ToString();
            labelTrebleValue.Text = Treble.Value.ToString();
            labelMidValue.Text = Mid.Value.ToString();
            labelBassValue.Text = Bass.Value.ToString();
        }

        // button to save the current preset
        private void buttonSavePreset_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";
            saveFileDialog.Title = "Save Preset";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // create a new preset with the current amplifier settings and save it to a file
                var preset = new Alphtech_DSP.Preset
                {
                    Gain = Gain.Value / 100f,
                    Volume = Volume.Value / 100f,
                    Bass = Bass.Value / 100f,
                    Mid = Mid.Value / 100f,
                    Treble = Treble.Value / 100f
                };
                Alphtech_DSP.Presets.SavePresetToFile(preset, saveFileDialog.FileName);
            }
        }

        // button to load a custom preset from a file
        private void buttonLoadCustomPreset_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Load Preset";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var preset = Alphtech_DSP.Presets.LoadPresetFromFile(openFileDialog.FileName);
                if (preset != null)
                {
                    // load the preset into the amplifier and update the UI state
                    amp.LoadState(preset);
                    UpdateAmpUIState();
                }
            }
        }
    }
}