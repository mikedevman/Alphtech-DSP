namespace Alphtech_DSP
{
    public enum PresetType
    {
        JohnMayer,
        JerryCantrell,
        StevieRayVaughan,
        CoryWong,
        JimiHendrix
    }

    public class Preset
    {
        public PresetType Type { get; set; }

        public float BaseGain { get; set; }
        public float Volume { get; set; }
        public float Bass { get; set; }
        public float Mid { get; set; }
        public float Treble { get; set; }

        public bool OverdriveEnabled { get; set; }
        public float OverdriveLevel { get; set; }

        public bool DistortionEnabled { get; set; }
        public float DistortionLevel { get; set; }

        public bool ChorusEnabled { get; set; }
        public float ChorusMix { get; set; }
        public float ChorusRate { get; set; }
        public float ChorusDepth { get; set; }

        public bool DelayEnabled { get; set; }
        public float DelayTime { get; set; }
        public float DelayMix { get; set; }
        public float DelayFeedback { get; set; }

        public bool TremoloEnabled { get; set; }
        public float TremoloRate { get; set; }
        public float TremoloDepth { get; set; }

        public Preset Clone()
        {
            return (Preset)this.MemberwiseClone();
        }
    }

    public static class PresetFactory
    {
        public static Preset GetPreset(PresetType type)
        {
            switch (type)
            {
                case PresetType.JohnMayer:
                    return new Preset
                    {
                        Type = type,
                        BaseGain = 0.6f,
                        Volume = 5.0f,
                        Bass = 0.65f,
                        Mid = 0.6f,
                        Treble = 0.55f,
                        OverdriveEnabled = true,
                        OverdriveLevel = 1.2f,
                        DistortionEnabled = false,
                        ChorusEnabled = false,
                        DelayEnabled = true,
                        DelayTime = 0.3f,
                        DelayMix = 0.25f,
                        DelayFeedback = 0.2f,
                        TremoloEnabled = false
                    };

                case PresetType.JerryCantrell:
                    return new Preset
                    {
                        Type = type,
                        BaseGain = 1.2f,
                        Volume = 6.5f,
                        Bass = 0.55f,
                        Mid = 0.7f,
                        Treble = 0.6f,
                        OverdriveEnabled = false,
                        DistortionEnabled = true,
                        DistortionLevel = 1.8f,
                        ChorusEnabled = false,
                        DelayEnabled = false,
                        TremoloEnabled = false
                    };

                case PresetType.StevieRayVaughan:
                    return new Preset
                    {
                        Type = type,
                        BaseGain = 1.0f,
                        Volume = 7.0f,
                        Bass = 0.75f,
                        Mid = 0.65f,
                        Treble = 0.5f,
                        OverdriveEnabled = true,
                        OverdriveLevel = 1.5f,
                        DistortionEnabled = false,
                        ChorusEnabled = false,
                        DelayEnabled = false,
                        TremoloEnabled = false
                    };

                case PresetType.CoryWong:
                    return new Preset
                    {
                        Type = type,
                        BaseGain = 0.5f,
                        Volume = 4.5f,
                        Bass = 0.5f,
                        Mid = 0.4f,
                        Treble = 0.7f,
                        OverdriveEnabled = false,
                        DistortionEnabled = false,
                        ChorusEnabled = true,
                        ChorusMix = 0.4f,
                        ChorusRate = 1.0f,
                        ChorusDepth = 0.3f,
                        DelayEnabled = false,
                        TremoloEnabled = true,
                        TremoloRate = 0.8f,
                        TremoloDepth = 0.2f
                    };

                case PresetType.JimiHendrix:
                    return new Preset
                    {
                        Type = type,
                        BaseGain = 1.4f,
                        Volume = 6.0f,
                        Bass = 0.6f,
                        Mid = 0.55f,
                        Treble = 0.75f,
                        OverdriveEnabled = true,
                        OverdriveLevel = 1.7f,
                        DistortionEnabled = true,
                        DistortionLevel = 1.5f,
                        ChorusEnabled = true,
                        ChorusMix = 0.3f,
                        ChorusRate = 1.2f,
                        ChorusDepth = 0.4f,
                        DelayEnabled = true,
                        DelayTime = 0.45f,
                        DelayMix = 0.3f,
                        DelayFeedback = 0.25f,
                        TremoloEnabled = false
                    };

                default:
                    return null;
            }
        }
    }
}
