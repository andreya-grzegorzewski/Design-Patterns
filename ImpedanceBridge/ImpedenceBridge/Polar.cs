using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpedanceBridge
{
    public class Polar : ComplexNumber // this is a concrete implementor
    {
        double r; // The magnitude of the number as represented by a line
        double theta; // The angle the line makes with the positive x axis

        public Polar(double r, double theta)
        {
            this.r = r;

            while (theta > 180)
                theta -= 360;
            while (theta < -180)
                theta += 360;

            this.theta = theta;
        }

        public override ComplexNumber add(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber r = new Rectangular(0, 0);
            Rectangular num = (Rectangular)r.add(num1, num2);
            return cast(num);
        }

        public override ComplexNumber divide(ComplexNumber num1, ComplexNumber num2)
        {
            Polar p1 = cast(num1);
            Polar p2 = cast(num2);

            double theta = p1.theta - p2.theta;
            double r = p1.r / p2.r;

            while (theta > 180)
                theta -= 360;

            while (theta < -180)
                theta += 360;

            return new Polar(r, theta);
        }

        public override ComplexNumber multiply(ComplexNumber num1, ComplexNumber num2)
        {
            Polar p1 = cast(num1);
            Polar p2 = cast(num2);

            double r = p1.r * p2.r;
            double theta = p1.theta + p2.theta;

            // Want theta in the range of [-180, 180]
            while (theta > 180)
                theta -= 360;

            while (theta < -180)
                theta += 360;

            return new Polar(r, theta);
        }

        public override ComplexNumber subtract(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber r = new Rectangular(0, 0);
            Rectangular num = (Rectangular)r.subtract(num1, num2);
            return cast(num);
        }

        private Polar cast(ComplexNumber num)
        {
            if (num is Polar)
                return (Polar)num;
            else return convertToPolar((Rectangular)num);
        }

        public override string ToString()
        {
            if (r == 0)
                return "0";

            return r.ToString("0.##") + " <" + theta.ToString("0.##");
        }

        public double getR()
        {
            return r;
        }

        public double getTheta()
        {
            return theta;
        }
    }
}
