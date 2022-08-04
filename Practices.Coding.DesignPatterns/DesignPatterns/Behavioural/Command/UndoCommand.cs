using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Command
{
    public class UndoCommand : ICommand
    {
        private Receiver receiver;
        public UndoCommand(Receiver recv)
        {
            receiver = recv;
        }
        public void Do()
        {
            //Perform any optional task prior to UnDo
            receiver.OptionalTaskPriorToUndo();
            //Call UnDo in receiver now.
            receiver.PerformUndo();
        }
    }
}
