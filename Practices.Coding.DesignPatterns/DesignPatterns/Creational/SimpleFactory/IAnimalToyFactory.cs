namespace Practices.Coding.DesignPatterns.Creational.SimpleFactory
{
    interface IAnimalToyFactory
    {
        IAnimalToy Create(AnimalToyType animalToyType);
    }
}
