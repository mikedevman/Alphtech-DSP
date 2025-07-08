using AlphtechDSP;

namespace UI
{
    public partial class ChorusUI : Form
    {
        private bool isChorusOn = false;
        private Chorus chorus;

        public ChorusUI()
        {
            InitializeComponent();

            ChorusMix = new CustomTrackBar();
            ChorusFeedback = new CustomTrackBar();
            ChorusRate = new CustomTrackBar();
            DepthChorus = new CustomTrackBar();
            BaseDelayChorus = new CustomTrackBar();
        }

        public void SetChorus(Chorus chorusEffect)
        {
            chorus = chorusEffect;
        }

        private void buttonONChorus_Click(object sender, EventArgs e)
        {
            if (!isChorusOn)
            {
                if (chorus != null)
                {
                    chorus.SetEnabled(true);
                    buttonONChorus.BackColor = Color.LightGreen;
                    buttonONChorus.Text = "ON";
                    isChorusOn = true;
                }
            }
            else
            {
                if (chorus != null)
                {
                    chorus.SetEnabled(false);
                    buttonONChorus.BackColor = Color.DarkGray;
                    buttonONChorus.Text = "OFF";
                    isChorusOn = false;
                }
            }
        }

        private void ChorusMix_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                float value = (float)ChorusMix.Value / 100f;
                chorus.SetMix(value);
            }
        }

        private void ChorusFeedback_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                float value = (float)ChorusFeedback.Value / 100f;
                chorus.SetFeedback(value);
            }
        }

        private void ChorusRate_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                float value = (float)ChorusRate.Value / 100f;
                chorus.SetRate(value);
            }
        }

        private void DepthChorus_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                float value = (float)DepthChorus.Value / 100f;
                chorus.SetDepth(value);
            }
        }

        private void BaseDelayChorus_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                float value = (float)BaseDelayChorus.Value; 
                chorus.SetBaseDelay(value);
            }
        }
    }
}
