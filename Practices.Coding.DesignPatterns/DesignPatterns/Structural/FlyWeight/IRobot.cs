namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.FlyWeight
{
    /// <summary>
    /// The Flyweight Interface.
    /// </summary>
    public interface IRobot
    {
        public string RobotType { get; }
        void Print();
    }
}
