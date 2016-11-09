using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpedanceBridge
{
    public partial class Form1 : Form
    {
        ImpedanceMath im;
        public Form1()
        {
            InitializeComponent();
            im = new ImpedanceMathImp(new Rectangular(0, 0));
            rectangularRB.Checked = true;
            operationCB.Items.Add("is in series with");
            operationCB.Items.Add("is in parallel with");
        }

        private void rectangularRB_CheckedChanged(object sender, EventArgs e)
        {
            im = new ImpedanceMathImp(new Rectangular(0, 0));
        }

        private void polarRB_CheckedChanged(object sender, EventArgs e)
        {
            im = new ImpedanceMathImp(new Polar(0, 0));
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            ComplexNumber num1 = parseTbText(numberTB1.Text);
            ComplexNumber num2 = parseTbText(numberTB2.Text);
            ComplexNumber result;

            if (operationCB.SelectedIndex == 0)
                result = im.getSeriesImpedance(num1, num2);
            else result = im.getParallelImpedance(num1, num2);

            resultTB.Text = result.ToString();
        }

        private ComplexNumber parseTbText(string text)
        {
            char[] textArray = text.ToCharArray();

            // If the number is polar...
            if (text.Contains("<"))
            {
                // Find the end index of r
                int stopIndexOfR = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (textArray[i] == '<' || textArray[i] == ' ')
                    {
                        stopIndexOfR = i - 1;
                        break;
                    }
                }

                // Create r by using parse and substring
                double r = Double.Parse(text.Substring(0, stopIndexOfR + 1));

                // Find the start index of theta
                int startIndexOfTheta = text.Length;
                for (int i = stopIndexOfR + 1; i < text.Length; i++)
                {
                    if (textArray[i] != '<' && textArray[i] != ' ')
                    {
                        startIndexOfTheta = i;
                        break;
                    }
                }

                // Create theta
                double theta = Double.Parse(text.Substring(startIndexOfTheta));

                // Create and return a Polar object with r and theta
                Polar result = new Polar(r, theta);
                return result;                
            }

            // Otherwise, the number is in rectangular form
            else
            {
                double real = 0;
                double imaginary = 0;

                // If the number doesn't have a j in it, it's just a real number
                if (!text.Contains("j"))
                    real = Double.Parse(text);

                // If the text doesn't have a space and does contain a j, it's just an imaginary component
                else if (!text.Contains(" "))
                    imaginary = Double.Parse(text.Substring(0, text.Length - 1));

                // Otherwise, we have real and imaginary.
                else
                {
                    // Find the stop index of the real portion
                    int stopIndexOfReal = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (textArray[i] == ' ' || textArray[i] == '+' || textArray[i] == '-')
                        {
                            stopIndexOfReal = i;
                            break;
                        }
                    }

                    // Create the real number
                    real = Double.Parse(text.Substring(0, stopIndexOfReal + 1));

                    // Find the start index of the imaginary component
                    if (text.Contains("j"))
                    {
                        int startIndexOfImaginary = -1;
                        for (int i = stopIndexOfReal; i < text.Length; i++)
                        {
                            if (textArray[i] != ' ' && textArray[i] != '+' && textArray[i] != '-')
                            {
                                startIndexOfImaginary = i;
                                break;
                            }
                        }

                        // Create the imaginary component
                        if (startIndexOfImaginary != -1)
                            imaginary = Double.Parse(text.Substring(startIndexOfImaginary, text.Length - startIndexOfImaginary - 1));

                        // Check to see if the imaginary part should be negative
                        if (text.Substring(1, text.Length - 1).Contains("-"))
                            imaginary *= -1;
                    }
                }

                // Create and return the Rectangular object
                Rectangular result = new Rectangular(real, imaginary);
                return result;
            }
        }
    }
}
