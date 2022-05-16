using System.Collections.Generic;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal abstract class PizzaDecorator : IPizza
    {
        protected IPizza pizza;
        protected double toppingCost = 0;
        public PizzaDecorator(IPizza pizza,double toppingCost)
        {
            this.pizza = pizza;
            this.toppingCost = toppingCost;
        }

        public IList<string> Toppings { get { return pizza.Toppings; } }

        public virtual double Cost => pizza.Cost + this.toppingCost;

        public virtual void AddToppings(string topping)
        {
            pizza.AddToppings(topping);
        }
    }
}
