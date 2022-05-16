using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Decorator
{
    internal class PizzaMaker
    {
        public void MakePizza()
        {
            var chickenPizza = new ChickenPizza();
            var toppingPizza = new OnionsDecorator(chickenPizza, 10);
            var olivesToppingPizza = new OlivesDecorator(toppingPizza, 20);
            var jalapenoDecoratorPizza = new JalapenoDecorator(olivesToppingPizza, 30);

            Console.WriteLine(jalapenoDecoratorPizza.Cost);
        }
    }
}
