using System.Collections.Generic;
using System.Linq;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Iterator
{
    public class ScienceIterator : IIterator
    {
        private LinkedList<string> subjects;
        private int position;

        public ScienceIterator(LinkedList<string> subjects)
        {
            this.subjects = subjects;
            position = 0;
        }

        public void First()
        {
            position = 0;
        }
        
        public string Next()
        {
            return subjects.ElementAt<string>(position++);
        }

        public bool IsDone()
        {
            if (position < subjects.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string CurrentItem()
        {
            return subjects.ElementAt(position);
        }
    }
}
