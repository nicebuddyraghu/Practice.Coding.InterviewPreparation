namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class CheeseBurstDecorator : PizzaDecorator
    {
        public CheeseBurstDecorator(IPizza pizza, double toppingCost) : base(pizza,toppingCost)
        {
            AddToppings("CheeseBurst");
        }
    }
}
