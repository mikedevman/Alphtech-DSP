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

        public Delay(int sampleRate = 44100, float delaySeconds = 0.5f, float feedback = 0.3f, float mix = 0.3f)
        {
            this.sampleRate = sampleRate;

            if (delaySeconds <= 0.0f)
            {
                delaySeconds = 0.1f;
            }

            delaySamples = (int)(sampleRate * delaySeconds);
            if (delaySamples < 1)
            {
                delaySamples = 1;
            }

            buffer = new float[delaySamples];
            writeIndex = 0;

            SetFeedback(feedback);
            SetMix(mix);
            isEnabled = false;
        }

        public void SetDelay(float delaySeconds)
        {
            if (delaySeconds <= 0.0f)
            {
                delaySeconds = 0.1f;
            }

            int newDelaySamples = (int)(sampleRate * delaySeconds);
            if (newDelaySamples < 1)
            {
                newDelaySamples = 1;
            }
            //resize buffer if necessary
            if (newDelaySamples != delaySamples)
            {
                delaySamples = newDelaySamples;
                buffer = new float[delaySamples];
                writeIndex = 0; //reset write index
            }
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
