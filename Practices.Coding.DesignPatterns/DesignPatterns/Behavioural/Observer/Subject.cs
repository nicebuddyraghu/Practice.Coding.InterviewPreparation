using System.Collections.Generic;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Observer
{
    public class Subject : ISubject
    {
        List<IObserver> observerList = new List<IObserver>();
        private int flag;
        public int Flag
        {
            get { return flag; }
            set {
                flag = value;
                //Flag value changed. So notify observers.
                NotifyRegisteredUsers(flag);
                }
        }
        public void NotifyRegisteredUsers(int i)
        {
            foreach(var observer in observerList)
            {
                observer.Update(i);
            }
        }

        public void Register(IObserver o)
        {
            observerList.Add(o);
        }

        public void UnRegister(IObserver o)
        {
            observerList.Remove(o);
        }
    }
}
