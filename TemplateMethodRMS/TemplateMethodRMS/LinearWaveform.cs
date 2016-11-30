using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodRMS
{
    public class LinearWaveform : Waveform // This is a ConcreteClass
    {
        public LinearWaveform(double startPoint, double endPoint, string expression) 
            : base(startPoint, endPoint, expression) { }

        public override double getIntegral()
        {
            double coef = 1;

            // Get the coefficient - for example, in 2*x, get 2
            if (expression.Contains("*"))
            {
                int length = expression.Length - 2;
                coef = Double.Parse(expression.Substring(0, length));
            }

            coef *= coef;

            // The integral of the square of a linear expression is: coef * x^3 / 3
            return coef / 3 * ((endPoint * endPoint * endPoint) - (startPoint * startPoint * startPoint));
        }
    }
}
