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

        // sets gain scale from 0.1 to 5.0
        public void SetGain(float value)
        {
            float scaledGain = 0.1f + (value * 4.9f);
            gain.SetGain(scaledGain);
        }

        public float GetGain()
        {
            return gain.GetGain();
        }

        // sets volume scale from 0.0 to 10.0
        public void SetVolume(float value)
        {
            volume = Math.Max(0f, Math.Min(10f, value));
        }

        public float GetVolume()
        {
            return volume;
        }

        // set bass value from 0.0 to 1.0
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

        // set mid value from 0.0 to 1.0
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

        // set treble value from 0.0 to 1.0
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

        // applies the gain, volume, and EQ filters to the audio buffer
        public void Process(float[] buffer)
        {
            // apply gain first
            gain.Process(buffer);

            // loop through the buffer and apply the filters
            for (int i = 0; i < buffer.Length; i++)
            {
                float sample = buffer[i];

                sample = bassFilter.Transform(sample);
                sample = midFilter.Transform(sample);
                sample = trebleFilter.Transform(sample);

                // apply volume scaling 
                sample *= volume;
                sample = Math.Max(-1f, Math.Min(1f, sample));

                buffer[i] = sample;
            }
        }

        // loads the state from a Preset object
        public void LoadState(Preset preset)
        {
            // gain is scaled from 0.1 to 5.0
            float gainSlider = (preset.Gain - 0.1f) / 4.9f;
            SetGain(gainSlider);

            SetVolume(preset.Volume);
            SetBass(preset.Bass);
            SetMid(preset.Mid);
            SetTreble(preset.Treble);
        }
    }
}
