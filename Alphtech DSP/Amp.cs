using Alphtech_DSP;
using NAudio.Dsp;
using System;

namespace AlphtechDSP
{
    public class Amp
    {
        private Gain gain = new Gain();
        private float volume;
        private BiQuadFilter bassFilter;
        private BiQuadFilter midFilter;
        private BiQuadFilter trebleFilter;
        private float lastBassValue;
        private float lastMidValue;
        private float lastTrebleValue;

        public Amp()
        {
            SetGain(0.1f);
            SetVolume(5.0f);
            SetBass(0.5f);
            SetMid(0.5f);
            SetTreble(0.5f);
        }

        public void SetGain(float value)
        {
            // Scales slider value [0, 1] to gain range [0.1, 5.0]
            float scaledGain = 0.1f + (value * 4.9f);
            gain.SetGain(scaledGain);
        }

        public float GetGain()
        {
            return gain.GetGain();
        }

        public void SetVolume(float value)
        {
            volume = Math.Max(0f, Math.Min(10f, value));
        }

        public float GetVolume()
        {
            return volume;
        }

        public void SetBass(float value)
        {
            float bassValue = (value - 0.5f) * 24f;
            bassFilter = BiQuadFilter.LowShelf(44100, 200, 1f, bassValue);
            lastBassValue = value;
        }

        public float GetBass()
        {
            return lastBassValue;
        }

        public void SetMid(float value)
        {
            float midValue = (value - 0.5f) * 24f;
            midFilter = BiQuadFilter.PeakingEQ(44100, 1000, 1f, midValue);
            lastMidValue = value;
        }

        public float GetMid()
        {
            return lastMidValue;
        }

        public void SetTreble(float value)
        {
            float trebleValue = (value - 0.5f) * 24f;
            trebleFilter = BiQuadFilter.HighShelf(44100, 5000, 1f, trebleValue);
            lastTrebleValue = value;
        }

        public float GetTreble()
        {
            return lastTrebleValue;
        }

        public BiQuadFilter GetBassFilter()
        {
            return bassFilter;
        }

        public BiQuadFilter GetMidFilter()
        {
            return midFilter;
        }

        public BiQuadFilter GetTrebleFilter()
        {
            return trebleFilter;
        }

        public void Process(float[] buffer)
        {
            gain.Process(buffer);

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
        }

        public void LoadState(Preset preset)
        {
            float gainSlider = (preset.Gain - 0.1f) / 4.9f;
            SetGain(gainSlider);

            SetVolume(preset.Volume);
            SetBass(preset.Bass);
            SetMid(preset.Mid);
            SetTreble(preset.Treble);
        }
    }
}
