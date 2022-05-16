namespace Practices.Coding.DesignPatterns.Creational.FactoryMethod
{
    internal class TigerAnimalFactory : IAnimalFactory
    {
        public IAnimal Create()
        {
            return new TigerAnimal();
        }
    }
}
