using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpedanceBridge
{
    public class Rectangular : ComplexNumber // This is a concrete implementor
    {
        double real;
        double imaginary;

        public Rectangular(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public override ComplexNumber add(ComplexNumber num1, ComplexNumber num2)
        {
            Rectangular rect1 = cast(num1);
            Rectangular rect2 = cast(num2);
            
            double resultReal = rect1.real + rect2.real;
            double resultImaginary = rect1.imaginary + rect2.imaginary;

            return new Rectangular(resultReal, resultImaginary);
        }

        public override ComplexNumber divide(ComplexNumber num1, ComplexNumber num2)
        {
            // No method for dividing complex numbers in rectangular form. Have to use the polar method.
            ComplexNumber p = new Polar(0, 0);
            Polar num = (Polar)p.divide(num1, num2);
            return cast(num);
        }

        public override ComplexNumber multiply(ComplexNumber num1, ComplexNumber num2)
        {
            Rectangular rect1 = cast(num1);
            Rectangular rect2 = cast(num2);

            double f = rect1.real * rect2.real;
            double o = rect1.real * rect2.imaginary;
            double i = rect1.imaginary * rect2.real;
            double l = rect1.imaginary * rect2.imaginary;

            return new Rectangular(f - l, o + i);
        }

        public override ComplexNumber subtract(ComplexNumber num1, ComplexNumber num2)
        {
            Rectangular rect1 = cast(num1);
            Rectangular rect2 = cast(num2);

            double resultReal = rect1.real - rect2.real;
            double resultImaginary = rect1.imaginary - rect2.imaginary;

            return new Rectangular(resultReal, resultImaginary);
        }

        private Rectangular cast(ComplexNumber num)
        {
            if (num is Polar)
                return convertToRectangular((Polar)num);
            else return (Rectangular)num;
        }

        public override string ToString()
        {
            string result = "";

            // If we have a real number...
            if (real != 0)
            {
                result += real.ToString("0.##"); // use "0.##" formatting for two decimal places

                // Handle negative and positive formatting of the imaginary component
                if (imaginary < 0)
                    result += " - " + (imaginary * -1).ToString("0.##") + "j";
                else if (imaginary > 0)
                    result += " + " + imaginary.ToString("0.##") + "j";
                return result;
            }

            // If we have an imaginary component but not a real component...
            else if (imaginary != 0)
                result += imaginary.ToString("0.##") + "j";

            // Otherwise, the number is 0
            if (result == "")
                result = "0";

            return result;
        }

        public double getReal()
        {
            return real;
        }

        public double getImaginary()
        {
            return imaginary;
        }
    }
}
