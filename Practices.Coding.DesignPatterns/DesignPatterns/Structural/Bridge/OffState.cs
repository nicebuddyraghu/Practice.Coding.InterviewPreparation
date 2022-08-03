using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Bridge
{
    public class OffState : IState
    {
        public void MoveState()
        {
            Console.Write("Off State");
        }
    }
}
