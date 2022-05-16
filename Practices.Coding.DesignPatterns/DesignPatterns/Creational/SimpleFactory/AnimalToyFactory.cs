namespace Practices.Coding.DesignPatterns.Creational.SimpleFactory
{
    internal class AnimalToyFactory : IAnimalToyFactory
    {
        public IAnimalToy Create(AnimalToyType animalToyType)
        {
            //Note:This code subject to change base on adding or removing the products from the code.
            //This code breaks the Open closed Principle.
            switch(animalToyType)
            {
                case AnimalToyType.Lion:
                    return new LionToy();
                case AnimalToyType.Tiger:
                    return new TigerToy();
                default:
                    return null;
            }
        }
    }
}
