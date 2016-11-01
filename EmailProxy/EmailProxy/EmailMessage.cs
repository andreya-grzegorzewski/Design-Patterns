using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProxy
{
    class EmailMessage
    {
        string sender;
        string subject;
        DateTime sendTime;
        bool messageIsSpam;
        string displayText;

        public EmailMessage(string sender, string subject, DateTime sendTime, bool isSpam, string displayText)
        {
            this.sender = sender;
            this.subject = subject;
            this.displayText = displayText;
            this.sendTime = sendTime;
            messageIsSpam = isSpam;
        }

        public override string ToString()
        {
            return displayText;
        }

        public bool isSpam()
        {
            return messageIsSpam;
        }
    }
}
