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

            timeDelay.Minimum = 1;
            timeDelay.Maximum = 50;
            timeDelay.Value = 1;

            mixDelay.Minimum = 0;
            mixDelay.Maximum = 100;
            mixDelay.Value = 0;

            feedbackDelay.Minimum = 0;
            feedbackDelay.Maximum = 99;
            feedbackDelay.Value = 0;

            this.FormClosing += DelayUI_FormClosing;
        }

        private void DelayUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (delay != null && isDelayOn)
            {
                delay.SetEnabled(false);
                isDelayOn = false;
            }
        }

        public void SetDelay(Delay delayEffect)
        {
            delay = delayEffect;
        }

        private void buttonONDelay_Click(object sender, EventArgs e)
        {
            if (!isDelayOn)
            {
                UpdateDelaySettings();
                if (delay != null)
                {
                    delay.SetEnabled(true);
                }
                buttonONDelay.BackColor = Color.Red;
                buttonONDelay.Text = "ON";
                isDelayOn = true;
            }
            else
            {
                if (delay != null)
                {
                    delay.SetEnabled(false);
                }
                buttonONDelay.BackColor = Color.DarkGray;
                buttonONDelay.Text = "OFF";
                isDelayOn = false;
            }
        }

        private void UpdateDelaySettings()
        {
            if (delay != null)
            {
                delay.SetDelay(timeDelay.Value / 10.0f);
                delay.SetMix(mixDelay.Value / 100.0f);
                delay.SetFeedback(feedbackDelay.Value / 100.0f);
            }
        }

        
        private void timeDelay_Scroll(object sender, EventArgs e)
        {
            if (delay != null)
            {
                delay.SetDelay(timeDelay.Value / 10.0f);
            }
            labelValueDelayTime.Text = timeDelay.Value.ToString();
        }

        private void mixDelay_Scroll(object sender, EventArgs e)
        {
            if (delay != null)
            {
                delay.SetMix(mixDelay.Value / 100.0f);
            }
            labelValueDelayMix.Text = mixDelay.Value.ToString();
        }

        private void feedbackDelay_Scroll(object sender, EventArgs e)
        {
            if (delay != null)
            {
                delay.SetFeedback(feedbackDelay.Value / 100.0f);
            }
            labelValueDelayFeedback.Text = feedbackDelay.Value.ToString();
        }
    }
}