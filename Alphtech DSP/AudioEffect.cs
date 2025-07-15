namespace AlphtechDSP
{
    public abstract class AudioEffect
    {
        protected bool isEnabled;

        public abstract float ProcessSample(float input);

        public virtual void EffectsProcess(float[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = ProcessSample(buffer[i]);
            }
        }

        public virtual void SetEnabled(bool enabled)
        {
            isEnabled = enabled;
        }

        public virtual bool GetEnabled()
        {
            return isEnabled;
        }

        public virtual void Reset() { }
    }
}
