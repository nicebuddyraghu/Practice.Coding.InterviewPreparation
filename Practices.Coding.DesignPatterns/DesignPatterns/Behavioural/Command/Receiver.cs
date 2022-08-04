using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Command
{
    public class Receiver
    {
        public void PerformUndo()
        {
            Console.WriteLine("Executing-UndoCommand");
        }

        public void PerformRedo()
        {
            Console.WriteLine("Executing-RedoCommand");
        }

        //Optional method-if you want to perform any prior tasks before Undo.
        public void OptionalTaskPriorToUndo()
        {
            Console.WriteLine("Executing-Optional Tasks prior to execute undo command");
        }

        //Optional method-if you want to perform any prior tasks before Redo.
        public void OptionalTaskPriorToRedo()
        {
            Console.WriteLine("Executing-Optional Tasks Prior to execute redo command");
        }
    }
}
