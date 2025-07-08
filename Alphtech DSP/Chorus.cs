using System;

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
        private bool isEnabled;
        private int sampleRate;

        public Chorus()
        {
            sampleRate = 44100;
            baseDelay = 10.0f; 
            depth = 0.5f;
            rate = 0.25f;
            mix = 0.5f;
            feedback = 0.0f;
            isEnabled = true;

            delayBufferSize = (int)(sampleRate * 0.05f); //50 ms max delay
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
            mix = value;
        }

        public void SetFeedback(float value)
        {
            feedback = value;
        }

        public void SetRate(float value)
        {
            rate = value;
        }

        public void SetDepth(float value)
        {
            depth = value;
        }

        public void SetBaseDelay(float value)
        {
            baseDelay = value;
        }

        public override float ProcessSample(float input)
        {
            if (!isEnabled)
            {
                return input;
            }

            //calculate delay time in samples based on LFO
            float lfo = (float)Math.Sin(2 * Math.PI * lfoPhase);
            float modDelayMs = baseDelay + (depth * baseDelay * lfo);
            float modDelaySamples = modDelayMs * sampleRate / 1000.0f;

            int delaySamples = (int)modDelaySamples;
            int readIndex = writeIndex - delaySamples;
            if (readIndex < 0)
            {
                readIndex += delayBufferSize;
            }

            //wrap write index
            float delayedSample = delayBuffer[readIndex];
            float wet = delayedSample;
            float output = (input * (1.0f - mix)) + (wet * mix);

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
