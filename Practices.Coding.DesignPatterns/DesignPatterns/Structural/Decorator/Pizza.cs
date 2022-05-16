using System.Collections.Generic;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal abstract class Pizza : IPizza
    {
        public IList<string> Toppings { get; }

        public virtual double Cost => 100;

        public virtual void AddToppings(string topping)
        {
            if (!Toppings.Contains(topping))
            {
                Toppings.Add(topping);
            }
        }
    }
}
