namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Command.MultipleRecievers
{
    public interface IReceiver
    {
        //it will add 2 with a number.
        void Add2WithNumber();
        
        //it will substract 2 from a number.
        void Remove2FromNumber();

        //Optional Methods
        //Preprocessing Tasks
        void OptionalTasksPriorProcessing();
        //PostProcessing Tasks.
        void OptionalTaskPostProcessing();
    }
}
