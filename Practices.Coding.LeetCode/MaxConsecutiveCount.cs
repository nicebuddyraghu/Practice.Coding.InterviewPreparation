using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MaxConsecutiveCount
    {
        /***
         * 
         * 
         * 
         * 
         * 
         * https://leetcode.com/problems/max-consecutive-ones/submissions/
         * 
         * 
         */

        internal class Solution
        {
            internal int FindMaxConsecutiveOnes(int[] nums)
            {

                int consecutivecount = 0;
                int maxConsecutiveCount = 0;

                foreach (var num in nums)
                {
                    if (num == 1)
                    {
                        consecutivecount++;
                        if (consecutivecount > maxConsecutiveCount)
                            maxConsecutiveCount = consecutivecount;
                    }
                    else
                        consecutivecount = 0;
                }

                return maxConsecutiveCount;
            }
        }
    }
}
