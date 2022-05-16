namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class MozarillaPizza : Pizza
    {
        public override double Cost => base.Cost + 30;
    }
}
