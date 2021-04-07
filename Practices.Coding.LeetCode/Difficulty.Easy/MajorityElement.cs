using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MajorityElement
    {
        /***
         * 
         * 
         * https://leetcode.com/problems/majority-element/submissions/
         * 
         * 
         */

        internal class Solution
        {
            internal int MajorityElement(int[] nums)
            {

                var countDictionary = new Dictionary<int, int>();

                for (var index = 0; index < nums.Length; index++)
                {
                    if (countDictionary.ContainsKey(nums[index]))
                    {
                        countDictionary[nums[index]] = countDictionary[nums[index]] + 1;
                    }
                    else
                    {
                        countDictionary.Add(nums[index], 1);
                    }
                }

                int majorityElement = 0;
                int majorityElementCount = 0;

                foreach (var pair in countDictionary)
                {
                    if (pair.Value > majorityElementCount)
                    {
                        majorityElement = pair.Key;
                        majorityElementCount = pair.Value;
                    }
                }

                return majorityElement;
            }
        }
    }
}
