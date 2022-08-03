using System;

namespace Practices.Coding.DesignPatterns.DesignPatterns.Behavioural.Visitor.CompositeExtension
{
    public class Visitor : IVisitor
    {
        public void VisitCompositeElement(CompositeEmployee employee)
        {
            //We will promote them if experience is greater than 15 years
            bool eligibleForPromotion = employee.Experience > 15 ? true : false;
            Console.WriteLine($"{employee.Name} from {employee.Dept} is eligible for promotion {eligibleForPromotion}");
        }


        public void VisitLeafNode(Employee employee)
        {
            //We'll promote them if experience is greater than 12 years
            bool eligibleFroPromotion = employee.Experience > 12 ? true : false;
        }
    }
}
