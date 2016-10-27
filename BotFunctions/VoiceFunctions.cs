using Discord;
using Discord.Audio;
using NAudio.Wave;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotFunctions
{
    class VoiceFunctions
    {
        public static void playAudio(string filePath,
                                     IAudioClient voiceClient,
                                     DiscordClient discord)
        {
            System.Threading.Thread.Sleep(500);

            var channelCount = discord.GetService<AudioService>().Config.Channels;
            var OutFormat = new WaveFormat(48000, 16, channelCount);

            using (var MP3Reader = new Mp3FileReader(filePath))
            using (var resampler = new MediaFoundationResampler(MP3Reader, OutFormat))
            {
                resampler.ResamplerQuality = 60;
                int blockSize = OutFormat.AverageBytesPerSecond / 50;
                byte[] buffer = new byte[blockSize];
                int byteCount;

                while ((byteCount = resampler.Read(buffer, 0, blockSize)) > 0)
                {
                    if (byteCount < blockSize)
                    {
                        for (int i = byteCount; i < blockSize; i++)
                            buffer[i] = 0;
                    }
                    voiceClient.Send(buffer, 0, blockSize);
                }
            }

            System.Threading.Thread.Sleep(1000);
        }

        public static void disconnect(IAudioClient voiceClient)
        {
            voiceClient.Disconnect();
        }
    }
}
