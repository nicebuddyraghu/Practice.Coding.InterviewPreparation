using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.CSharp
{
    internal class UsingSets
    {
        /*
         *  A HashSet is a List with no duplicate members.

            Because a HashSet is constrained to contain only unique entries, the internal structure is optimised for searching (compared with a list) - it is considerably faster

            Adding to a HashSet returns a boolean - false if addition fails due to already existing in Set

            Can perform mathematical set operations against a Set: Union/Intersection/IsSubsetOf etc.

            HashSet doesn't implement IList only ICollection

            You cannot use indices with a HashSet, only enumerators.
         * 
         * 
         */

        public void UseHashSet()
        {
            HashSet<int> oddSet = new HashSet<int> { 1, 2, 3, };
            HashSet<int> eventSet = new HashSet<int>();

            for(int x=1; x<=10;x++)
            {
                if (x % 2 == 0)
                    eventSet.Add(x);
                else
                    oddSet.Add(x);
            }

            oddSet.UnionWith(eventSet);
            DisplaySet(oddSet);
        }

        public void DisplaySet(HashSet<int> set)
        {
            foreach(var i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}
