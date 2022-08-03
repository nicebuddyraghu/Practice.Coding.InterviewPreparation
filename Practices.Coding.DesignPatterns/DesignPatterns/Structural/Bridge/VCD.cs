using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Bridge
{
    public class VCD : ElectronicGoods
    {
        //public VCD(IState state) : base(state)
        //{
        //}
        /* Implmentation specifig:
         * We are delegating the implementation to the Implementor object*/
        public override void MoveToCurrentState()
        {
            Console.Write($"VCD is functioning at : ");
            state.MoveState();
        }
    }
}
