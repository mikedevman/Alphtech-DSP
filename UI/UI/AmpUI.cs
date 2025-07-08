using AlphtechDSP;

namespace UI
{
    public partial class AmpUI : Form
    {
        private bool isPoweredOn = false;
        private AudioProcessing audio;
        private Amp amp;

        public AmpUI()
        {
            InitializeComponent();
            Volume = new CustomTrackBar();
            Gain = new CustomTrackBar();
            Treble = new CustomTrackBar();
            Mid = new CustomTrackBar();
            Bass = new CustomTrackBar();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            if (!isPoweredOn)
            {
                audio = new AudioProcessing();
                amp = audio.GetAmp();
                audio.Start();
                buttonON.BackColor = Color.Red;
                buttonON.Text = "ON";
                isPoweredOn = true;
            }
            else
            {
                audio.Stop();
                audio.Dispose();
                buttonON.BackColor = Color.DarkGray;
                buttonON.Text = "OFF";
                isPoweredOn = false;
            }
        }

        private void Volume_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                float volume = Volume.Value / 50.0f;
                amp.SetVolume(volume);
            }
        }

        private void Gain_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                float gain = Gain.Value / 50.0f;
                amp.SetVolume(gain);
            }
        }

        private void Treble_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                float treble = Treble.Value / 50.0f;
                amp.SetTreble(treble);
            }
        }

        private void Mid_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                float mid = Mid.Value / 50.0f;
                amp.SetMid(mid);
            }
        }

        private void Bass_Scroll(object sender, EventArgs e)
        {
            if (amp != null)
            {
                float bass = Bass.Value / 50.0f;
                amp.SetBass(bass);
            }
        }
    }
}
