namespace AlphtechDSP
{
    public abstract class AudioEffect
    {
        public abstract float ProcessSample(float input);
        public virtual void EffectsProcess(float[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = ProcessSample(buffer[i]);
            }
        }
    }
}