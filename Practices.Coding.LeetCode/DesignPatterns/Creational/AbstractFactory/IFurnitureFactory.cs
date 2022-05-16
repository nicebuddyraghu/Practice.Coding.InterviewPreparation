namespace Practices.Coding.LeetCode.DesignPatterns.Creational.AbstractFactory
{
    interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
