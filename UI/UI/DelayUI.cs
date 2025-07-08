using AlphtechDSP;

namespace UI
{
    public partial class DelayUI : Form
    {
        private bool isDelayOn = false;
        private Delay delay;

        public DelayUI()
        {
            InitializeComponent();

            DelayMix = new CustomTrackBar();
            DelayFeedback = new CustomTrackBar();
        }

        public void SetDelay(Delay delayEffect)
        {
            delay = delayEffect;
        }

        private void buttonONDelay_Click(object sender, EventArgs e)
        {
            if (delay != null)
            {
                isDelayOn = !isDelayOn;
                delay.SetEnabled(isDelayOn);

                if (isDelayOn)
                {
                    buttonONDelay.BackColor = Color.LightGreen;
                    buttonONDelay.Text = "ON";
                }
                else
                {
                    buttonONDelay.BackColor = Color.DarkGray;
                    buttonONDelay.Text = "OFF";
                }
            }
        }

        private void DelayMix_Scroll(object sender, EventArgs e)
        {
            if (delay != null)
            {
                float value = (float)DelayMix.Value / 100f;
                delay.SetMix(value);
            }
        }

        private void DelayFeedback_Scroll(object sender, EventArgs e)
        {
            if (delay != null)
            {
                float value = (float)DelayFeedback.Value / 100f;
                delay.SetFeedback(value);
            }
        }
    }
}
