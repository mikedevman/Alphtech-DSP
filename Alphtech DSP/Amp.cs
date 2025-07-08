using NAudio.Dsp;

namespace AlphtechDSP
{
    public class Amp
    {
        private float gain;
        private float volume;
        private BiQuadFilter bassFilter;
        private BiQuadFilter midFilter;
        private BiQuadFilter trebleFilter;

        public Amp()
        {
            gain = 1.0f;
            volume = 1.0f;
            SetBass(1.0f);
            SetMid(1.0f);
            SetTreble(1.0f);
        }

        public void SetGain(float value)
        {
            gain = value;
        }

        public void SetVolume(float value)
        {
            volume = value;
        }

        public void SetBass(float value)
        {
            bassFilter = BiQuadFilter.LowShelf(44100, 200, 1f, value);
        }

        public void SetMid(float value)
        {
            midFilter = BiQuadFilter.PeakingEQ(44100, 1000, 1f, value);
        }

        public void SetTreble(float value)
        {
            trebleFilter = BiQuadFilter.HighShelf(44100, 5000, 1f, value);
        }

        public void Process(float[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                float sample = buffer[i];

                sample *= gain;

                sample = bassFilter.Transform(sample);
                sample = midFilter.Transform(sample);
                sample = trebleFilter.Transform(sample);

                sample *= volume;

                buffer[i] = sample;
            }
        }
    }
}
