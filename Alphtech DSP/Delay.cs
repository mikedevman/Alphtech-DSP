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

        // create delay effect with specified parameters
        public Delay(int sampleRate = 44100, float delaySeconds = 0.5f, float feedback = 0.3f, float mix = 0.3f)
        {
            // initialize the delay effect with default parameters
            this.sampleRate = sampleRate;

            // ensure delaySeconds is at least 0.1 seconds
            if (delaySeconds <= 0.0f)
            {
                delaySeconds = 0.1f;
            }

            // calculate the number of samples for the delay
            delaySamples = (int)(sampleRate * delaySeconds);
            if (delaySamples < 1)
            {
                delaySamples = 1;
            }

            // initialize the buffer with the specified delay size
            buffer = new float[delaySamples];

            // initialize feedback and mix values
            writeIndex = 0;

            // set feedback and mix values
            SetFeedback(feedback);
            SetMix(mix);

            // set the effect as enabled by default
            isEnabled = false;
        }

        // set the sample rate for the delay effect
        public void SetDelay(float delaySeconds)
        {

            // ensure delaySeconds is at least 0.1 seconds
            if (delaySeconds <= 0.0f)
            {
                delaySeconds = 0.1f;
            }

            // calculate the new number of samples for the delay
            int newDelaySamples = (int)(sampleRate * delaySeconds);
            if (newDelaySamples < 1)
            {
                newDelaySamples = 1;
            }

            // if the new delay size is different from the current one, resize the buffer
            if (newDelaySamples != delaySamples)
            {
                delaySamples = newDelaySamples;
                buffer = new float[delaySamples];

                // reset the write index to 0
                writeIndex = 0;
            }
        }

        public void SetMix(float value)
        {
            // ensure mix is between 0.0 and 1.0
            if (value < 0.0f) value = 0.0f;
            if (value > 1.0f) value = 1.0f;
            mix = value;
        }

        public void SetFeedback(float value)
        {
            // ensure feedback is between 0.0 and 0.99
            if (value < 0.0f) value = 0.0f;
            if (value > 0.99f) value = 0.99f;
            feedback = value;
        }

        // enable or disable the delay effect
        public void SetEnabled(bool value)
        {
            isEnabled = value;
        }

        public bool GetEnabled()
        {
            return isEnabled;
        }

        // process a single audio sample with the delay effect
        public override float ProcessSample(float input)
        {
            // if the effect is not enabled, return the input sample unchanged
            if (!isEnabled)
            {
                return input;
            }

            // write the input sample to the buffer at the current write index
            int readIndex = writeIndex - delaySamples;

            // ensure readIndex wraps around the buffer size
            if (readIndex < 0)
            {
                readIndex += buffer.Length;
            }

            //extract the delayed sample
            float delayedSample = buffer[readIndex];

            // mix the delayed sample with the input sample
            float output = input * (1.0f - mix) + delayedSample * mix;

            // write the new sample to the buffer with feedback
            buffer[writeIndex] = input + delayedSample * feedback;

            // increment the write index and wrap around 
            writeIndex++;
            if (writeIndex >= buffer.Length)
            {
                writeIndex = 0;
            }

            return output;
        }
    }
}
