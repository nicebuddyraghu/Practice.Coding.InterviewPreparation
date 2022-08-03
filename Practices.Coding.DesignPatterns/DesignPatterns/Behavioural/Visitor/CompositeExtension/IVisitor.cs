namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Visitor.CompositeExtension
{
    public interface IVisitor
    {
        void VisitCompositeElement(CompositeEmployee employees);
        void VisitLeafNode(Employee employee);
    }
}
