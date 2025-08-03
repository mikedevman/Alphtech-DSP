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

            chorusMix.Minimum = 0;
            chorusMix.Maximum = 100;
            chorusMix.Value = 0;

            chorusFeedback.Minimum = 0;
            chorusFeedback.Maximum = 90;
            chorusFeedback.Value = 0;

            chorusRate.Minimum = 1;
            chorusRate.Maximum = 50;
            chorusRate.Value = 1;

            chorusDepth.Minimum = 0;
            chorusDepth.Maximum = 100;
            chorusDepth.Value = 0;

            chorusBaseDelay.Minimum = 10;
            chorusBaseDelay.Maximum = 200;
            chorusBaseDelay.Value = 10;

            this.FormClosing += ChorusUI_FormClosing;
        }

        // close chorus UI and disable chorus effect 
        private void ChorusUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chorus != null && isChorusOn)
            {
                chorus.SetEnabled(false);
            }
        }

        // set chorus effect
        public void SetChorus(Chorus chorusEffect)
        {
            chorus = chorusEffect;
            if (chorus != null)
            {
                isChorusOn = chorus.GetEnabled();
                UpdateUI();
            }
        }

        // update UI based on chorus state
        private void UpdateUI()
        {
            if (isChorusOn)
            {
                buttonONChorus.BackColor = Color.Red;
                buttonONChorus.Text = "ON";
            }
            else
            {
                buttonONChorus.BackColor = Color.DarkGray;
                buttonONChorus.Text = "OFF";
            }
        }

        // toggle chorus effect on or off
        private void buttonONChorus_Click(object sender, EventArgs e)
        {
            if (isChorusOn == false)
            {
                if (chorus != null)
                {
                    chorus.SetEnabled(true);
                    isChorusOn = true;
                    UpdateUI();
                }
            }
            else
            {
                if (chorus != null)
                {
                    chorus.SetEnabled(false);
                    isChorusOn = false;
                    UpdateUI();
                }
            }
        }

        // trackbar slider for chorus mix
        private void chorusMix_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetMix(chorusMix.Value / 100f);
            }
            labelValueChorusMix.Text = chorusMix.Value.ToString();
        }

        // trackbar slider for chorus feedback
        private void chorusFeedback_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetFeedback(chorusFeedback.Value / 100f);
            }
            labelValueChorusFeedback.Text = chorusFeedback.Value.ToString();
        }

        // trackbar slider for chorus rate
        private void chorusRate_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetRate(chorusRate.Value / 10f);
            }
            labelValueChorusRate.Text = chorusRate.Value.ToString();
        }

        // trackbar slider for chorus depth
        private void chorusDepth_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetDepth(chorusDepth.Value / 10f);
            }
            labelValueChorusDepth.Text = chorusDepth.Value.ToString();
        }

        // trackbar slider for chorus base delay
        private void chorusBaseDelay_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetBaseDelay(chorusBaseDelay.Value / 10f);
            }
            labelValueChorusBaseDelay.Text = chorusBaseDelay.Value.ToString();
        }
    }
}