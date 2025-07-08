namespace AlphtechDSP
{
    public class Gain
    {
        private float gain;

        public Gain()
        {
            gain = 1.0f;
        }

        public void SetGain(float value)
        {
            gain = value;
        }

        public void Process(float[] buffer)
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] *= gain;
            }
        }
    }
}
