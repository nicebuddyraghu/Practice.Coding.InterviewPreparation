namespace Practices.Coding.LeetCode.DesignPatterns.Creational.SimpleFactory
{
    interface IAnimalToyFactory
    {
        IAnimalToy Create(AnimalToyType animalToyType);
    }
}
