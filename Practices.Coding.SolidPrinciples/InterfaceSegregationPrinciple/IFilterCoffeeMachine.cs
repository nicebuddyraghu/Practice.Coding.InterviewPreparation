using System;
using System.Collections.Generic;
using System.Text;

namespace Practices.Programming.SolidPrinciples.InterfaceSegregationPrinciple
{
    public interface IFilterCoffeeMachine : ICoffeeMachine
    {
        CoffeeDrink BrewFilterCoffee();
    }
}
