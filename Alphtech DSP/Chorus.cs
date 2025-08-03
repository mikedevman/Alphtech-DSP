namespace AlphtechDSP
{
    public class Chorus : AudioEffect
    {
        private float[] delayBuffer;
        private int delayBufferSize;
        private int writeIndex;
        private float lfoPhase;
        private float mix;
        private float feedback;
        private float rate;
        private float depth;
        private float baseDelay;
        private int sampleRate;
        private bool isEnabled;

        public Chorus()
        {
            sampleRate = 44100;
            baseDelay = 10.0f;
            depth = 5.0f;
            rate = 0.5f;
            mix = 0.5f;
            feedback = 0.2f;
            isEnabled = true;
            delayBufferSize = (int)(sampleRate * 0.05f);
            delayBuffer = new float[delayBufferSize];
            writeIndex = 0;
            lfoPhase = 0.0f;
        }

        // enable or disable chorus effect
        public void SetEnabled(bool value)
        {
            isEnabled = value;
        }

        public bool GetEnabled()
        {
            return isEnabled;
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
            // ensure feedback is between 0.0 and 0.9
            if (value < 0.0f) value = 0.0f;
            if (value > 0.9f) value = 0.9f;
            feedback = value;
        }

        public void SetRate(float value)
        {
            // ensure rate is between 0.1 and 5.0
            if (value < 0.1f) value = 0.1f;
            if (value > 5.0f) value = 5.0f;
            rate = value;
        }

        public void SetDepth(float value)
        {
            // ensure depth is between 0.0 and 10.0
            if (value < 0.0f) value = 0.0f;
            if (value > 10.0f) value = 10.0f;
            depth = value;
        }

        public void SetBaseDelay(float value)
        {
            // ensure base delay is between 1.0 and 20.0 ms
            if (value < 1.0f) value = 1.0f;
            if (value > 20.0f) value = 20.0f;
            baseDelay = value;
        }

        public override float ProcessSample(float input)
        {
            // process a single audio sample with chorus effect
            if (!isEnabled)
            {
                return input;
            }

            // calculate the modulated delay time using LFO
            float lfo = (float)System.Math.Sin(2.0 * System.Math.PI * lfoPhase);

            // modulate the delay time based on LFO and depth
            float modDelayMs = baseDelay + (depth * lfo);

            // ensure modulated delay is within bounds
            float modDelaySamples = (modDelayMs * sampleRate) / 1000.0f;

            // ensure modulated delay is within the buffer size
            int delaySamples = (int)modDelaySamples;
            if (delaySamples >= delayBufferSize)
            {
                delaySamples = delayBufferSize - 1;
            }
            if (delaySamples < 1)
            {
                delaySamples = 1;
            }

            // calculate the read index based on the write index and delay samples
            int readIndex = writeIndex - delaySamples;
            if (readIndex < 0)
            {
                readIndex += delayBufferSize;
            }

            // read the delayed sample and mix it with the input sample
            float delayedSample = delayBuffer[readIndex];

            // apply feedback to the delayed sample
            float output = input * (1.0f - mix) + delayedSample * mix;

            // write the new sample to the delay buffer with feedback
            delayBuffer[writeIndex] = input + (delayedSample * feedback);

            // increment the write index and wrap around 
            writeIndex++;
            if (writeIndex >= delayBufferSize)
            {
                writeIndex = 0;
            }

            // update the LFO phase
            lfoPhase += rate / sampleRate;
            if (lfoPhase >= 1.0f)
            {
                lfoPhase -= 1.0f;
            }

            return output;
        }
    }
}