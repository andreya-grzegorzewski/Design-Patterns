using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateMethodRMS
{
    public partial class Form1 : Form
    {
        Waveform waveform;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Get the variables for the constructor
            double startPoint = Double.Parse(startTB.Text);
            double endPoint = Double.Parse(endTB.Text);
            string expression = waveformTB.Text;

            // Instantiate waveform depending on the type of expression
            if (expression.Contains("cos"))
                waveform = new CosWaveform(startPoint, endPoint, expression);
            else if (expression.Contains("sin"))
                waveform = new SinWaveform(startPoint, endPoint, expression);
            else
                waveform = new LinearWaveform(startPoint, endPoint, expression);

            // Set label text to the result
            rmsLabel.Text = String.Format("{0:N2}", waveform.getRMS());
        }
    }
}
