<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpedanceBridge
{
    class ImpedanceMathImp : ImpedanceMath // This is my abstraction implementation
    {
        ComplexNumber cn = new Rectangular(0, 0);

        public ImpedanceMathImp(ComplexNumber cn)
        {
            this.cn = cn;
        }

        public ComplexNumber getParallelImpedance(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber numerator = cn.multiply(num1, num2);
            ComplexNumber denominator = cn.add(num1, num2);
            ComplexNumber result = cn.divide(numerator, denominator);
            return result;
        }

        public ComplexNumber getSeriesImpedance(ComplexNumber num1, ComplexNumber num2)
        {
            return cn.add(num1, num2);
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
    class ImpedanceMathImp : ImpedanceMath // This is my abstraction implementation
    {
        ComplexNumber cn = new Rectangular(0, 0);

        public ImpedanceMathImp(ComplexNumber cn)
        {
            this.cn = cn;
        }

        public ComplexNumber getParallelImpedance(ComplexNumber num1, ComplexNumber num2)
        {
            ComplexNumber numerator = cn.multiply(num1, num2);
            ComplexNumber denominator = cn.add(num1, num2);
            ComplexNumber result = cn.divide(numerator, denominator);
            return result;
        }

        public ComplexNumber getSeriesImpedance(ComplexNumber num1, ComplexNumber num2)
        {
            return cn.add(num1, num2);
        }
    }
}
>>>>>>> 88b3bb86f0023c3d90cb1289cbf85b29dcd65cfb
