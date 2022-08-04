namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Observer
{
    public interface ISubject
    {
        void Register(IObserver o);
        void UnRegister(IObserver o);
        void NotifyRegisteredUsers(int i);
    }
}
