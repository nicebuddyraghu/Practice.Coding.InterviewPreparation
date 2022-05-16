namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class PaneerPizza : Pizza
    {
        public override double Cost => base.Cost+40;
    }
}
