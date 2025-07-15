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
            if (value < 0.0f) value = 0.0f;
            if (value > 1.0f) value = 1.0f;
            mix = value;
        }

        public void SetFeedback(float value)
        {
            if (value < 0.0f) value = 0.0f;
            if (value > 0.9f) value = 0.9f;
            feedback = value;
        }

        public void SetRate(float value)
        {
            if (value < 0.1f) value = 0.1f;
            if (value > 5.0f) value = 5.0f;
            rate = value;
        }

        public void SetDepth(float value)
        {
            if (value < 0.0f) value = 0.0f;
            if (value > 10.0f) value = 10.0f;
            depth = value;
        }

        public void SetBaseDelay(float value)
        {
            if (value < 1.0f) value = 1.0f;
            if (value > 20.0f) value = 20.0f;
            baseDelay = value;
        }

        public override float ProcessSample(float input)
        {
            if (!isEnabled)
            {
                return input;
            }

            float lfo = (float)System.Math.Sin(2.0 * System.Math.PI * lfoPhase);
            float modDelayMs = baseDelay + (depth * lfo);
            float modDelaySamples = (modDelayMs * sampleRate) / 1000.0f;

            int delaySamples = (int)modDelaySamples;
            if (delaySamples >= delayBufferSize)
            {
                delaySamples = delayBufferSize - 1;
            }
            if (delaySamples < 1)
            {
                delaySamples = 1;
            }

            int readIndex = writeIndex - delaySamples;
            if (readIndex < 0)
            {
                readIndex += delayBufferSize;
            }

            float delayedSample = delayBuffer[readIndex];
            float output = input * (1.0f - mix) + delayedSample * mix;

            delayBuffer[writeIndex] = input + (delayedSample * feedback);

            writeIndex++;
            if (writeIndex >= delayBufferSize)
            {
                writeIndex = 0;
            }

            lfoPhase += rate / sampleRate;
            if (lfoPhase >= 1.0f)
            {
                lfoPhase -= 1.0f;
            }

            return output;
        }
    }
}