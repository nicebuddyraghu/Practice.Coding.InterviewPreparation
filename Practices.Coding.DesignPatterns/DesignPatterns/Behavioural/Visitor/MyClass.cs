using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Visitor
{
    public class MyClass : IOriginalInterface
    {
        private int myInt = 5;//Initial or default value;

        public int MyInt
        {
            get { return myInt; }
            set { myInt = value; }
        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"Initial value of the integer: {myInt}");
            visitor.Visit(this);
            Console.WriteLine($"Value of the integer now : {myInt}");
        }
    }
}
