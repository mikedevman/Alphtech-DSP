using System;
using System.IO;

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

    public enum PresetParameter
    {
        BaseGain,
        Volume,
        Bass,
        Mid,
        Treble
    }

    public class Preset
    {
        public PresetType Type { get; set; }

        public float Gain { get; set; }
        public float Volume { get; set; }
        public float Bass { get; set; }
        public float Mid { get; set; }
        public float Treble { get; set; }

        public Preset Clone()
        {
            return (Preset)this.MemberwiseClone();
        }
    }

    public static class Presets
    {
        public static Preset GetPreset(PresetType guitaristPreset)
        {
            switch (guitaristPreset)
            {
                case PresetType.JohnMayer:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 0.6f,
                        Volume = 5.0f,
                        Bass = 0.65f,
                        Mid = 0.6f,
                        Treble = 0.55f,
                    };

                case PresetType.JerryCantrell:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 1.2f,
                        Volume = 6.5f,
                        Bass = 0.55f,
                        Mid = 0.7f,
                        Treble = 0.6f,
                    };

                case PresetType.StevieRayVaughan:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 1.0f,
                        Volume = 7.0f,
                        Bass = 0.75f,
                        Mid = 0.65f,
                        Treble = 0.5f
                    };

                case PresetType.CoryWong:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 0.5f,
                        Volume = 4.5f,
                        Bass = 0.5f,
                        Mid = 0.4f,
                        Treble = 0.7f
                    };

                case PresetType.JimiHendrix:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 1.4f,
                        Volume = 6.0f,
                        Bass = 0.6f,
                        Mid = 0.55f,
                        Treble = 0.75f
                    };

                default:
                    return null;
            }
        }

        public static void SavePresetToFile(Preset preset, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine($"BaseGain={preset.Gain}");
                writer.WriteLine($"Volume={preset.Volume}");
                writer.WriteLine($"Bass={preset.Bass}");
                writer.WriteLine($"Mid={preset.Mid}");
                writer.WriteLine($"Treble={preset.Treble}");
            }
        }

        public static Preset LoadPresetFromFile(string filePath)
        {
            Preset preset = new Preset();

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('=');
                if (parts.Length != 2) continue;

                string key = parts[0].Trim();
                string value = parts[1].Trim();

                if (!float.TryParse(value, out float parsedValue)) continue;
                if (!Enum.TryParse(key, out PresetParameter parameter)) continue;

                switch (parameter)
                {
                    case PresetParameter.BaseGain:
                        preset.Gain = parsedValue;
                        break;
                    case PresetParameter.Volume:
                        preset.Volume = parsedValue;
                        break;
                    case PresetParameter.Bass:
                        preset.Bass = parsedValue;
                        break;
                    case PresetParameter.Mid:
                        preset.Mid = parsedValue;
                        break;
                    case PresetParameter.Treble:
                        preset.Treble = parsedValue;
                        break;
                }
            }
            return preset;
        }

    }
}
