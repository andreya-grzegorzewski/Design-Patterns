using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailProxy
{
    public partial class Form1 : Form
    {
        IEmailReader reader;
        public Form1()
        {
            InitializeComponent();
            reader = new SpamFilter();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            EmailMessage message = reader.processMessage(fromTB.Text, subjectTB.Text, bodyTB.Text);

            if (message.isSpam())
                spamLB.Items.Add(message);
            else
                inboxLB.Items.Add(message);
        }

        private void fromTB_Click(object sender, EventArgs e)
        {
            fromTB.Text = "";
        }

        private void subjectTB_Click(object sender, EventArgs e)
        {
            subjectTB.Text = "";
        }

        private void bodyTB_Click(object sender, EventArgs e)
        {
            bodyTB.Text = "";
        }
    }
}
