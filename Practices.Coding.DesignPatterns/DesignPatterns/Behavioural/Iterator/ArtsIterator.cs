namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Iterator
{
    public class ArtsIterator : IIterator
    {
        private string[] subjects;
        private int position;
        public ArtsIterator(string[] subjects)
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
            return subjects[position++];
        }
        public bool IsDone()
        {
            if (position < subjects.Length)
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
            return subjects[position];
        }
    }
}
