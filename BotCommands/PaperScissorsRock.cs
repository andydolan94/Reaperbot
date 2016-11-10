using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotCommands
{
    class PaperScissorsRock : BotCommand
    {
        public PaperScissorsRock()
        {
            Paper();
            Scissors();
            Rock();
            All();
        }

        // Paper
        private void Paper()
        {
            commands.CreateCommand("paper")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("I chose scissors: YOU LOSE PEASANT!");
                });
        }

        // Scissors
        private void Scissors()
        {
            commands.CreateCommand("scissors")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("I chose rock: YOU LOSE PEASANT!");
                });
        }

        // Rock
        private void Rock()
        {
            commands.CreateCommand("rock")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("I chose paper: YOU LOSE PEASANT!");
                });
        }

        // All
        private void All()
        {
            commands.CreateCommand("paperscissorsrock")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Let me start, I'll choose scissors!");
                    System.Threading.Thread.Sleep(2000);
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Oh wait...");
                });
        }
    }
}
