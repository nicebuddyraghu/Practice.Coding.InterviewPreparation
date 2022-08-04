namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Iterator
{
    public interface IIterator
    {
        void First(); //Reset to first element
        string Next(); // Get next element
        bool IsDone(); // End of collection check.
        string CurrentItem(); //Retrieve Current Item.
    }
}
