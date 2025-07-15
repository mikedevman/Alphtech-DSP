using System;
using System.Collections.Generic;
using Alphtech_DSP;
using NAudio.Wave;

namespace AlphtechDSP
{
    public class AudioProcessing : IDisposable
    {
        private WaveInEvent input;
        private WaveOutEvent output;
        private BufferedWaveProvider buffer;
        private List<AudioEffect> effects;
        private Amp amp;
        private Delay delay;
        private Chorus chorus;
        private Tremolo tremolo;

        public AudioProcessing()
        {
            effects = new List<AudioEffect>();
            amp = new Amp();
            delay = new Delay();
            chorus = new Chorus();
            tremolo = new Tremolo();

            input = new WaveInEvent();
            input.WaveFormat = new WaveFormat(44100, 1);
            input.BufferMilliseconds = 10;

            output = new WaveOutEvent();
            output.DesiredLatency = 49;

            buffer = new BufferedWaveProvider(input.WaveFormat);
            buffer.DiscardOnBufferOverflow = true;

            input.DataAvailable += OnDataAvailable;
            output.Init(buffer);

            AddEffect(delay);
            AddEffect(chorus);
            AddEffect(tremolo);
        }

        public Amp GetAmp()
        {
            return amp;
        }

        public Delay GetDelay()
        {
            return delay;
        }

        public Chorus GetChorus()
        {
            return chorus;
        }

        public Tremolo GetTremolo()
        {
            return tremolo;
        }

        public void AddEffect(AudioEffect effect)
        {
            effects.Add(effect);
        }

        public void RemoveEffect(AudioEffect effect)
        {
            effects.Remove(effect);
        }

        public void Start()
        {
            input.StartRecording();
            output.Play();
        }

        public void Stop()
        {
            input.StopRecording();
            output.Stop();
        }

        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            byte[] inputBytes = e.Buffer;
            float[] samples = ConvertToFloat(inputBytes);

            for (int i = 0; i < effects.Count; i++)
            {
                effects[i].EffectsProcess(samples);
            }

            amp.Process(samples);

            byte[] outputBytes = ConvertToByte(samples);
            buffer.AddSamples(outputBytes, 0, outputBytes.Length);
        }

        private float[] ConvertToFloat(byte[] bytes)
        {
            int length = bytes.Length / 2;
            float[] samples = new float[length];

            for (int i = 0; i < length; i++)
            {
                short sample = BitConverter.ToInt16(bytes, i * 2);
                samples[i] = sample / 32768f;
            }

            return samples;
        }

        private byte[] ConvertToByte(float[] samples)
        {
            byte[] bytes = new byte[samples.Length * 2];

            for (int i = 0; i < samples.Length; i++)
            {
                short sample = (short)(samples[i] * 32768f);
                byte[] sampleBytes = BitConverter.GetBytes(sample);
                bytes[i * 2] = sampleBytes[0];
                bytes[i * 2 + 1] = sampleBytes[1];
            }

            return bytes;
        }

        public void Dispose()
        {
            Stop();
            input.Dispose();
            output.Dispose();
        }
    }
}