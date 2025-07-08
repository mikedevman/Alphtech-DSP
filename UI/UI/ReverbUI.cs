using AlphtechDSP;

namespace UI
{
    public partial class ReverbUI : Form
    {
        private bool isReverbOn = false;
        private Reverb reverb;

        public ReverbUI()
        {
            InitializeComponent();

            DelayMix = new CustomTrackBar();
            ReverbFeedback = new CustomTrackBar();
        }

        public void SetReverb(Reverb reverbEffect)
        {
            reverb = reverbEffect;
        }

        private void buttonONReverb_Click(object sender, EventArgs e)
        {
            if (reverb != null)
            {
                isReverbOn = !isReverbOn;
                reverb.SetEnabled(isReverbOn);

                if (isReverbOn)
                {
                    buttonONReverb.BackColor = Color.LightGreen;
                    buttonONReverb.Text = "ON";
                }
                else
                {
                    buttonONReverb.BackColor = Color.DarkGray;
                    buttonONReverb.Text = "OFF";
                }
            }
        }

        private void DelayMix_Scroll(object sender, EventArgs e)
        {
            if (reverb != null)
            {
                float value = (float)DelayMix.Value / 100f;
                reverb.SetMix(value);
            }
        }

        private void ReverbFeedback_Scroll(object sender, EventArgs e)
        {
            if (reverb != null)
            {
                float value = (float)ReverbFeedback.Value / 100f;
                reverb.SetFeedback(value);
            }
        }
    }
}
