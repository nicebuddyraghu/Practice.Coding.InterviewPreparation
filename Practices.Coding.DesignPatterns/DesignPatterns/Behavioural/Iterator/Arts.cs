namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Iterator
{
    public class Arts : ISubjects
    {
        private string[] subjects;
        public Arts()
        {
            subjects = new [] { "Bengali", "English" };
        }

        public IIterator CreateIterator()
        {
            return new ArtsIterator(subjects);
        }
    }
}
