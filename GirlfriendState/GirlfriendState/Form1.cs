using System;
using System.Drawing;
using System.Windows.Forms;

namespace GirlfriendState
{
    public partial class Form1 : Form
    {
        Girlfriend Andreya = new Girlfriend();

        public Form1()
        {
            InitializeComponent();
            girlfriendStateLabel.MaximumSize = new Size(400, 0);
            girlfriendStateLabel.AutoSize = true;

            girlfriendStateLabel.Text = Andreya.ToString();
        }

        private void feedButton_Click(object sender, EventArgs e)
        {
            Andreya.feed();
            girlfriendStateLabel.Text = Andreya.ToString();
        }

        private void antagonizeButton_Click(object sender, EventArgs e)
        {
            Andreya.antagonize();
            girlfriendStateLabel.Text = Andreya.ToString();
        }

        private void complimentButton_Click(object sender, EventArgs e)
        {
            Andreya.compliment();
            girlfriendStateLabel.Text = Andreya.ToString();
        }

        private void ignoreButton_Click(object sender, EventArgs e)
        {
            Andreya.ignore();
            girlfriendStateLabel.Text = Andreya.ToString();
        }

        private void acknowledgementsButton_Click(object sender, EventArgs e)
        {
            string message = "This app is dedicated to my boyfriend,\n"
                + "who has learned how to play this game in real life.\n"
                + "I wish the best of luck to those of you who have not mastered that ability yet.";
            MessageBox.Show(message, "Acknowledgements");
        }
    }
}
