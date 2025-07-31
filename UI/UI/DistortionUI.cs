using AlphtechDSP;

namespace UI
{
    public partial class DistortionUI : Form
    {
        private GainEffect gainEffect;
        private bool isDistortionOn = false;
        private float distortionGain = 0.1f;

        public DistortionUI(GainEffect gainEffectInstance)
        {
            InitializeComponent();
            gainEffect = gainEffectInstance;
            Gain.Minimum = 10;
            Gain.Maximum = 1000;
            Gain.Value = 10;

        }

        private void buttonONDistortion_Click(object sender, EventArgs e)
        {
            if (!isDistortionOn)
            {
                isDistortionOn = true;
                gainEffect.EnableDistortion(true);
                gainEffect.SetDistortionGain(distortionGain);
                buttonONDistortion.BackColor = Color.Red;
                buttonONDistortion.Text = "ON";
            }
            else
            {
                isDistortionOn = false;
                gainEffect.EnableDistortion(false);
                buttonONDistortion.BackColor = Color.DarkGray;
                buttonONDistortion.Text = "OFF";
            }

        }

        private void Gain_Scroll(object sender, EventArgs e)
        {
            float gainValue = Gain.Value / 100.0f;
            if (isDistortionOn)
            {
                distortionGain = gainValue;
                gainEffect.SetDistortionGain(distortionGain);
            }
            else
            {
                distortionGain = 0.0f;
            }
            labelValueDistortionGain.Text = gainValue.ToString();
        }

        private void DistortionUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDistortionOn)
            {
                gainEffect.EnableDistortion(false);
                gainEffect.SetDistortionGain(0.0f);
                isDistortionOn = false;
            }
        }
    }
}
