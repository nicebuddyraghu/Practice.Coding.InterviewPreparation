namespace Practices.Programming.SolidPrinciples.InterfaceSegregationPrinciple
{
    class FilterCoffeeMachine : IFilterCoffeeMachine
    {
        public void AddGroundCoffee(GroundCoffee groundCoffee)
        {
        }

        public CoffeeDrink BrewFilterCoffee()
        {
            return new CoffeeDrink();
        }
    }
}
