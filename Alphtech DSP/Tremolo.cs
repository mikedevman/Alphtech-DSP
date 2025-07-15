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

        public void SetEnabled(bool value)
        {
            isEnabled = value;
        }

        public bool GetEnabled()
        {
            return isEnabled;
        }

        public void SetRate(float value)
        {
            if (value < 0.1f) value = 0.1f;
            if (value > 20.0f) value = 20.0f;
            rate = value;
        }

        public void SetDepth(float value)
        {
            if (value < 0.0f) value = 0.0f;
            if (value > 1.0f) value = 1.0f;
            depth = value;
        }

        public void SetTime(float value)
        {
            if (value < 0.1f) value = 0.1f;
            if (value > 5.0f) value = 5.0f;
            time = value;
        }

        public void SetSampleRate(int value)
        {
            if (value <= 0) value = 44100;
            sampleRate = value;
        }

        public override float ProcessSample(float input)
        {
            if (!isEnabled)
            {
                return input;
            }

            float lfo = (float)Math.Sin(2.0 * Math.PI * lfophase);
            float modulation = 1.0f + (depth * lfo);
            float output = input * modulation;

            float effectiveRate = rate * time;
            lfophase += rate / sampleRate;
            if (lfophase >= 1.0f)
            {
                lfophase -= 1.0f;
            }

            return output;
        }

        public void Reset()
        {
            lfophase = 0.0f;
        }
    }
}