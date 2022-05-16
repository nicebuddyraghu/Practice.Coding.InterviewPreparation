namespace Practices.Programming.SolidPrinciples.InterfaceSegregationPrinciple.Violation
{
    public interface IPizzaMaker
    {
        Pizza MakeVegPizza();
        Pizza MakeNonVegPizza();
    }
}
