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

        public void SetOverdriveGain(float value)
        {
            float gainValue = 1.0f + (value * 19.0f); // maps 0.0–1.0 to 1.0–20.0
            overdrive.SetGain(gainValue);
        }

        public void EnableDistortion(bool enabled)
        {
            distortionEnabled = enabled;
        }

        public void SetDistortionGain(float value)
        {
            float gainValue = 4.0f + (value * 19.0f);
            distortion.SetGain(gainValue);
        }

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
