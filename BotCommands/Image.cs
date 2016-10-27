using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reaperbot.BotCommands
{
    // Image Command - Shows a random image
    class Image : BotCommand
    {
        Random rand;            // Initialising the random variable
        string[] reaperImages;  // Initialising the string array for the images

        // Constructor
        public Image()
        {
            callCommand = "reap";   // String to call command with
            rand = new Random();    // New random variable

            // Directories for all the images
            reaperImages = new String[]
            {
                "Images/reaper1.jpg",
                "Images/reaper2.jpg",
                "Images/reaper3.jpg",
                "Images/harvest_reap.jpg"
            };

            ImageCommand(); // Register command
        }

        // Private call
        private void ImageCommand()
        {
            commands.CreateCommand(callCommand)
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();

                    int randomImgIndex = rand.Next(reaperImages.Length);    // Random image index
                    string imgToPost = reaperImages[randomImgIndex];        // Select an image
                    await e.Channel.SendMessage("Time to reap...");         // Let users know that an image is about to be posted
                    await e.Channel.SendFile(imgToPost);                    // Send the image to the chat
                });
        }
    }
}
