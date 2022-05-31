using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * https://leetcode.com/problems/find-the-duplicate-number/
     * 
     */
    public class Solution
    {
        public int FindDuplicate(int[] nums)
        {
            System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();
            list.Sort();
            for (int index = 0; index <= nums.Length - 1; index++)
            {
                if (nums[Math.Abs(nums[index])] >= 0)
                {
                    nums[Math.Abs(nums[index])] = (-1) * nums[Math.Abs(nums[index])];
                }
                else
                {
                    return Math.Abs(nums[index]);
                }
            }
            return -1;
        }
    }
}
