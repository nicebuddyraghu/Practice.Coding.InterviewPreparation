using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Composite
{
    public class Employee : IEmployee
    {
        private string name;
        private string dept;

        public Employee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
        }

        public void PrintStructures()
        {
            Console.WriteLine($"{name} works in {dept}");
        }
    }
}
