using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpedanceBridge
{
    interface ImpedanceMath // This is the Abstraction interface
    {
        ComplexNumber getParallelImpedance(ComplexNumber num1, ComplexNumber num2);
        ComplexNumber getSeriesImpedance(ComplexNumber num1, ComplexNumber num2);
    }
}
