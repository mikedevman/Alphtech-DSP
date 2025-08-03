using System;
namespace AlphtechDSP
{
    public class Tremolo : AudioEffect
    {
        private float lfophase;
        private float rate;
        private float depth;
        private float time;
        private int sampleRate;
        private bool isEnabled;

        public Tremolo()
        {
            sampleRate = 44100;
            rate = 5.0f;
            depth = 0.5f;
            lfophase = 0.0f;
            isEnabled = true;
        }

        // enable or disable tremolo effect
        public void SetEnabled(bool value)
        {
            isEnabled = value;
        }

        public bool GetEnabled()
        {
            return isEnabled;
        }

        // ensure rate is between 0.1 and 20.0 
        public void SetRate(float value)
        {
            if (value < 0.1f) value = 0.1f;
            if (value > 20.0f) value = 20.0f;
            rate = value;
        }

        // ensure depth is between 0.0 and 1.0
        public void SetDepth(float value)
        {
            if (value < 0.0f) value = 0.0f;
            if (value > 1.0f) value = 1.0f;
            depth = value;
        }

        // ensure time is between 0.1 and 5.0 
        public void SetTime(float value)
        {
            if (value < 0.1f) value = 0.1f;
            if (value > 5.0f) value = 5.0f;
            time = value;
        }

        // set the sample rate for the tremolo effect
        public void SetSampleRate(int value)
        {
            if (value <= 0) value = 44100;
            sampleRate = value;
        }

        // process a single audio sample with tremolo effect
        public override float ProcessSample(float input)
        {
            // if the effect is not enabled, return the input unchanged
            if (!isEnabled)
            {
                return input;
            }


            // calculate the LFO modulation
            float lfo = (float)Math.Sin(2.0 * Math.PI * lfophase);

            // apply the tremolo effect using the LFO modulation
            float modulation = 1.0f + (depth * lfo);

            // ensure modulation is within bounds
            float output = input * modulation;

            // update the LFO phase and wrap it around 
            float effectiveRate = rate * time;

            // calculate the phase increment based on the sample rate
            lfophase += rate / sampleRate;
            if (lfophase >= 1.0f)
            {
                lfophase -= 1.0f;
            }

            return output;
        }

        // reset lFO phase to zero
        public void Reset()
        {
            lfophase = 0.0f;
        }
    }
}