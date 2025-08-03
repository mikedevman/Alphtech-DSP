using System;
namespace AlphtechDSP
{
    public class Gain
    {
        protected float gain;
        public Gain()
        {
            gain = 1.0f;
        }

        // sets gain scale from 0.1 to 200.0
        public void SetGain(float value)
        {
            gain = Math.Max(0.1f, Math.Min(200.0f, value));
        }

        public float GetGain()
        {
            return gain;
        }

        // processes a buffer of audio samples with gain applied
        public void Process(float[] buffer)
        {
            // apply gain to each sample in the buffer
            for (int i = 0; i < buffer.Length; i++)
            {
                float sample = buffer[i] * gain;
                if (sample > 0.7f)
                {
                    sample = 0.7f;
                }
                else if (sample < -0.7f)
                {
                    sample = -0.7f;
                }
                buffer[i] = sample;
            }
        }
    }
}