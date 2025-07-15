//using AlphtechDSP;

//namespace UI
//{
//    public partial class ChorusUI : Form
//    {
//        private bool isChorusOn = false;
//        private Chorus chorus;

//        public ChorusUI()
//        {
//            InitializeComponent();
//        }

//        public void SetChorus(Chorus chorusEffect)
//        {
//            chorus = chorusEffect;
//        }

//        private void buttonONChorus_Click(object sender, EventArgs e)
//        {
//            if (!isChorusOn)
//            {
//                if (chorus != null)
//                {
//                    chorus.SetEnabled(true);
//                    buttonONChorus.BackColor = Color.LightGreen;
//                    buttonONChorus.Text = "ON";
//                    isChorusOn = true;
//                }
//            }
//            else
//            {
//                if (chorus != null)
//                {
//                    chorus.SetEnabled(false);
//                    buttonONChorus.BackColor = Color.DarkGray;
//                    buttonONChorus.Text = "OFF";
//                    isChorusOn = false;
//                }
//            }
//        }

//        private void chorusMix_Scroll(object sender, EventArgs e)
//        {

//        }

//        private void chorusFeedback_Scroll(object sender, EventArgs e)
//        {

//        }

//        private void chorusRate_Scroll(object sender, EventArgs e)
//        {

//        }

//        private void chorusDepth_Scroll(object sender, EventArgs e)
//        {

//        }

//        private void chorusBaseDelay_Scroll(object sender, EventArgs e)
//        {

//        }
//    }
//}

using AlphtechDSP;
using System;
using System.Windows.Forms;
using System.Drawing;

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
            chorusMix.Value = 50;

            chorusFeedback.Minimum = 0;
            chorusFeedback.Maximum = 90;
            chorusFeedback.Value = 20;

            chorusRate.Minimum = 1;
            chorusRate.Maximum = 50;
            chorusRate.Value = 5;

            chorusDepth.Minimum = 0;
            chorusDepth.Maximum = 100;
            chorusDepth.Value = 50;

            chorusBaseDelay.Minimum = 10;
            chorusBaseDelay.Maximum = 200;
            chorusBaseDelay.Value = 100;
        }

        public void SetChorus(Chorus chorusEffect)
        {
            chorus = chorusEffect;
            if (chorus != null)
            {
                isChorusOn = chorus.GetEnabled();
                UpdateUI();
            }
        }

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

        private void chorusMix_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetMix(chorusMix.Value / 100f);
            }
        }

        private void chorusFeedback_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetFeedback(chorusFeedback.Value / 100f);
            }
        }

        private void chorusRate_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetRate(chorusRate.Value / 10f);
            }
        }

        private void chorusDepth_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetDepth(chorusDepth.Value / 10f);
            }
        }

        private void chorusBaseDelay_Scroll(object sender, EventArgs e)
        {
            if (chorus != null)
            {
                chorus.SetBaseDelay(chorusBaseDelay.Value / 10f);
            }
        }
    }
}