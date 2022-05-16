using System;

namespace Practices.Programming.SolidPrinciples.InterfaceSegregationPrinciple.Violation
{
    public class VegPizzaMaker : IPizzaMaker
    {
        /// <summary>
        /// Violation. Class is forced to implete the nonveg pizza. ISP will save this kind of wrong design.
        /// </summary>
        /// <returns></returns>
        public Pizza MakeNonVegPizza()
        {
            throw new NotImplementedException();
        }

        public Pizza MakeVegPizza()
        {
            return new VegPizza(); 
        }
    }
}
