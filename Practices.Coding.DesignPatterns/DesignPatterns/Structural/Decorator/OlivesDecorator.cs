namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class OlivesDecorator : PizzaDecorator
    {
        public OlivesDecorator(IPizza pizza, double toppingCost) : base(pizza, toppingCost)
        {
            AddToppings("Olives");
        }
    }
}
