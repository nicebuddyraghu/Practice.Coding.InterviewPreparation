using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.FlyWeight
{
    /// <summary>
    /// A Concrete FlyWeight Class.
    /// </summary>
    public class LargeRobot: IRobot
    {
        string robotType;
        public string colorOfRobot;
        public string RobotType { get { return robotType; } }

        public LargeRobot(string robotType)
        {
            this.robotType = robotType;
        }
        public void Print()
        {
            Console.WriteLine($"This is a large Robot with color {colorOfRobot}");
        }

        public void SetColor(string colorOfRobot)
        {
            this.colorOfRobot = colorOfRobot;
        }
    }
}
