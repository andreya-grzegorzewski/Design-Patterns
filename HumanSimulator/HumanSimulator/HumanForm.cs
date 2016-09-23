using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanSimulator
{
    public partial class HumanForm : Form
    {
        const int MAX_VAL = 25;    // Maximum value for sleep, happiness, work, and health 
        public delegate void HumanDeathEventHandler(object sender, HumanDeathEventArgs e);
        public event HumanDeathEventHandler humanDied;

        public HumanForm()
        {
            InitializeComponent();
        }

        int healthHours;
        int sleepHours;
        int happinessHours;
        int workHours;

        public HumanForm(string name, int healthHours, int sleepHours, int happinessHours, int workHours)
        {
            InitializeComponent();

            this.healthHours = healthHours;
            this.sleepHours = sleepHours;
            this.happinessHours = happinessHours;
            this.workHours = workHours;

            healthLabel.Text = MAX_VAL + "/" + MAX_VAL;
            sleepLabel.Text = MAX_VAL + "/" + MAX_VAL;
            happinessLabel.Text = MAX_VAL + "/" + MAX_VAL;
            workLabel.Text = MAX_VAL + "/" + MAX_VAL;

            nameLabel.Text = name;
        }

        int happiness = MAX_VAL;
        int sleep = MAX_VAL;
        int work = MAX_VAL;
        int health = MAX_VAL;

        public void updateHuman(int hour, int day)
        {
            // First, update human based on how much time per day the human spends doing each item.
            // The first x hours of the day, starting at midnight, are devoted to sleep
            if (hour < sleepHours && sleep < MAX_VAL)
                sleep++;
            // Then the human goes to work
            else if (hour < sleepHours + workHours && work < MAX_VAL)
                work++;
            // Then the human takes care of health concerns like eating, exercising, etc.
            else if (hour < sleepHours + workHours + healthHours && health < MAX_VAL)
                health++;
            // Finally, the human relaxes until bedtime
            else
                happiness++;

            // Then, update the human based on the stresses of everyday life, determined based on the hour of the day.
            // During the week (Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5)
            if (day >= 1 && day <= 5)
            {
                // If it's getting late, or during the last few hours of the work day, the human will start to get sleepy...
                if ((hour >= 14 && hour <= 17) || hour >= 22)
                    sleep--;
                // During the work day, the human will develop work-related problems.
                if (hour >= 8 && hour <= 17)
                    work--;
                // The human makes bad health choices at mealtimes and loses health points.
                if (hour == 7 || hour == 12 || hour == 19)
                    health--;
                // The human feels sad early in the morning until the workday is almost done.
                if (hour >= 7 && hour <= 14)
                    happiness--;
            }

            // It's the weekend, so things change differently.
            else
            {
                // The human stays up late and gets sleepy.
                if (hour < 3 || hour >= 22)
                    sleep--;
                // The human still has some work-related things to do on the weekend.
                if (hour >= 12 && hour <= 15)
                    work--;
                // The human makes unsound nutritional choices.
                if (hour == 10 || hour == 13 || hour == 18)
                    health--;
                // The human doesn't want to do the work, and gets a little sad about it during the middle of the work session.
                if (hour == 13 || hour == 14)
                    happiness--;
            }

            // Update the form to display the human's new stats
            healthLabel.Text = Convert.ToString(health) + "/" + MAX_VAL;
            sleepLabel.Text = Convert.ToString(sleep) + "/" + MAX_VAL;
            happinessLabel.Text = Convert.ToString(happiness) + "/" + MAX_VAL;
            workLabel.Text = Convert.ToString(work) + "/" + MAX_VAL;

            // Check for death and raise an event if necessary
            if (health < 0)
                humanDied(this, new HumanDeathEventArgs(this.nameLabel.Text, "undisclosed medical problems"));
            else if (sleep < 0)
                humanDied(this, new HumanDeathEventArgs(this.nameLabel.Text, "fatigue"));
            else if (happiness < 0)
                humanDied(this, new HumanDeathEventArgs(this.nameLabel.Text, "sadness"));
            else if (work < 0)
                humanDied(this, new HumanDeathEventArgs(this.nameLabel.Text, "extreme poverty"));
        }

        public class HumanDeathEventArgs : EventArgs
        {
            private string name;

            public string deadHumanName
            {
                get { return name; }
                set { name = value; }
            }

            private string cause;

            public string causeOfDeath
            {
                get { return cause; }
                set { cause = value;}
            }

            public HumanDeathEventArgs(string name, string cause)
            {
                deadHumanName = name;
                causeOfDeath = cause;
            }
        }

    }
}
