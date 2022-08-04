using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Command.MultipleRecievers
{
    public class AdditionCommand : ICommand
    {
        private IReceiver receiver;
        public AdditionCommand(IReceiver recv)
        {
            receiver = recv;
        }
        public void Do()
        {
            receiver.OptionalTasksPriorProcessing();
            receiver.Add2WithNumber();
            receiver.OptionalTaskPostProcessing();
        }

        public void UnDo()
        {
            Console.WriteLine("Trying undoing addition....");
            receiver.Remove2FromNumber();
            Console.WriteLine("Undo request processed.");
        }
    }
}
