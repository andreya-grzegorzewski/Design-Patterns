using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public abstract class Aggregate // Aggregate class containing student names
    {
        public List<string> studentNames;

        public abstract Iterator createIterator();
        public abstract Iterator createBackwardIterator();
    }
}
