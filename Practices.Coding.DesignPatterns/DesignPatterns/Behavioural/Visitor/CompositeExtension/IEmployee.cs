namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Visitor.CompositeExtension
{
    public interface IEmployee
    {
        void PrintStructures();
        void Accept(IVisitor visitor);
    }
}
