using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class MaximumDifferenceBetweenIncreasingElements
    {
        public class Solution
        {
            public int MaximumDifference(int[] nums)
            {

                int maxdifference = 0;
                Dictionary<int, int> maxdifferenceDictionary = new Dictionary<int, int>();
                for (int index = 0; index < nums.Length; index++)
                {
                    if (maxdifferenceDictionary.ContainsKey(nums[index]))
                    {
                        continue;
                    }

                    int difference = 0;
                    for (int nextindex = index + 1; nextindex < nums.Length; nextindex++)
                    {
                        if (nums[nextindex] - nums[index] > difference)
                        {
                            difference = nums[nextindex] - nums[index];
                        }
                    }

                    maxdifferenceDictionary.Add(nums[index], maxdifference);
                    if (maxdifference < difference)
                    {
                        maxdifference = difference;
                    }
                }

                return maxdifference > 0 ? maxdifference : -1;
            }
        }
    }
}
