using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    public class TwoSum
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
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
