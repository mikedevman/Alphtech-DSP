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

        // constructor to initialize default values
        public Preset Clone()
        {
            return (Preset)this.MemberwiseClone();
        }
    }

    public static class Presets
    {
        // static method to get a preset based on the type
        public static Preset GetPreset(PresetType guitaristPreset)
        {
            switch (guitaristPreset)
            {
                case PresetType.JohnMayer:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 0.74f,
                        Volume = 5.0f,
                        Bass = 0.45f,
                        Mid = 0.67f,
                        Treble = 0.56f,
                    };

                case PresetType.JerryCantrell:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 5.0f,
                        Volume = 5.0f,
                        Bass = 0.56f,
                        Mid = 0.78f,
                        Treble = 0.45f,
                    };

                case PresetType.StevieRayVaughan:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 0.45f,
                        Volume = 5.0f,
                        Bass = 0.67f,
                        Mid = 0.67f,
                        Treble = 0.56f
                    };

                case PresetType.CoryWong:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 0.23f,
                        Volume = 5.0f,
                        Bass = 0.34f,
                        Mid = 0.56f,
                        Treble = 0.67f
                    };

                case PresetType.JimiHendrix:
                    return new Preset
                    {
                        Type = guitaristPreset,
                        Gain = 0.67f,
                        Volume = 5.0f,
                        Bass = 0.56f,
                        Mid = 0.56f,
                        Treble = 0.56f
                    };

                default:
                    return null;
            }
        }

        // methods to save preset to a file
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

        // method to load preset from a file
        public static Preset LoadPresetFromFile(string filePath)
        {
            Preset preset = new Preset();

            // check if file exists
            foreach (var line in File.ReadAllLines(filePath))
            {
                // skip empty lines and comments
                var parts = line.Split('=');

                // expect exactly two parts: key and value
                if (parts.Length != 2) continue;

                // trim whitespace and parse key-value pairs
                string key = parts[0].Trim();
                string value = parts[1].Trim();

                // try to parse the value as a float and assign it to the corresponding property
                if (!float.TryParse(value, out float parsedValue)) continue;

                // check if the key is a valid PresetParameter
                if (!Enum.TryParse(key, out PresetParameter parameter)) continue;

                // assign the parsed value to the corresponding property in the preset
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
