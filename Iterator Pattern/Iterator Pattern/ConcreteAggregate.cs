using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    public class ConcreteAggregate : Aggregate // ConcreteAggregate class
    {
        public ConcreteAggregate()
        {
            studentNames = new List<string>();
        }
        public override Iterator createIterator()
        {
            return new ConcreteIterator(this);
        }
        public override Iterator createBackwardIterator()
        {
            return new BackwardIterator(this);
        }
    }
}
