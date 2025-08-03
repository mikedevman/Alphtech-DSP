using System;

namespace AlphtechDSP
{
    public class GainEffect
    {
        private Gain overdrive = new Gain();
        private Gain distortion = new Gain();
        private bool overdriveEnabled = false;
        private bool distortionEnabled = false;

        public void EnableOverdrive(bool enabled)
        {
            overdriveEnabled = enabled;
        }

        // sets the gain for the overdrive effect
        public void SetOverdriveGain(float value)
        {
            float gainValue = 1.0f + (value * 19.0f); 
            overdrive.SetGain(gainValue);
        }

        public void EnableDistortion(bool enabled)
        {
            distortionEnabled = enabled;
        }

        // sets the gain for the distortion effect
        public void SetDistortionGain(float value)
        {
            float gainValue = 4.0f + (value * 19.0f);
            distortion.SetGain(gainValue);
        }

        // applies the gain effects to the audio buffer
        public void Process(float[] buffer)
        {
            if (overdriveEnabled)
            {
                overdrive.Process(buffer);
            }

            if (distortionEnabled)
            {
                distortion.Process(buffer);
            }
        }
    }
}
