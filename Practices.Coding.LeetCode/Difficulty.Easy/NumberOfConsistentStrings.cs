using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class NumberOfConsistentStrings
    {
        internal class Solution
        {
            internal int CountConsistentStrings(string allowed, string[] words)
            {

                Dictionary<char, bool> alloweddictionary = new Dictionary<char, bool>();

                foreach (char ch in allowed)
                {
                    alloweddictionary.Add(ch, true);
                }

                int consistentcount = 0;
                foreach (var word in words)
                {
                    bool isConsitent = true;
                    foreach (char letter in word)
                    {
                        if (!alloweddictionary.ContainsKey(letter))
                        {
                            isConsitent = false;
                            break;
                        }
                    }

                    if (isConsitent)
                        consistentcount++;
                }

                return consistentcount;
            }
        }
    }
}
