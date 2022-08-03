using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Visitor.CompositeExtension
{
    public class Employee : IEmployee
    {
        private string name;
        private string dept;

        private int yearsOfExperience;
        public Employee(string name, string dept, int experience)
        {
            this.name = name;
            this.dept = dept;
            this.yearsOfExperience = experience;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitLeafNode(this);
        }

        public void PrintStructures()
        {
            Console.WriteLine($"{name} works in {dept} Experience: {yearsOfExperience} years"); 
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Dept
        {
            get
            {
                return this.dept;
            }
        }

        public int Experience
        {
            get { return this.yearsOfExperience; }
        }
    }
}
