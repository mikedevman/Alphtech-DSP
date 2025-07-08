namespace AlphtechDSP
{
    public class Reverb : AudioEffect
    {
        private float[] buffer;
        private int writeIndex;
        private int delaySamples;
        private float feedback;
        private float mix;
        private bool isEnabled;

        public Reverb(int sampleRate, float feedback, float mix)
        {
            delaySamples = (int)(sampleRate * 0.08f); // ~80ms
            buffer = new float[delaySamples];
            this.feedback = feedback;
            this.mix = mix;
            writeIndex = 0;
            isEnabled = true;
        }

        public void SetMix(float value)
        {
            //ensure mix is between 0.0 and 1.0
            if (value < 0f) value = 0f;
            if (value > 1f) value = 1f;
            mix = value;
        }

        public void SetFeedback(float value)
        {
            //ensure feedback is between 0.0 and 0.99
            if (value < 0f) value = 0f;
            if (value > 0.99f) value = 0.99f;
            feedback = value;
        }

        public void SetEnabled(bool value)
        {
            isEnabled = value;
        }

        public bool GetEnabled()
        {
            return isEnabled;
        }

        public override float ProcessSample(float input)
        {
            if (!isEnabled)
            {
                return input;
            }

            int readIndex = writeIndex - delaySamples;
            if (readIndex < 0)
            {
                readIndex += buffer.Length;
            }

            //xtract delayed sample
            float delayedSample = buffer[readIndex];
            float output = input * (1f - mix) + delayedSample * mix;

            buffer[writeIndex] = input + delayedSample * feedback;
            writeIndex = (writeIndex + 1) % buffer.Length;

            return output;
        }
    }
}
