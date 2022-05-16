using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Facade
{
    public class RobotHands
    {
        public void SetMilanoHands() { Console.WriteLine("The robot will have EH1 Milano hands"); }
        public void SetRobonautHands() { Console.WriteLine("The robot will have Robonaut hands"); }
        public void ResetMilanoHands()
        {
            Console.WriteLine("EH1 Milano hands are about to be destroyed");
        }
        public void ResetRobonautHands()
        {
            Console.WriteLine("Robonaut hands are about to be destroyed");
        }
    }
}
