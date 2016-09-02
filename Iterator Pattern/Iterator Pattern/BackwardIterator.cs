using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class BackwardIterator : Iterator // Iterates backwards through names alphabetically
    {
        Aggregate aggregate;
        int itemIndex = 0;
        int numItemsIterated = 0;
        string item;

        public BackwardIterator(ConcreteAggregate agg)
        {
            aggregate = agg;
            item = aggregate.studentNames[0];
        }

        public override string currentItem()
        {
            if (isDone())
                return null;
            return aggregate.studentNames[itemIndex];
        }

        public override string first()
        {
            int i = 0;

            while (i < aggregate.studentNames.Count)
            {
                if (string.Compare(aggregate.studentNames[i], item) > 0)
                {
                    item = aggregate.studentNames[i];
                    itemIndex = i;
                }
                i++;
            }

            numItemsIterated = 1;
            return currentItem();
        }

        private string last()
        {
            int i = 1;
            item = aggregate.studentNames[0];

            while (i < aggregate.studentNames.Count)
            {
                if (string.Compare(aggregate.studentNames[i], item) < 0)
                {
                    item = aggregate.studentNames[i];
                    itemIndex = i;
                }
                i++;
            }

            return currentItem();
        }

        public override bool isDone()
        {
            return (numItemsIterated == aggregate.studentNames.Count);
        }

        public override string next()
        {
            string prevItem = currentItem();
            string nextItem = last();
            int i = 0;
            numItemsIterated++;

            itemIndex = 0;

            if (numItemsIterated == aggregate.studentNames.Count - 1)
            {
                item = last();
                return currentItem();
            }

            while (i < aggregate.studentNames.Count)
            {
                if (string.Compare(aggregate.studentNames[i], prevItem) < 0 && string.Compare(aggregate.studentNames[i], nextItem) > 0)
                {
                    nextItem = aggregate.studentNames[i];
                    itemIndex = i;
                }
                i++;
            }

            item = nextItem;
            return currentItem();
        }
    }
}
