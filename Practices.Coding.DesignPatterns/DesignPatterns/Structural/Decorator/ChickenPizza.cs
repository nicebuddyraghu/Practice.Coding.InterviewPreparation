namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class ChickenPizza : Pizza
    {
        public override double Cost => base.Cost + 100;
    }
}
