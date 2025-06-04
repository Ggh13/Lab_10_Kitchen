using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using NAudio.Wave;
using System;

namespace RestaurantMenu
{
    
    public class BackgroundMusicPlayer : IDisposable
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private LoopStream loopStream;
        private string currentFilePath;


        public float Volume
        {
            get => outputDevice?.Volume ?? 0.5f;
            set
            {
                if (outputDevice != null)
                    outputDevice.Volume = Math.Clamp(value, 0f, 1f);
            }
        }


        public bool IsPlaying => outputDevice?.PlaybackState == PlaybackState.Playing;


        public void Play(string filePath, float volume = 0.5f, bool loop = true)
        {
          
            if (currentFilePath == filePath && IsPlaying)
                return;

            Stop(); 

            try
            {
                currentFilePath = filePath;
                outputDevice = new WaveOutEvent();
                audioFile = new AudioFileReader(filePath);

                if (loop)
                {
                    loopStream = new LoopStream(audioFile);
                    outputDevice.Init(loopStream);
                }
                else
                {
                    outputDevice.Init(audioFile);
                }

                Volume = volume;
                outputDevice.Play();
            }
            catch (Exception ex)
            {
                Dispose();
                throw new Exception($"Ошибка при воспроизведении музыки: {ex.Message}");
            }
        }

  
        public void Pause()
        {
            outputDevice?.Pause();
        }


        public void Resume()
        {
            outputDevice?.Play();
        }


        public void Stop()
        {
            outputDevice?.Stop();
            DisposeResources();
        }

        private void DisposeResources()
        {
            loopStream?.Dispose();
            loopStream = null;

            audioFile?.Dispose();
            audioFile = null;

            outputDevice?.Dispose();
            outputDevice = null;

            currentFilePath = null;
        }

        public void Dispose()
        {
            Stop();
        }

     
        private class LoopStream : WaveStream
        {
            private readonly WaveStream sourceStream;

            public LoopStream(WaveStream sourceStream)
            {
                this.sourceStream = sourceStream;
            }

            public override WaveFormat WaveFormat => sourceStream.WaveFormat;
            public override long Length => sourceStream.Length;

            public override long Position
            {
                get => sourceStream.Position;
                set => sourceStream.Position = value;
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                int totalBytesRead = 0;

                while (totalBytesRead < count)
                {
                    int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);
                    if (bytesRead == 0)
                    {
                        if (sourceStream.Position == 0)
                        {
                            break;
                        }
                        sourceStream.Position = 0;
                    }
                    totalBytesRead += bytesRead;
                }
                return totalBytesRead;
            }
        }
    }
}
