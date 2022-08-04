using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Observer
{
    public class Observer : IObserver
    {
        string nameOfObserver;
        public Observer(string name)
        {
            nameOfObserver = name;
        }
        public void Update(int i)
        {
            Console.WriteLine($"{nameOfObserver} has received an alert: Someone has updated myvalue in Subject to {i}");
        }
    }
}
