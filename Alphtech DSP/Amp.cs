using NAudio.Dsp;
using System;

namespace AlphtechDSP
{
    public class Amp
    {
        private Gain gain;
        private float volume;
        private BiQuadFilter bassFilter;
        private BiQuadFilter midFilter;
        private BiQuadFilter trebleFilter;

        public Amp()
        {
            gain = new Gain();
            SetGain(0.1f);
            SetVolume(5.0f);
            SetBass(0.5f);
            SetMid(0.5f);
            SetTreble(0.5f);
        }

        public void SetGain(float value)
        {
            float gainValue = 0.1f + (value * 4.9f);
            gain.SetGain(gainValue);
        }

        public void SetVolume(float value)
        {
            volume = Math.Max(0f, Math.Min(10f, value));
        }

        public void SetBass(float value)
        {
            float bassValue = (value - 0.5f) * 24f; //24 dB range
            bassFilter = BiQuadFilter.LowShelf(44100, 200, 1f, bassValue);
        }

        public void SetMid(float value)
        {
            float midValue = (value - 0.5f) * 24f;
            midFilter = BiQuadFilter.PeakingEQ(44100, 1000, 1f, midValue);
        }

        public void SetTreble(float value)
        {
            float trebleValue = (value - 0.5f) * 24f;
            trebleFilter = BiQuadFilter.HighShelf(44100, 5000, 1f, trebleValue);
        }

        public void Process(float[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                float sample = buffer[i];

                sample = bassFilter.Transform(sample);
                sample = midFilter.Transform(sample);
                sample = trebleFilter.Transform(sample);

                sample *= volume;

                sample = Math.Max(-1f, Math.Min(1f, sample));
                buffer[i] = sample;
            }
            gain.Process(buffer);
        }
    }
}

