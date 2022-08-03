using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Visitor
{
    public class Visitor : IVisitor
    {
        public void Visit(MyClass myclassElement)
        {
            Console.WriteLine("Visitor is trying to change the integer value.");
        }
    }
}
