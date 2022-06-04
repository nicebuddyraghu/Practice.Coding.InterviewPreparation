using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * https://leetcode.com/problems/next-permutation/
     * Brute force. Need efficient solution.
     * 
     * 
     */
    public class NextPermutation
    {
        public class Solution
        {
            public void NextPermutation(int[] nums)
            {

                bool isnextPermutation = false;

                for (int index = nums.Length - 1; index >= 1; index--)
                {
                    if (nums[index] > nums[index - 1])
                    {
                        int nextindex = GetNextMax(nums[index - 1], nums, index + 1);
                        Console.WriteLine(nextindex);
                        if (nextindex == -1)
                        {
                            Swap(nums, index, index - 1);
                        }
                        else
                        {
                            Swap(nums, nextindex, index - 1);
                        }

                        Sort(nums, index);
                        isnextPermutation = true;
                        return;
                    }
                }

                if (isnextPermutation == false)
                {
                    for (int index = 0, rightindex = nums.Length - 1; index <= (nums.Length - 1) / 2; index++, rightindex--)
                    {
                        var temp = nums[index];
                        nums[index] = nums[rightindex];
                        nums[rightindex] = temp;
                    }
                }
            }
            public void Sort(int[] nums, int start)
            {
                for (int index = start; index < nums.Length; index++)
                {
                    for (int moveindex = index + 1; moveindex < nums.Length; moveindex++)
                    {
                        if (nums[index] > nums[moveindex])
                        {
                            Swap(nums, index, moveindex);
                        }
                    }
                }
            }

            public int GetNextMax(int number, int[] nums, int start)
            {
                int nextmax = Int32.MaxValue;
                int nextmaxindex = -1;
                for (int index = start; index < nums.Length; index++)
                {
                    if ((nums[index] - number) > 0 && (nums[index]) > number && (nums[index] - number) < nextmax)
                    {
                        nextmax = nums[index];
                        nextmaxindex = index;
                    }
                }

                return nextmaxindex;
            }


            public void Swap(int[] nums, int index1, int index2)
            {
                var temp = nums[index1];
                nums[index1] = nums[index2];
                nums[index2] = temp;
            }
        }
    }
}
