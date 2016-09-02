using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public abstract class Iterator // Iterator class
    {
        public abstract string first();
        public abstract string next();
        public abstract bool isDone();
        public abstract string currentItem();
    }
}
