namespace Practices.Coding.LeetCode.DesignPatterns.Creational.FactoryMethod
{
    internal class BearAnimalFactory : IAnimalFactory
    {
        public IAnimal Create()
        {
            return new BearAnimal();
        }
    }
}
