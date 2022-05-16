namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class OnionsDecorator : PizzaDecorator
    {
        public OnionsDecorator(IPizza pizza, double toppingCost) : base(pizza, toppingCost)
        {
            AddToppings("Onions");
        }
    }
}
