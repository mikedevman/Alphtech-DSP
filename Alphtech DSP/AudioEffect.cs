namespace AlphtechDSP
{
    public abstract class AudioEffect
    {
        protected bool isEnabled;

        // abstract method to process a single audio sample
        public abstract float ProcessSample(float input);

        // abstract method to process an audio buffer
        public virtual void EffectsProcess(float[] buffer)
        {
            // if the effect is not enabled, return the buffer unchanged
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = ProcessSample(buffer[i]);
            }
        }

        // abstract method to enable or disable the effect
        public virtual void SetEnabled(bool enabled)
        {
            isEnabled = enabled;
        }

        public virtual bool GetEnabled()
        {
            return isEnabled;
        }

        // abstract method to reset the effect state
        public virtual void Reset() { }
    }
}
