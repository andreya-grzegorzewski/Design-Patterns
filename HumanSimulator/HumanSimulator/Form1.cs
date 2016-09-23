﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace HumanSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Timers.Timer clock = new System.Timers.Timer(1500);
        private static int day;
        private static int hour;

        HumanForm[] humans = new HumanForm[50]; // Can keep track of 50 humans at once
        int numHumans = 0;

        private void createHumanButton_Click(object sender, EventArgs e)
        {
            int healthHours = Convert.ToInt32(healthTB.Text);
            int sleepHours = Convert.ToInt32(sleepTB.Text);
            int happinessHours = Convert.ToInt32(happinessTB.Text);
            int workHours = Convert.ToInt32(workTB.Text);

            if (healthHours + sleepHours + happinessHours + workHours != 24)
                MessageBox.Show("Please make sure that the numbers in the boxes add up to 24.");

            else
            {
                if (!clock.Enabled)
                {
                    clock.Elapsed += clockEvent;
                    clock.Start();

                    day = 1;
                    hour = 0;
                }
                string name = nameTB.Text;

                HumanForm newHuman = new HumanForm(name, healthHours, sleepHours, happinessHours, workHours);
                humans[numHumans] = newHuman;
                numHumans++;
                newHuman.Location = new Point(this.Location.X + this.Size.Width + 10,
                                              this.Location.Y);
                newHuman.humanDied += new HumanForm.HumanDeathEventHandler(humanFormDeath);
                newHuman.Show();
            }


        }

        // Update clock and update human forms

        private void clockEvent(Object source, ElapsedEventArgs e)
        {
            hour++;
            if (hour == 24)
            {
                hour = 0;
            }

            this.changeHour(hour);

            if (hour == 0)
            {
                day++;
                dayLabel.Text = "Day " + Convert.ToString(day);
            }

            for (int i = 0; i < humans.Length; i++)
                humans[i].updateHuman(hour, day);
        }

        void humanFormDeath(object sender, HumanForm.HumanDeathEventArgs e)
        {
            string deathString = "Oops! " + e.deadHumanName + " died of " + e.causeOfDeath + ".";
            deadHumansLB.Items.Add(deathString);
        }

        public void changeHour(int hour)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<Int32>(changeHour), new object[] { hour });
                return;
            }
            hourLabel.Text = Convert.ToString(hour) + ":00";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
