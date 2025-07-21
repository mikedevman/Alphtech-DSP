using AlphtechDSP;

namespace UI
{
    public partial class DistortionUI : Form
    {
        private Amp amp;
        private bool isDistortionOn = false;
        private float distortionLevel = 1.0f;
        public DistortionUI(Amp ampInstance)
        {
            InitializeComponent();
            amp = ampInstance;
            Gain.Minimum = 10;
            Gain.Maximum = 1000;
            Gain.Value = 100;

            float baseGain = Gain.Value / 100.0f;
            amp.SetBaseGain(baseGain);
        }

        private void buttonONDistortion_Click(object sender, EventArgs e)
        {
            if (isDistortionOn == false)
            {
                isDistortionOn = true;
                amp.SetDistortionLevel(distortionLevel);
                amp.EnableDistortion(true);
                buttonONDistortion.BackColor = Color.Red;
                buttonONDistortion.Text = "ON";
            }
            else
            {
                isDistortionOn = false;
                amp.EnableDistortion(false);
                buttonONDistortion.BackColor = Color.DarkGray;
                buttonONDistortion.Text = "OFF";
            }

        }

        private void Gain_Scroll(object sender, EventArgs e)
        {
            float gainValue = Gain.Value / 100.0f;

            if (isDistortionOn)
            {
                distortionLevel = gainValue;
                amp.SetDistortionLevel(distortionLevel);
            }
            else
            {
                amp.SetBaseGain(gainValue);
            }
        }

        private void DistortionUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isDistortionOn)
            {
                amp.EnableDistortion(false);
                isDistortionOn = false;
            }
        }
    }
}
