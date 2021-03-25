using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty_Medium
{
    internal class MajorityElements
    {
        /***
         * 
         * 
         * https://leetcode.com/problems/majority-element-ii/submissions/
         * 
         * 
         */

        internal class Solution
        {
            internal IList<int> MajorityElement(int[] nums)
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

                var majorityElements = new List<int>();

                foreach (var pair in countDictionary)
                {
                    if ((pair.Value) > ((int)(nums.Length / 3)))
                    {
                        majorityElements.Add(pair.Key);
                    }
                }

                return majorityElements;
            }
        }
    }
}
