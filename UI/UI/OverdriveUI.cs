using AlphtechDSP;

namespace UI
{
    public partial class OverdriveUI : Form
    {
        private Amp amp;
        private bool isOverdriveOn = false;
        private float overdriveLevel = 1.0f;

        public OverdriveUI(Amp ampInstance)
        {
            InitializeComponent();
            amp = ampInstance;
            Gain.Minimum = 10;    
            Gain.Maximum = 1000;  
            Gain.Value = 100;

            float baseGain = Gain.Value / 100.0f;
            amp.SetBaseGain(baseGain);
        }

        private void buttonONOverdrive_Click(object sender, EventArgs e)
        {
            if (isOverdriveOn == false)
            {
                isOverdriveOn = true;
                amp.SetOverdriveLevel(overdriveLevel); 
                amp.EnableOverdrive(true);
                buttonONOverdrive.BackColor = Color.Red;
                buttonONOverdrive.Text = "ON";
            }
            else
            {
                isOverdriveOn = false;
                amp.EnableOverdrive(false);
                buttonONOverdrive.BackColor = Color.DarkGray;
                buttonONOverdrive.Text = "OFF";
            }
        }

        private void Gain_Scroll(object sender, EventArgs e)
        {
            float gainValue = Gain.Value / 100.0f;

            if (isOverdriveOn)
            {
                overdriveLevel = gainValue; 
                amp.SetOverdriveLevel(overdriveLevel);
            }
            else
            {
                amp.SetBaseGain(gainValue);
            }
            labelValueOverdriveGain.Text = gainValue.ToString();
        }

        private void OverdriveUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isOverdriveOn)
            {
                amp.EnableOverdrive(false);
                isOverdriveOn = false;
            }
        }
    }
}
