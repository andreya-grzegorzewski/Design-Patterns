using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodRMS
{
    public abstract class Waveform // This is an AbstractClass
    {
        protected double startPoint; // The start time of one period
        protected double endPoint;   // The end time of one period
        protected string expression; // The expression of the wave

        public Waveform(double startPoint, double endPoint, string expression)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            this.expression = expression;
        }
        
        // This is the primitive operation. It returns the definite integral of the square of the expression.
        public abstract double getIntegral(); 

        public double getRMS() // This is the template method
        {
            // The equation for the RMS value is the square root of one over the time interval 
            // times the integral of the square of the expression.
            double integral = getIntegral();
            return Math.Sqrt(integral / (endPoint - startPoint));
        }
    }
}
