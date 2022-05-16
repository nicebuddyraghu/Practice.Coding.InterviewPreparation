using System.Collections.Generic;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    interface IPizza
    {
        IList<string> Toppings { get; }
        double Cost { get; }

        void AddToppings(string topping);
    }
}
