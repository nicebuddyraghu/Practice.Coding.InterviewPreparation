using System.Collections.Generic;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Iterator
{
    public class Science : ISubjects
    {
        private LinkedList<string> subjects;

        public Science()
        {
            subjects = new LinkedList<string>();
            subjects.AddFirst("Maths");
            subjects.AddFirst("Computer Science");
            subjects.AddFirst("Physics");

        }
        public IIterator CreateIterator()
        {
            return new ScienceIterator(subjects);
        }
    }
}
