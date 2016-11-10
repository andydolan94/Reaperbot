# Reaperbot: The edgy discord bot
Reaperbot is a Discord bot written in C# using the unofficial [Discord.Net wrapper](https://github.com/RogueException/Discord.Net). It demonstrates the basic functionality of a common bot in the form of the Overwatch character [Reaper](https://playoverwatch.com/en-us/heroes/reaper/).

### System Prerequisites
Currently, he does not come in a properly distributed .exe form as of yet. For this reason you will require...
- Windows 7 or Greater
- [Discord](https://discordapp.com)
- [Microsoft Visual Studio 2015 with Update 3](https://go.microsoft.com/fwlink/?LinkId=691129) (including C#/.NET during installation)

### How do I set him up?
1. If you have not done so already, you will need to [register an account](https://discordapp.com/register) for yourself on Discord, **not for your bot**.

2. Make sure you have a server that you manage on Discord. This is important as your bots can only join servers that you manage.

3. Navigate to your applications page and create a new app. This will serve as the account for bot. Give it a name (e.g Reaperbot), and if you so wish, an app icon and description, then press the "Create Application" button below.

4. The website will navigate to the overview of the bot. From here, you will need to press the "Create a Bot User" button to access the token. Once complete you should be able to "click to reveal" your bot's token **not his secret**. This is important as it provides a means for the C# application to interface with the bot, save this now. Also on the same page, save the Client ID.

5. Next you will want to navigate to this address with your bot's client ID in the URL. https://discordapp.com/api/oauth2/authorize?client_id=CLIENT_ID_GOES_HERE&scope=bot&permissions=0. From there you should be able to join a server that you manage. After this step, you should be able to see your bot as an offline user.

6. 


### Third Tier Heading?
