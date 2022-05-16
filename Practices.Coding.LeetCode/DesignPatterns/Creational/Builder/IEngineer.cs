namespace Practices.Coding.LeetCode.DesignPatterns.Creational.Builder
{
    interface IEngineer
    {
        IHouseBuilder Builder { get; } //builder instance.
        IHouse ConstructHouse(IHouseBuilder builder); //product.
    }
}
