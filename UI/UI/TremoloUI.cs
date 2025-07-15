using AlphtechDSP;

namespace UI
{
    public partial class TremoloUI : Form
    {
        private bool isTremoloOn = false;
        private Tremolo tremolo;
        public TremoloUI()
        {
            InitializeComponent();

            rateTremolo.Minimum = 1;
            rateTremolo.Maximum = 20;
            rateTremolo.Value = 5;

            depthTremolo.Minimum = 0;
            depthTremolo.Maximum = 100;
            depthTremolo.Value = 50;

            this.FormClosing += Tremolo_FormClosing;
        }

        private void Tremolo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tremolo != null && isTremoloOn)
            {
                tremolo.SetEnabled(false);
                isTremoloOn = false;
            }
        }

        public void SetTremolo(Tremolo tremoloEffect)
        {
            tremolo = tremoloEffect;
        }

        private void buttonONTremolo_Click(object sender, EventArgs e)
        {
            if (!isTremoloOn)
            {
                UpdateTremoloSettings();
                if (tremolo != null)
                {
                    tremolo.SetEnabled(true);
                }
                buttonONTremolo.BackColor = Color.Red;
                buttonONTremolo.Text = "ON";
                isTremoloOn = true;
            }
            else
            {
                if (tremolo != null)
                {
                    tremolo.SetEnabled(false);
                }
                buttonONTremolo.BackColor = Color.DarkGray;
                buttonONTremolo.Text = "OFF";
                isTremoloOn = false;
            }
        }

        private void UpdateTremoloSettings()
        {
            if (tremolo != null)
            {
                tremolo.SetRate(rateTremolo.Value / 20.0f);
                tremolo.SetDepth(depthTremolo.Value / 100.0f);
            }
        }

        private void rateTremolo_Scroll(object sender, EventArgs e)
        {
            if (tremolo != null)
            {
                tremolo.SetRate(rateTremolo.Value / 20.0f);
            }
        }

        private void depthTremolo_Scroll(object sender, EventArgs e)
        {
            if (tremolo != null)
            {
                tremolo.SetDepth(depthTremolo.Value / 100.0f);
            }
        }
    }
}