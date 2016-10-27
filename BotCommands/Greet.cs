using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotCommands
{
    // Greet Command - Say hello to the bot
    class Greet : BotCommand
    {
        // Constructor
        public Greet()
        {
            callCommand = "hello";  // String to call command with

            GreetCommand();         // Register command
        }

        // Private call
        private void GreetCommand()
        {
            commands.CreateCommand(callCommand)
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Hi!");
                });
        }
    }
}
