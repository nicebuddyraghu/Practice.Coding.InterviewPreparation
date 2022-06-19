using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class GameTheory
    {
        public class Solution
        {
            public bool CanJump(int[] nums)
            {
                Console.WriteLine($"Total Numbers {nums.Length}");
                return CanJump(nums, 0);
            }

            Dictionary<int, int> indexDictionary = new Dictionary<int, int>();

            public bool CanJump(int[] nums, int presentposition)
            {
                if (indexDictionary.ContainsKey(presentposition))
                {
                    return false;
                }

                if (presentposition > nums.Length - 1)
                {
                    return false;
                }

                if (presentposition == nums.Length - 1)
                {
                    return true;
                }

                if (nums[presentposition] == 0)
                {
                    return false;
                }

                for (int index = presentposition + nums[presentposition]; index >= presentposition + 1; index--)
                {
                    if (index >= nums.Length - 1)
                        return true;
                    int jumpsteps = nums[index];
                    if (CanJump(nums, index))
                        return true;
                }

                if (!indexDictionary.ContainsKey(presentposition))
                    indexDictionary.Add(presentposition, 0);
                return false;
            }
        }
    }
}
