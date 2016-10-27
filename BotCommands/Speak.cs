using Discord;
using Discord.Audio;
using NAudio;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using Reaperbot.BotFunctions;

using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotCommands
{
    // Speak Command - Bot says something in the voice channel
    class Speak : BotCommand
    {
        IAudioClient voiceClient;
        string[] reaperLines;
        ConcurrentQueue<string> audioQueue;
        bool isBeingEmptied;
        Random rand;

        // Constructor
        public Speak()
        {
            callCommand = "speak";                  // String to call command with
            rand = new Random();
            reaperLines = new string[]
            {
                "Audio/reaper_another_one_off_the_list.mp3",
                "Audio/reaper_boy_scout.mp3",
                "Audio/reaper_clearing_the_area.mp3",
                "Audio/reaper_dead_man_walking.mp3",
                "Audio/reaper_death_comes.mp3",
                "Audio/reaper_death_walks_among_you.mp3",
                "Audio/reaper_from_the_shadows.mp3",
                "Audio/reaper_high_opinion.mp3",
                "Audio/reaper_ill_do_this_alone.mp3",
                "Audio/reaper_im_unstoppable.mp3",
                "Audio/reaper_my_ultimate_is_ready.mp3",
                "Audio/reaper_never_liked_you_much.mp3",
                "Audio/reaper_stupid_monkey.mp3",
                "Audio/reaper_this_is_how_it_should_have_been.mp3",
                "Audio/reaper_ultimate.mp3",
                "Audio/reaper_vengeance_shall_be_mine.mp3",
                "Audio/reaper_what_are_we_waiting_for.mp3",
                "Audio/reaper_you_cant_be_serious.mp3"
            };
            audioQueue = new ConcurrentQueue<string>();
            isBeingEmptied = false;

            SpeakCommand();                         // Register command
        }

        // Private call
        private void SpeakCommand()
        {
            commands.CreateCommand(callCommand)
                .Do(async (e) =>
                {
                    // Pick a random quote
                    int randomFileIndex = rand.Next(reaperLines.Length);
                    string fileToPost = reaperLines[randomFileIndex];

                    // Add file path to queue
                    audioQueue.Enqueue(fileToPost);

                    // If queue is not already undergoing the process of emptying its contents
                    if (!isBeingEmptied)
                    {
                        // Raise flag
                        isBeingEmptied = true;

                        // Connect to the voice channel
                        voiceClient = await discord.GetService<AudioService>()
                            .Join(e.User.VoiceChannel);

                        // Dequeuing until the queue is empty
                        string queueItem;
                        while (audioQueue.TryDequeue(out queueItem))
                        {
                            VoiceFunctions.playAudio(queueItem, voiceClient, discord);
                        }

                        // Disconnecting from voice channel
                        await voiceClient.Disconnect();

                        // Lower flag
                        isBeingEmptied = false;
                    }
                });
        }
    }
}
