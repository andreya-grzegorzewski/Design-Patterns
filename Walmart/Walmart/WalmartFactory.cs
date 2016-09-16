using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walmart
{
    public abstract class WalmartFactory // This is the factory for the factory method pattern
    {
        public abstract Product factoryMethod(int id);
    }
}
