namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Command
{
    public class RedoCommand : ICommand
    {
        private Receiver receiver;
        public RedoCommand(Receiver recv)
        {
            receiver = recv;
        }
        public void Do()
        {
            //Perform any optional task prior to ReDo
            receiver.OptionalTaskPriorToRedo();
            //Call Redo in receiver now.
            receiver.PerformRedo();
        }
    }
}
