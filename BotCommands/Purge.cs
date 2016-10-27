using Discord;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotCommands
{
    // Purge Command - Removes messages from the chat
    class Purge : BotCommand
    {
        // Constructor
        public Purge()
        {
            callCommand = "purge";  // String to call command with
            PurgeCommand();         // Register command
        }

        // Private call
        private void PurgeCommand()
        {
            commands.CreateCommand(callCommand)
                // Check if the user sending this message is an Administrator
                .AddCheck((cm, u, ch) => u.ServerPermissions.Administrator)
                .Do(async (e) =>
                {
                    // Let users know that the chat is about to be purged
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Death Blossom is ready in 10 seconds");

                    // Sleep for 10 Seconds
                    System.Threading.Thread.Sleep(10000);

                    // Aquiring the messages to delete
                    Message[] messagesToDelete;
                    messagesToDelete = await e.Channel.DownloadMessages(100);

                    // Notifying everyone that the purge has begun
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Die! Die! Die!");

                    // Delete the aquired messages
                    await e.Channel.DeleteMessages(messagesToDelete);
                });
        }
    }
}
