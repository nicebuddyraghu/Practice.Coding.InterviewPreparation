using System;
using System.Collections.Generic;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Visitor.CompositeExtension
{
    public class CompositeEmployee : IEmployee
    {
        private string name;
        private string dept;
        private int yearsOfExperience;
        private List<IEmployee> controls;

        public CompositeEmployee(string name, string dept, int experience)
        {
            this.name = name;
            this.dept = dept;
            this.yearsOfExperience = experience;
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

        public string Name
        {
            get
            {
                return this.name;
            }
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

        public List<IEmployee> Contorls
        {
            get { return this.controls; }
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompositeElement(this);
        }

        public void PrintStructures()
        {
            Console.WriteLine($"{name} works in {dept} Experience: {yearsOfExperience} years");
            foreach(var e in controls)
            {
                e.PrintStructures();
            }
        }
    }
}
