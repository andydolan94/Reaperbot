using Discord;
using Discord.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotCommands
{
    abstract class BotCommand
    {
        public DiscordClient discord = Maincontroller.getDiscordClient();
        public CommandService commands = Maincontroller.getCommandService();
        public string callCommand;
    }
}
