using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class GoodPairs
    {
        /**
         * 
         * https://leetcode.com/problems/number-of-good-pairs/submissions/
         * 
         * 
         */
        internal class Solution
        {
            internal int NumIdenticalPairs(int[] nums)
            {

                int totalgoodpairs = 0;

                for (int firstindex = 0; firstindex < nums.Length - 1; firstindex++)
                {
                    for (int secondindex = firstindex + 1; secondindex < nums.Length; secondindex++)
                    {
                        if (nums[firstindex] == nums[secondindex])
                        {
                            totalgoodpairs++;
                        }
                    }
                }

                return totalgoodpairs;
            }
        }
    }
}
