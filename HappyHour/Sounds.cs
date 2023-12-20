using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHour
{
    internal class Sounds
    {
        private static WaveOutEvent waveOut = new WaveOutEvent();
        public static async Task PlaySoundAsync()
        {
            await Task.Run(() =>
            {
                string soundFilePath = "C:\\Users\\Hjalm\\source\\repos\\HappyHour\\HappyHour\\Copacabana - Barry Manilow 8bit Jazz Version.wav";

                try
                {
                    using (var audioFile = new AudioFileReader(soundFilePath))
                    {
                        waveOut.Init(audioFile);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            Thread.Sleep(100);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error playing sound: {ex.Message}");
                }
            });
        }
    }
}
