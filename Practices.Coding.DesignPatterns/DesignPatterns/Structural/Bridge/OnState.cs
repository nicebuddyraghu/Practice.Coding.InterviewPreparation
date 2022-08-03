using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Bridge
{
    public class OnState : IState
    {
        public void MoveState()
        {
            Console.WriteLine("On State");
        }
    }
}
