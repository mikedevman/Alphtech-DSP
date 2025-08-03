using System;
using System.Collections.Generic;
using System.IO;
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
        private GainEffect gainEffect;
        private Delay delay;
        private Chorus chorus;
        private Tremolo tremolo;
        private bool isRecording;
        private WaveFileWriter waveWriter;
        private string recordingFolder;
        private string currentRecordingPath;

        public AudioProcessing()
        {
            effects = new List<AudioEffect>();
            amp = new Amp();
            gainEffect = new GainEffect();
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

            recordingFolder = @"C:\Users\Admin\Documents\Alphtech DSP\Alphtech DSP\recordings";
            isRecording = false;
        }

        // get Amp instance
        public Amp GetAmp()
        {
            return amp;
        }

        // get GainEffect instance
        public GainEffect GetGainEffect()
        {
            return gainEffect;
        }

        // process audio buffer 
        public void Process(float[] buffer)
        {
            // process amp
            amp.Process(buffer);

            // process each effect in the list
            gainEffect.Process(buffer);
        }

        // get Delay instance
        public Delay GetDelay()
        {
            return delay;
        }

        // get Chorus instance
        public Chorus GetChorus()
        {
            return chorus;
        }

        // get Tremolo instance
        public Tremolo GetTremolo()
        {
            return tremolo;
        }

        // add an audio effect to the processing chain
        public void AddEffect(AudioEffect effect)
        {
            effects.Add(effect);
        }

        // remove an audio effect from the processing chain
        public void RemoveEffect(AudioEffect effect)
        {
            effects.Remove(effect);
        }

        // start audio processing
        public void Start()
        {
            input.StartRecording();
            output.Play();
        }

        // stop audio processing
        public void Stop()
        {
            StopRecording();
            input.StopRecording();
            output.Stop();
        }

        // start recording audio to a file
        public void StartRecording(string fileName = null)
        {
            // return if already recording
            if (isRecording) return;

            // create recording file
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = "Recording_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".wav";
            }
            else if (!fileName.EndsWith(".wav"))
            {
                fileName += ".wav";
            }

            // ensure recording folder exists
            currentRecordingPath = Path.Combine(recordingFolder, fileName);

            // create WaveFileWriter to write audio data to file
            waveWriter = new WaveFileWriter(currentRecordingPath, input.WaveFormat);

            // start recording
            isRecording = true;
        }

        // stop recording audio and return the file path
        public string StopRecording()
        {
            // return if not recording
            if (!isRecording) return null;

            // stop recording
            isRecording = false;
            if (waveWriter != null)
            {
                waveWriter.Flush();
                waveWriter.Dispose();
                waveWriter = null;
            }
            return currentRecordingPath;
        }

        // check if currently recording
        public bool IsRecording
        {
            get { return isRecording; }
        }

        // set and get the recording folder path
        public string RecordingFolder
        {
            get { return recordingFolder; }
            set
            {
                recordingFolder = value;
                Directory.CreateDirectory(recordingFolder);
            }
        }

        // main method to handle audio data available from the input device
        private void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            // ensure buffer is initialized
            byte[] inputBytes = e.Buffer;

            // convert byte array to float array
            float[] samples = ConvertToFloat(inputBytes);

            // create a copy of the original samples for processing
            float[] originalSamples = new float[samples.Length];

            // copy samples to originalSamples for processing
            Array.Copy(samples, originalSamples, samples.Length);

            // process each effect in the list
            for (int i = 0; i < effects.Count; i++)
            {
                effects[i].EffectsProcess(samples);
            }

            // process amp and gain effect
            amp.Process(samples);
            gainEffect.Process(samples);

            // convert processed float array back to byte array
            byte[] outputBytes = ConvertToByte(samples);

            // add processed samples to the buffer
            buffer.AddSamples(outputBytes, 0, outputBytes.Length);

            // write to wave file if recording
            if (isRecording && waveWriter != null)
            {
                // convert processed samples back to byte array
                byte[] recordBytes = ConvertToByte(samples);

                // write the processed samples to the wave file
                waveWriter.Write(recordBytes, 0, recordBytes.Length);

                // flush the wave writer to ensure data is written to file
                waveWriter.Flush();
            }
        }

        // convert byte array to float array
        private float[] ConvertToFloat(byte[] bytes)
        {
            // ensure the byte array length is even
            int length = bytes.Length / 2;

            // create a float array to hold the samples
            float[] samples = new float[length];

            // convert each pair of bytes to a float sample
            for (int i = 0; i < length; i++)
            {
                // convert two bytes to a short (16-bit signed integer)
                short sample = BitConverter.ToInt16(bytes, i * 2);

                // scale the sample to a float between -1.0 and 1.0
                samples[i] = sample / 32768f;
            }

            return samples;
        }

        // convert float array to byte array
        private byte[] ConvertToByte(float[] samples)
        {
            // byte array to hold the converted samples
            byte[] bytes = new byte[samples.Length * 2];

            // for each sample, convert to byte array
            for (int i = 0; i < samples.Length; i++)
            {
                // scale the float sample to a short (16-bit signed integer)
                short sample = (short)(Math.Max(-1f, Math.Min(1f, samples[i])) * 32767f);

                // convert the short sample to a byte array and store in the output byte array
                byte[] sampleBytes = BitConverter.GetBytes(sample);

                // copy the two bytes into the output byte array
                bytes[i * 2] = sampleBytes[0];
                bytes[i * 2 + 1] = sampleBytes[1];
            }
            return bytes;
        }


        // dispose method to clean up resources
        public void Dispose()
        {
            Stop();
            if (waveWriter != null)
                waveWriter.Dispose();
            if (input != null)
                input.Dispose();
            if (output != null)
                output.Dispose();
        }
    }
}
