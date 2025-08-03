using AlphtechDSP;

namespace UI
{
    public partial class OverdriveUI : Form
    {
        private GainEffect gainEffect;
        private bool isOverdriveOn = false;
        private float overdriveGain = 0.1f;

        public OverdriveUI(GainEffect gainEffectInstance)
        {
            InitializeComponent();
            gainEffect = gainEffectInstance;
            Gain.Minimum = 10;
            Gain.Maximum = 1000;
            Gain.Value = 10;
        }

        // turn overdrive effect on or off
        private void buttonONOverdrive_Click(object sender, EventArgs e)
        {
            if (!isOverdriveOn)
            {
                isOverdriveOn = true;
                gainEffect.EnableOverdrive(true);
                gainEffect.SetOverdriveGain(overdriveGain);
                buttonONOverdrive.BackColor = Color.Red;
                buttonONOverdrive.Text = "ON";
            }
            else
            {
                isOverdriveOn = false;
                gainEffect.EnableOverdrive(false);
                buttonONOverdrive.BackColor = Color.DarkGray;
                buttonONOverdrive.Text = "OFF";
            }
        }

        // trackbar to set overdrive gain
        private void Gain_Scroll(object sender, EventArgs e)
        {
            float gainValue = Gain.Value / 100.0f;
            if (isOverdriveOn)
            {
                overdriveGain = gainValue;
                gainEffect.SetOverdriveGain(overdriveGain);
            }
            else
            {
                overdriveGain = 0.0f;
            }
            labelValueOverdriveGain.Text = gainValue.ToString();
        }

        // close overdrive UI and disable overdrive effect
        private void OverdriveUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOverdriveOn)
            {
                gainEffect.EnableOverdrive(false);
                gainEffect.SetOverdriveGain(0.0f);
                isOverdriveOn = false;
            }
        }
    }
}
