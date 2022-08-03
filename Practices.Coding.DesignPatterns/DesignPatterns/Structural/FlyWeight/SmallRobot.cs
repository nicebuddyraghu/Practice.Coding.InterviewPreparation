using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.FlyWeight
{
    /// <summary>
    /// A ConcreateFlyWeight Class.
    /// </summary>
    public class SmallRobot : IRobot
    {
        string robotType;
        public string colorOfRobot;

        public string RobotType { get { return robotType; } }

        public SmallRobot(string robotType)
        {
            this.robotType = robotType;
        }
        public void Print()
        {
            Console.WriteLine($"This is a small Robot with color {colorOfRobot}");
        }

        public void SetColor(string colorOfRobot)
        {
            this.colorOfRobot = colorOfRobot;
        }
    }
}
