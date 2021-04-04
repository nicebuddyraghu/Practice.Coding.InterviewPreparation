using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class SumOfUniqueElements
    {
        internal class Solution
        {
            internal int SumOfUnique(int[] nums)
            {

                Dictionary<int, bool> uniquedictionary = new Dictionary<int, bool>();

                foreach (var num in nums)
                {
                    if (uniquedictionary.ContainsKey(num))
                    {
                        uniquedictionary[num] = false;
                    }
                    else
                        uniquedictionary.Add(num, true);
                }

                var sum = 0;
                foreach (var pair in uniquedictionary)
                {
                    if (uniquedictionary[pair.Key] == true)
                        sum += pair.Key;
                }

                return sum;
            }
        }
    }
}
