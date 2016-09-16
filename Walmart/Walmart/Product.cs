using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walmart
{
    public interface Product // This is the product interface
    {
        double getPrice();
        string getDescription();
        int getID();
        double getSalePrice();
    }
}
