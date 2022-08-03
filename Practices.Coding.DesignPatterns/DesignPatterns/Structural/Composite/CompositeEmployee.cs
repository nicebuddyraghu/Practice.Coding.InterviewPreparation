using System;
using System.Collections.Generic;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Structural.Composite
{
    public class CompositeEmployee : IEmployee
    {
        private string name;
        private string dept;
        private List<IEmployee> controls;

        public CompositeEmployee(string name, string dept)
        {
            this.name = name;
            this.dept = dept;
            controls = new List<IEmployee>();
        }

        public void Add(IEmployee e)
        {
            controls.Add(e);
        }

        public void Remove(IEmployee e)
        {
            controls.Remove(e);
        }

        public void PrintStructures()
        {
            Console.Write($"{name} works in {dept}");
            foreach(var e in controls)
            {
                e.PrintStructures();
            }
        }
    }
}
