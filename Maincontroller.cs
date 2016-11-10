using Discord;
using Discord.Commands;
using Discord.Audio;

using Reaperbot.BotCommands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot
{
    // The Maincontroller
    public class Maincontroller
    {
        static DiscordClient discord;   // The client object
        static CommandService commands; // The commands object

        // Constructor
        public Maincontroller()
        {
            // Constructing the Client
            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            // Assigning the prefix
            discord.UsingCommands(x =>
            {
                x.PrefixChar = '!';
                x.AllowMentionPrefix = true;
            });

            // Setting up audio
            discord.UsingAudio(x =>
            {
                x.Mode = AudioMode.Outgoing;    // Sending audio outgoing
            });

            // Getting the commands service from the discord object
            commands = discord.GetService<CommandService>();

            // Commands
            BotCommand image = new Image();
            BotCommand quote = new Quote();
            BotCommand purge = new Purge();
            BotCommand greet = new Greet();
            BotCommand speak = new Speak();
            BotCommand paperScissorsRock = new PaperScissorsRock();

            // The connection - Requires a token to access the account
            discord.ExecuteAndWait(async () =>
            {
            await discord.Connect(      System.Configuration.ConfigurationManager.AppSettings["reaperbot_api_key"],
                                        TokenType.Bot);
            });
        }

        // Getter for the Discord Client
        public static DiscordClient getDiscordClient()
        {
            return discord;
        }

        // Getter for the Command Service
        public static CommandService getCommandService()
        {
            return commands;
        }

        // Logs things to the console
        private void Log(Object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
