using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotCommands
{
    // Quote Command - Writes a quote from the character
    class Quote : BotCommand
    {
        Random rand;            // Initialising the random variable
        string[] reaperQuotes;  // Initialising the string array for the images

        // Constructor
        public Quote()
        {
            callCommand = "quote";  // String to call command with
            rand = new Random();    // New random variable

            // List of all the quotes
            reaperQuotes = new string[]
            {
                "Death comes",
                "From the shadows",
                "Re-positioning",
                "Die! Die! Die!",
                "Clearing the area",
                "Death walks among you",
                "Let's just get the job done",
                "The reckoning draws near",
                "What are we waiting for?",
                "Ready for combat operations",
                "Death comes for all",
                "Just stay out of my way",
                "I'll do this alone if I have to",
                "First you listen, then I kill",
                "This is my curse...",
                "I will feast on their souls",
                "This time, I'll finish the job",
                "That which doesn't kill you, makes you stronger",
                "Vengeance shall be mine",
                "Back from the grave...",
                "The grave cannot hold me",
                "I'm unstoppable",
                "The darkness consumes",
                "You can't be serious",
                "Sleep",
                "Another one off the list",
                "Tin cans, a dima a dozen",
                "You never were a good student",
                "Should of pay closer attention",
                "I didn't teach you all my tricks",
                "Never liked you much",
                "This is how it should have been",
                "You always did have a high opinion of yourself",
                "Stupid monkey",
                "Still trying to play hero, monkey?",
                "You chose your side",
                "Better stay out of my way",
                "Death Blossom is ready",
                "What are you looking at",
                "Dead man walking",
                "Give me a break",
                "Haven't I killed you somewhere before",
                "I'm back in black",
                "If it lives, I can kill it",
                "Next",
                "I'm not a psychopath, I'm a high-functioning psychopath",
                "You look like you've seen a ghost",
                "Too easy",
                "Was that all?",
                "Guess you're going back on my list, Ana",
                "I shouldn't be surprised you took his side",
                "I didn't teach you all my tricks",
                "I taught you everything you know",
                "I don't take lessons from you",
                "You look ridiculous",
                "Didn't take",
                "I'll invite them to try",
                "And you sure know how to play boy scout",
                "Looks like we're working together again",
                "Poor Winston. Has to hide away so he doesn't scare the children",
                "Still trying to play hero, monkey?",
                "Overwatch. I'll put an end to your sad story",
                "First you listen, then I kill"
            };

            QuoteCommand(); // Register command
        }

        // Private call
        private void QuoteCommand()
        {
            commands.CreateCommand(callCommand)
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();

                    int randomQuoteIndex = rand.Next(reaperQuotes.Length);  // Random quote index
                    string quoteToPost = reaperQuotes[randomQuoteIndex];    // Select a quote
                    await e.Channel.SendMessage(quoteToPost);               // Send the quote to chat
                });
        }

    }
}
