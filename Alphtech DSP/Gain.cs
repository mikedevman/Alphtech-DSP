using System;

namespace AlphtechDSP
{
    public class Gain
    {
        private float gain;

        public Gain()
        {
            gain = 1.0f;
        }

        public void SetGain(float value)
        { 
            gain = Math.Max(0.1f, Math.Min(100.0f, value));
        }

        public void Process(float[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                float sample = buffer[i];

                sample *= gain;

                if (gain > 1.5f) 
                {
                    sample = SoftClip(sample);
                }

                sample = Math.Max(-1.0f, Math.Min(1.0f, sample)); //clipping to prevent overflow

                buffer[i] = sample;
            }
        }

        private float SoftClip(float sample) 
        {
            if (sample > 0.7f) 
            {
                sample = 0.7f + (sample - 0.7f) * 0.3f;
            }
            else if (sample < -0.7f)
            {
                sample = -0.7f + (sample + 0.7f) * 0.3f; 
            }

            return sample;
        }
    }
}
