using System;
using System.Collections.Generic;
using System.Text;

namespace Practices.Programming.SolidPrinciples.InterfaceSegregationPrinciple
{
    public class ExpressoCoffeeMachine : IExpressoCoffee
    {
        public void AddGroundCoffee(GroundCoffee groundCoffee)
        {
            
        }

        public CoffeeDrink BrewExpresso()
        {
            return new CoffeeDrink();
        }
    }
}
