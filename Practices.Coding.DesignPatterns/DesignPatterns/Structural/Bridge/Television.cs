using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Bridge
{
    public class Television: ElectronicGoods
    {
        //public Television(IState state ) : base(state)
        //{
        //}

        /*Implementation specific:
         * We are delegating the implmentation to the Implmentor object*/
        public override void MoveToCurrentState()
        {
            Console.Write($"Television is functioning at: ");
            state.MoveState();
        }
    }
}
