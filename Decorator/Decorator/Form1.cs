using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        Player player;

        int monsterDamage = 150; // Default value of damage dealt by the monster each turn
        int monsterHealth = 1000;

        public Form1()
        {
            player = new Party();
            InitializeComponent();

            partyDescLabel.MaximumSize = new Size(400, 0);
            partyDescLabel.AutoSize = true;
        }

        private void healerButton_Click(object sender, EventArgs e)
        {
            Healer h = new Healer(player);
            player = h;
            player.addPlayer(h.getHealthDiff());

            resultLabel.Text = "You have just added a healer to your party.";
            partyDescLabel.Text = "Your party contains " + player.ToString();
            partyHealthLabel.Text = "Your party's cumulative health is " + player.getHealth();
        }

        private void ddButton_Click(object sender, EventArgs e)
        {
            DamageDealer dd = new DamageDealer(player);
            player = dd;
            player.addPlayer(dd.getHealthDiff());

            resultLabel.Text = "You have just added a damage dealer to your party.";
            partyDescLabel.Text = "Your party contains " + player.ToString();
            partyHealthLabel.Text = "Your party's cumulative health is " + player.getHealth();
        }

        private void tankButton_Click(object sender, EventArgs e)
        {
            Tank t = new Tank(player);
            player = t;
            player.addPlayer(t.getHealthDiff());
            
            resultLabel.Text = "You have just added a tank to your party.";
            partyDescLabel.Text = "Your party contains " + player.ToString();
            partyHealthLabel.Text = "Your party's cumulative health is " + player.getHealth();
        }

        private void nextTurnButton_Click(object sender, EventArgs e)
        {
            // Get damage dealt/health remaining values
            int healthRemaining = player.takeDamage(monsterDamage, 0);
            int damageDealt = player.dealDamage(0);
            monsterHealth -= damageDealt;

            // Update display
            resultLabel.Text = "Your party fought the monster.";
            monsterHealthLabel.Text = "The monster's health is " + monsterHealth;
            partyHealthLabel.Text = "Your party's cumulative health is " + healthRemaining;

            if (healthRemaining <= 0)
                resultLabel.Text = "Your party has all died. Sorry for your luck!";
            else if (monsterHealth <= 0)
                resultLabel.Text = "You have killed the monster! Congratulations!";
        }
    }
}
