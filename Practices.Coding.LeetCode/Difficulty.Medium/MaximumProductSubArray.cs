using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class MaximumProductSubArray
    {
        public class Solution
        {
            public int MaxProduct(int[] nums)
            {

                if (nums.Length == 0) return 0;

                int maxproduct = nums[0];
                int tempmax = 1;
                int tempmin = 1;

                for (int i = 0; i < nums.Length; i++)
                {
                    int current = nums[i];

                    var temp_max = Math.Max(current, Math.Max(tempmax * current, tempmin * current));
                    var temp_min = Math.Min(Math.Min(tempmax * current, tempmin * current), current);
                    tempmax = temp_max;
                    tempmin = temp_min;
                    maxproduct = Math.Max(tempmax, maxproduct);
                }

                return maxproduct;
            }
        }
    }
}
