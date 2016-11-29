using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodRMS
{
    public abstract class TrigWaveform : Waveform // This is an AbstractClass
    {
        public TrigWaveform(double startPoint, double endPoint, string expression) 
            : base(startPoint, endPoint, expression) { }

        // This is a template method. It gets the coefficient that appears
        // before the trig function, if there is one.
        // For example, in 3*cos(4*x), this method returns 3.
        public double getCoefOutside()
        {
            double coefOutside = 1;

            if (expression.Substring(0, expression.IndexOf('(')).Contains("*")) // checks to see if there is an asterisk before "sin" or "cos"
            {
                int length = expression.IndexOf('*');
                coefOutside = Double.Parse(expression.Substring(0, length));

                coefOutside *= coefOutside;

                int substringIndex = expression.IndexOf('*') + 5;
                expression = expression.Substring(substringIndex, expression.Length - substringIndex - 1); // For example, changes expression from n*cos(3*x) to 3*x
            }
            else
                expression = expression.Substring(4, expression.Length - 5);

            return coefOutside;
        }

        // This is a template method. It gets the coefficient inside the 
        // parenthesis of the trig function, if there is one.
        // For example, in 3*cos(4*x), this method returns 4.
        public double getCoefInside()
        {
            double coefInside = 1;

            if (expression.Contains("*"))
                coefInside = Double.Parse(expression.Substring(0, expression.IndexOf('*')));

            return coefInside;
        }

        // The primitive operation getIntegral does not need to be listed here since TrigWaveform is an abstract class.
        // The method is inherited from Waveform and implemented in CosWaveform and SinWaveform.
    }
}
