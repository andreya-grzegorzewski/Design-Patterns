using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProxy
{
    class SpamFilter : IEmailReader // This is the proxy class
    {
        public EmailMessage processMessage(string sender, string subject, string body)
        {
            EmailMessage message;
            EmailReader reader = new EmailReader(); // RealSubject reference

            // If the message is spam, return a placeholder EmailMessage
            // So the user knows he received spam without being able to see the message contents
            string bodyLC = body.ToLower();
            if (bodyLC.Contains("click here") || bodyLC.Contains("follow this link") || bodyLC.Contains("special offer") || bodyLC.Contains("limited time only"))
            {
                subject = "[SPAM]";
                string displayText = "Spam from " + sender + " sent at " + DateTime.Now + ". Subject: " + subject;
                message = new EmailMessage(sender, subject, DateTime.Now, true, displayText);
            }
            // If the message isn't spam, process it with EmailReader (RealSubject)
            else
                message = reader.processMessage(sender, subject, body);

            return message;
        }
    }
}