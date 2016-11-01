using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProxy
{
    class EmailReader : IEmailReader // This is the RealSubject class
    {
        public EmailMessage processMessage(string sender, string subject, string body)
        {
            string[,] contacts = new string[,] { { "a-grzegorzewski@onu.edu", "Andreya Grzegorzewski"}, { "d-retterer@onu.edu", "Prof. Retterer"}, { "j-birks@onu.edu", "Jaired Birks"},
                {"m-bishop.1@onu.edu", "Matt Bishop" }, {"tgrz@roadrunner.com", "Dad" }, {"teresagrz@roadrunner.com", "Mom" }, {"teresag@potter-inc.com", "Mom" } };

            // Check to see if the sender is in the contacts list
            for (int i = 0; i < contacts.Length / 2; i++)
            {
                if (contacts[i, 0] == sender)
                    sender = contacts[i, 1];
            }
            
            // Get the first ten words of the message for display purposes
            string[] bodyWords = body.Split();
            string firstTen = "";

            for (int i = 0; i < 10; i++)
            {
                if (i == bodyWords.Length)
                    break;

                firstTen += bodyWords[i] + " ";
            }

            if (bodyWords.Length > 10)
                firstTen += ". . .";

            // Set display text and return a new EmailMessage
            string displayText = "Message from " + sender + " sent at " + DateTime.Now + ";    Subject: " + subject + ";    Message reads " + firstTen;
            return new EmailMessage(sender, subject, DateTime.Now, false, displayText);
        }
    }
}
