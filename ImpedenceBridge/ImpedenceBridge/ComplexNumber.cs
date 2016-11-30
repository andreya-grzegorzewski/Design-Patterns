<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpedanceBridge
{
    public abstract class ComplexNumber // This is the Implementor interface
    {
        public abstract ComplexNumber add(ComplexNumber num1, ComplexNumber num2);
        public abstract ComplexNumber subtract(ComplexNumber num1, ComplexNumber num2);
        public abstract ComplexNumber multiply(ComplexNumber num1, ComplexNumber num2);
        public abstract ComplexNumber divide(ComplexNumber num1, ComplexNumber num2);

        public Rectangular convertToRectangular(Polar p)
        {
            double real = p.getR() * Math.Cos(p.getTheta() / 180 * Math.PI);
            double imaginary = p.getR() * Math.Sin(p.getTheta() / 180 * Math.PI);
            return new Rectangular(real, imaginary);
        }

        public Polar convertToPolar(Rectangular rect)
        {
            double real = rect.getReal();
            double imag = rect.getImaginary();

            double r = Math.Sqrt(real * real + imag * imag);
            double theta = Math.Atan(imag / real) * 180 / Math.PI;

            return new Polar(r, theta);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpedanceBridge
{
    public abstract class ComplexNumber // This is the Implementor interface
    {
        public abstract ComplexNumber add(ComplexNumber num1, ComplexNumber num2);
        public abstract ComplexNumber subtract(ComplexNumber num1, ComplexNumber num2);
        public abstract ComplexNumber multiply(ComplexNumber num1, ComplexNumber num2);
        public abstract ComplexNumber divide(ComplexNumber num1, ComplexNumber num2);

        public Rectangular convertToRectangular(Polar p)
        {
            double real = p.getR() * Math.Cos(p.getTheta() / 180 * Math.PI);
            double imaginary = p.getR() * Math.Sin(p.getTheta() / 180 * Math.PI);
            return new Rectangular(real, imaginary);
        }

        public Polar convertToPolar(Rectangular rect)
        {
            double real = rect.getReal();
            double imag = rect.getImaginary();

            double r = Math.Sqrt(real * real + imag * imag);
            double theta = Math.Atan(imag / real) * 180 / Math.PI;

            return new Polar(r, theta);
        }
    }
}
>>>>>>> 9824bc48f28c297a78a894cac520c949b5304575
