# Reaperbot: The edgy discord bot
Reaperbot is a Discord bot written in C# using the unofficial [Discord.Net wrapper](https://github.com/RogueException/Discord.Net). It demonstrates the basic functionality of a common bot in the form of the Overwatch character [Reaper](https://playoverwatch.com/en-us/heroes/reaper/).

## System Prerequisites
- Windows 7 or Greater
- [Discord](https://discordapp.com)
- The latest version of [Microsoft Visual Studio](https://www.visualstudio.com) (including C#/.NET during installation)

## How do I set him up?
1. If you have not done so already, you will need to [register an account](https://discordapp.com/register) for yourself on Discord, **not for your bot**.

2. Make sure you have a server that you manage on Discord. This is important as your bots can only join servers that you manage.

3. Navigate to your applications page and create a new app. This will serve as the account for bot. Give it a name (e.g Reaperbot), and if you so wish, an app icon and description, then press the "Create Application" button below.

4. The website will navigate to the overview of the bot. From here, you will need to press the "Create a Bot User" button to access the token. Once complete you should be able to "click to reveal" your bot's token **not his secret**. This is important as it provides a means for the C# application to interface with the bot, save this now. Also on the same page, save the Client ID.

5. Next you will want to navigate to this address with your bot's client ID in the URL. https://discordapp.com/api/oauth2/authorize?client_id=CLIENT_ID_GOES_HERE&scope=bot&permissions=0. From there you should be able to join a server that you manage. After this step, you should be able to see your bot as an offline user.

6. You will then need to Navigate to Reaperbot's directory (i.e this). You should be able to see a file named "AppExample.config"; make a copy of this file and name it "App.config". Once copied, edit it and place the bot token you saved earlier in where it says "bot_token". Save and exit.

7. Open Reaperbot.sln, build and run it. If all is successful, the command window should display the name of the server it has been added to.

## What cool tricks can he do?
These commands can simply be entered into a text channel.

#### !hello
Say hello to Reaperbot. _He's quite polite in this instance._

#### !quote
When commanded, Reaperbot will quote one of his edgy voice.

#### !reap
Displays a random image of himself _doin' his thing._

#### !paperscissorsrock, !paper, !scissors and !rock
Play a game of paper, scissors, rock with Reaperbot. Be warned, he doesn't play fair.

#### !speak
Whilst connnected in a voice channel, you can summon Reaperbot to speak one of his voice lines.

#### !purge
Reaperbot will delete the last 100 messages in a text channel.
