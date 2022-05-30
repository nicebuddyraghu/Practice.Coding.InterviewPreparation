using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode
{
    internal class TwoSum
    {
        internal class Solution
        {
            internal int[] TwoSum(int[] nums, int target)
            {
                var dictionary = new Dictionary<int,int>();
                
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dictionary.ContainsKey(target - nums[i]))
                    {
                        return new int[] { Convert.ToInt32(dictionary[target - nums[i]]), i };
                    }

                    if (!dictionary.ContainsKey(nums[i]))
                        dictionary.Add(nums[i], i);
                }

                return new int[] { };
            }
        }
    }
}
