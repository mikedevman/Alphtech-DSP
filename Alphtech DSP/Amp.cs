using NAudio.Dsp;
using System;
using Alphtech_DSP;

namespace AlphtechDSP
{
    public class Amp
    {
        private GainEffect gain;
        private float userBaseGain = 1.0f;
        private float volume;
        private BiQuadFilter bassFilter;
        private BiQuadFilter midFilter;
        private BiQuadFilter trebleFilter;
        private float lastBassValue;
        private float lastMidValue;
        private float lastTrebleValue;

        public Amp()
        {
            gain = new GainEffect();
            SetBaseGain(0.1f);
            SetVolume(5.0f);
            SetBass(0.5f);
            SetMid(0.5f);
            SetTreble(0.5f);
        }

        public void SetBaseGain(float value)
        {
            userBaseGain = 0.1f + (value * 4.9f);
            gain.SetBaseGain(userBaseGain);
        }

        public float GetUserBaseGain()
        {
            return userBaseGain;
        }

        public float GetCurrentGain()
        {
            return gain.GetGain();
        }

        public void EnableOverdrive(bool enabled)
        {
            gain.EnableOverdrive(enabled);
        }

        public void SetOverdriveLevel(float level)
        {
            gain.SetOverdriveGain(level);
        }

        public void EnableDistortion(bool enabled)
        {
            gain.EnableDistortion(enabled);
        }

        public void SetDistortionLevel(float level)
        {
            gain.SetDistortionGain(level);
        }

        public void SetVolume(float value)
        {
            volume = Math.Max(0f, Math.Min(10f, value));
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
            float baseGainSlider = (preset.BaseGain - 0.1f) / 4.9f;
            SetBaseGain(baseGainSlider);

            SetVolume(preset.Volume);
            SetBass(preset.Bass);
            SetMid(preset.Mid);
            SetTreble(preset.Treble);
        }
    }
}
