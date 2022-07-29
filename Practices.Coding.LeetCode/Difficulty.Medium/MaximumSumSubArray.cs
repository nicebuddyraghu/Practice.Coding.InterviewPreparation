using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class MaximumSumSubArray
    {
        public class Solution
        {
            public int MaxSubArray(int[] nums)
            {

                int maxsum = Int32.MinValue;
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    maxsum = Math.Max(sum, maxsum);
                    if (sum < 0) sum = 0;
                }

                return maxsum;
            }
        }
    }
}
