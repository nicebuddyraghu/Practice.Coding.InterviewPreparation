namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Command
{
    public class Invoke
    {
        ICommand commandToBePerformed;
        public void SetCommand(ICommand command)
        {
            this.commandToBePerformed = command;
        }

        public void ExecuteCommand()
        {
            commandToBePerformed.Do();
        }
    }
}
