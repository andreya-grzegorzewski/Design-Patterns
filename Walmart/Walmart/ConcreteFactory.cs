using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walmart
{
    public class ConcreteFactory : WalmartFactory // This is the concrete factory as well as a subsystem for the facade pattern
    {
        public override Product factoryMethod(int id)
        {
            return new ConcreteProduct(id);
        }
    }
}
