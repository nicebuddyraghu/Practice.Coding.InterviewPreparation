namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class JalapenoDecorator : PizzaDecorator
    {
        public JalapenoDecorator(IPizza pizza, double toppingCost) : base(pizza, toppingCost)
        {
            AddToppings("Jalapeno");
        }
    }
}
