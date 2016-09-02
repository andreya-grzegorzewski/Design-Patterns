using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator_Pattern
{
    public partial class Form1 : Form
    {
        Aggregate agg = new ConcreteAggregate();
        Iterator iter;
        Iterator backIter;

        public Form1()
        {
            InitializeComponent();
            populateAggregate();
        }

        private void populateAggregate()
        {
            agg.studentNames.Add("Sara Landis");
            agg.studentNames.Add("Sam Loomis");
            agg.studentNames.Add("Sarah Beasley");
            agg.studentNames.Add("Cheyenne Cogan");
            agg.studentNames.Add("Stephanie Martin");
            agg.studentNames.Add("Rebecca Newton");
            agg.studentNames.Add("Cameron Criss");
            agg.studentNames.Add("Jonathan Landis");
            agg.studentNames.Add("Ben Johns");
            agg.studentNames.Add("Connor Ney");
            agg.studentNames.Add("Calvin Vonderwell");
            agg.studentNames.Add("Carl Senger");
            agg.studentNames.Add("Connor Hull");
            agg.studentNames.Add("Nathan Bemus");
            agg.studentNames.Add("Jordan Loyd");
            agg.studentNames.Add("Jaired Birks");
            agg.studentNames.Add("Andreya Grzegorzewski");
            agg.studentNames.Add("Shawn Stevens");
            agg.studentNames.Add("Adam Grim");
            agg.studentNames.Add("Megan Stephan");
            agg.studentNames.Add("Cheyann Schadewald");
            agg.studentNames.Add("Kasey Schroeder");
            agg.studentNames.Add("Maya Bell");
            agg.studentNames.Add("Taryn Rupp");
            agg.studentNames.Add("Demaje Jones");
            agg.studentNames.Add("Austin Douglas");
            agg.studentNames.Add("Brandon Meadows");
            agg.studentNames.Add("Taylor Cole");
            agg.studentNames.Add("Kaylee Schoepe");
            agg.studentNames.Add("Katie Shiveley");
            agg.studentNames.Add("Molly Chow");
            agg.studentNames.Add("Jean Daniel");
            agg.studentNames.Add("Abby Altizer");
            agg.studentNames.Add("Steven Cole");
            agg.studentNames.Add("Jack Raney");
            agg.studentNames.Add("Joe Peace");
            agg.studentNames.Add("Justin Harris");
            agg.studentNames.Add("Devan Bianco");

            iter = agg.createIterator();
            backIter = agg.createBackwardIterator();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iterForwardButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();

            iter.first();
            while (!iter.isDone())
            {
                namesListBox.Items.Add(iter.currentItem());
                iter.next();
            }
        }

        private void iterBackwardButton_Click(object sender, EventArgs e)
        {
            namesListBox.Items.Clear();

            backIter.first();
            while (!backIter.isDone())
            {
                namesListBox.Items.Add(backIter.currentItem());
                backIter.next();
            }
        }
    }
}
