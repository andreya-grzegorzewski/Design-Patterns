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
        const int MAX_VAL = 10;    // Maximum value for sleep, happiness, work, and health 
        const int STARTING_VAL = 7;
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

            healthLabel.Text = STARTING_VAL + "/" + MAX_VAL;
            sleepLabel.Text = STARTING_VAL + "/" + MAX_VAL;
            happinessLabel.Text = STARTING_VAL + "/" + MAX_VAL;
            workLabel.Text = STARTING_VAL + "/" + MAX_VAL;

            nameLabel.Text = name;
        }

        int happiness = STARTING_VAL;
        int sleep = STARTING_VAL;
        int work = STARTING_VAL;
        int health = STARTING_VAL;

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
            else if (happiness < MAX_VAL)
                happiness++;

            // Then, update the human based on the stresses of everyday life, determined based on the hour of the day.

            Random rng = new Random();
            
            // During the week (Monday = 1, Tuesday = 2, Wednesday = 3, Thursday = 4, Friday = 5)
            if (day >= 1 && day <= 5)
            {
                int thingToChange = rng.Next(4);    // 0 means change health, 1 means sleep, 2 happiness, and 3 work
                int amtToChange = rng.Next(3);      // Change it by zero, one, or two points.

                if (thingToChange == 0)
                    health -= amtToChange;
                else if (thingToChange == 1)
                    sleep -= amtToChange;
                else if (thingToChange == 2)
                    happiness -= amtToChange;
                else
                    work -= amtToChange;
            }

            // It's the weekend, so things change differently.
            else
            {
                int thingToChange = rng.Next(4);    // 0 means change health, 1 means sleep, 2 happiness, and 3 work
                int amtToChange = rng.Next(2);      // Change it by zero or one points; the weekend is less stressful

                if (thingToChange == 0)
                    health -= amtToChange;
                else if (thingToChange == 1)
                    sleep -= amtToChange;
                else if (thingToChange == 2)
                    happiness -= amtToChange;
                else
                    work -= amtToChange;
            }

            // Update the form to display the human's new stats
            changeHealth(health);
            changeSleep(sleep);
            changeHappiness(happiness);
            changeWork(work);

            // Check for death and raise an event if necessary
            if (health < 0)
                humanDied(this, new HumanDeathEventArgs(nameLabel.Text, "undisclosed medical problems"));
            else if (sleep < 0)
                humanDied(this, new HumanDeathEventArgs(nameLabel.Text, "fatigue"));
            else if (happiness < 0)
                humanDied(this, new HumanDeathEventArgs(nameLabel.Text, "sadness"));
            else if (work < 0)
                humanDied(this, new HumanDeathEventArgs(nameLabel.Text, "extreme poverty"));
        }

        public bool isDead()
        {
            return (health < 0 || sleep < 0 || happiness < 0 || work < 0);
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

        public void changeHealth(int health)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Int32>(changeHealth), new object[] { health });
                return;
            }
            healthLabel.Text = Convert.ToString(health) + "/" + Convert.ToString(MAX_VAL);
        }

        public void changeSleep(int sleep)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Int32>(changeSleep), new object[] { sleep });
                return;
            }
            sleepLabel.Text = Convert.ToString(sleep) + "/" + Convert.ToString(MAX_VAL);
        }

        public void changeHappiness(int happiness)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Int32>(changeHappiness), new object[] { happiness });
                return;
            }
            happinessLabel.Text = Convert.ToString(happiness) + "/" + Convert.ToString(MAX_VAL);
        }

        public void changeWork(int work)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Int32>(changeWork), new object[] { work });
                return;
            }
            workLabel.Text = Convert.ToString(work) + "/" + Convert.ToString(MAX_VAL);
        }

    }
}
