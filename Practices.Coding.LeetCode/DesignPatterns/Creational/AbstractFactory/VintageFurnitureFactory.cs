namespace Practices.Coding.LeetCode.DesignPatterns.Creational.AbstractFactory
{
    internal class VintageFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VintageChair();
        }

        public ISofa CreateSofa()
        {
            return new VintageSofa();
        }
    }
}
