namespace Practices.Coding.LeetCode.DesignPatterns.Creational.FactoryMethod
{
    internal class TigerAnimalFactory : IAnimalFactory
    {
        public IAnimal Create()
        {
            return new TigerAnimal();
        }
    }
}
