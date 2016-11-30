using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodRMS
{
    public class SinWaveform : TrigWaveform // This is a ConcreteClass
    {
        public SinWaveform(double startPoint, double endPoint, string expression) 
            : base(startPoint, endPoint, expression) { }

        public override double getIntegral()
        {
            double coefOutside = getCoefOutside();
            double coefInside = getCoefInside() * 2;

            // Use the identity sin^2(u) = (1 - cos(2u)) / 2
            double firstTerm = 0.5 * (endPoint - startPoint);
            double secondTerm = 0.5 / coefInside * Math.Sin(coefInside * startPoint) - 0.5 / coefInside * Math.Sin(coefInside * endPoint);

            return coefOutside * (firstTerm + secondTerm);
        }
    }
}
