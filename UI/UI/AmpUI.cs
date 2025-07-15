using AlphtechDSP;
using NAudio.Wave;
namespace UI
{
    public partial class AmpUI : Form
    {
        private bool isPoweredOn = false;
        private AudioProcessing audio;
        private Amp amp;
        private DelayUI delayWindow;
        private ChorusUI chorusWindow;
        private TremoloUI tremoloWindow;
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

        private void buttonON_Click(object sender, EventArgs e)
        {
            if (isPoweredOn == false)
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

                audio = new AudioProcessing();
                amp = audio.GetAmp();
                UpdateAmpSettings();

                Delay delay = audio.GetDelay();
                delay.SetEnabled(delayWasEnabled);

                Chorus chorus = audio.GetChorus();
                chorus.SetEnabled(chorusWasEnabled);

                Tremolo tremolo = audio.GetTremolo();
                tremolo.SetEnabled(tremoloWasEnabled);

                audio.Start();
                buttonON.BackColor = Color.Red;
                buttonON.Text = "ON";
                isPoweredOn = true;

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

                audio.Stop();
                audio.Dispose();
                buttonON.BackColor = Color.DarkGray;
                buttonON.Text = "OFF";
                isPoweredOn = false;
            }
        }

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

        private void Volume_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetVolume(Volume.Value / 100f);
            }
        }

        private void Gain_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetGain(Gain.Value / 100f);
            }
        }

        private void Treble_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetTreble(Treble.Value / 100f);
            }
        }

        private void Mid_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetMid(Mid.Value / 100f);
            }
        }

        private void Bass_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                amp.SetBass(Bass.Value / 100f);
            }
        }

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

        private void loadBackingTrack_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "WAV files (*.wav) |*.wav;";
            openFileDialog.InitialDirectory = @"C:\Users\Admin\Documents\Alphtech DSP\Alphtech DSP\backing tracks";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    outputDevice.Dispose();
                    outputDevice = null;
                    playBackingTrack.BackColor = Color.LightGreen;
                    playBackingTrack.Text = "Play";
                }
                selectedFilePath = openFileDialog.FileName;
                labelLoadedFile.Text = Path.GetFileName(selectedFilePath);
            }
        }

        private void labelLoadedFile_TextChanged(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null && !string.IsNullOrEmpty(label.Text))
            {
                string filename = Path.GetFileName(label.Text);
                label.Text = $"{filename}";
            }
        }

        private void playBackingTrack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                return;
            }

            try
            {
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

        private void volumeBackingTrack_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null && audioFile != null)
            {
                float volume = volumeBackingTrack.Value / 100f;
                audioFile.Volume = volume;
            }
        }
    }
}