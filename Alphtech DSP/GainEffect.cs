using AlphtechDSP;

public class GainEffect : Gain
{
    private bool overdriveEnabled = false;
    private bool distortionEnabled = false;

    private float baseGain = 1.0f;
    private float overdriveGain = 1.0f;
    private float distortionGain = 1.0f;

    public void SetBaseGain(float value)
    {
        baseGain = value;
        UpdateEffectiveGain();
    }

    public void SetOverdriveGain(float value)
    {
        overdriveGain = value;
        if (overdriveEnabled)
        {
            UpdateEffectiveGain();
        }
    }

    public void SetDistortionGain(float value)
    {
        distortionGain = value;
        if (distortionEnabled)
        {
            UpdateEffectiveGain();
        }
    }

    public void EnableOverdrive(bool enabled)
    {
        overdriveEnabled = enabled;
        UpdateEffectiveGain();
    }

    public void EnableDistortion(bool enabled)
    {
        distortionEnabled = enabled;
        UpdateEffectiveGain();
    }

    private void UpdateEffectiveGain()
    {
        float totalGain = baseGain;

        if (overdriveEnabled)
        {
            totalGain *= overdriveGain * 3.0f;
        }

        if (distortionEnabled)
        {
            totalGain *= distortionGain * 8.0f;
        }

        SetGain(totalGain);
    }
}
