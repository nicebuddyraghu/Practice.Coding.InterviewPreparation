namespace Practices.Coding.DesignPatterns.Creational.AbstractFactory
{
    interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
