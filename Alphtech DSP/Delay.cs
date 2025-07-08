namespace AlphtechDSP
{
    public class Delay : AudioEffect
    {
        private float[] buffer;
        private int delaySamples;
        private int writeIndex;
        private int sampleRate;
        private float feedback;
        private float mix;
        private bool isEnabled;

        public Delay(int sampleRate, int delaySeconds, float feedback, float mix)
        {
            this.sampleRate = sampleRate;

            if (delaySeconds <= 0)
            {
                delaySeconds = 1;
            }

            delaySamples = sampleRate * delaySeconds;
            buffer = new float[delaySamples];
            writeIndex = 0;

            this.feedback = feedback;
            this.mix = mix;
            isEnabled = true;
        }

        public void SetMix(float value)
        {
            //ensure mix is between 0.0 and 1.0
            if (value < 0.0f) value = 0.0f;
            if (value > 1.0f) value = 1.0f;
            mix = value;
        }

        public void SetFeedback(float value)
        {
            //ensure feedback is between 0.0 and 0.99
            if (value < 0.0f) value = 0.0f;
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

            //extract the delayed sample
            float delayedSample = buffer[readIndex];
            float output = input * (1.0f - mix) + delayedSample * mix;

            buffer[writeIndex] = input + delayedSample * feedback;

            writeIndex++;
            if (writeIndex >= buffer.Length)
            {
                writeIndex = 0;
            }

            return output;
        }
    }
}
