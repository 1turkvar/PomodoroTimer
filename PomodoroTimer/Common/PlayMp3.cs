using NAudio.Wave;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace PomodoroTimer
{
    internal class PlayMp3
    {
        public static Thread audioThread;

        public static void PlayAlert(string filePath)
        {
            using (var audioFile = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFile);
                outputDevice.Play();

                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Thread.Sleep(100);
                }
            }
        }

        public static void PlayMP3(string filePath, int pomodoroDuration)
        {
            Stopwatch stopwatch = new Stopwatch();

            while (true)
            {
                using (var audioFile = new AudioFileReader(filePath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    stopwatch.Restart();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        if (stopwatch.Elapsed.TotalMinutes >= pomodoroDuration)
                        {
                            outputDevice.Stop();
                            break;
                        }
                        Thread.Sleep(100);
                    }
                }

                // Sleep for 1 second before playing the file again
                Thread.Sleep(1000);
            }
        }

        public static void StopPlayingMP3()
        {
            if (audioThread != null && audioThread.IsAlive)
            {
                audioThread.Abort();
            }
        }
    }
}
