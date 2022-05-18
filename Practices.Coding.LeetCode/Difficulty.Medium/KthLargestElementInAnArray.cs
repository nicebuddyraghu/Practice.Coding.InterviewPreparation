using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class KthLargestElementInAnArray
    {
        public class Solution
        {
            public int FindKthLargest(int[] nums, int k)
            {
                int[] sortedList = Sort(nums, 0, nums.Length - 1);
                foreach (var element in nums)
                {
                    Console.Write($"=<{element}");
                }
                Console.WriteLine();
                return nums[nums.Length - k];
            }

            private int[] Sort(int[] nums, int start, int last)
            {
                if (start < last)
                {
                    int mid = (start + last) / 2;
                    Sort(nums, start, mid);
                    Sort(nums, mid + 1, last);
                    nums = Merge(nums, start, mid + 1, last);
                }

                return nums;
            }

            private int[] Merge(int[] nums, int start, int mid, int last)
            {
                int leftindex = start;
                int rightindex = mid;
                int[] tempList = new int[nums.Length];
                int tempIndex = start;
                while (leftindex <= mid - 1 && rightindex <= last)
                {
                    if (nums[leftindex] > nums[rightindex])
                    {
                        tempList[tempIndex] = nums[rightindex];
                        rightindex++;
                    }
                    else
                    {
                        tempList[tempIndex] = nums[leftindex];
                        leftindex++;
                    }
                    tempIndex++;
                }

                while (leftindex <= mid - 1)
                {
                    tempList[tempIndex] = nums[leftindex];
                    leftindex++;
                    tempIndex++;
                }

                while (rightindex <= last)
                {
                    tempList[tempIndex] = nums[rightindex];
                    rightindex++;
                    tempIndex++;
                }

                rightindex = last;

                while (rightindex >= start)
                {
                    nums[rightindex] = tempList[rightindex];
                    rightindex--;
                }

                return nums;
            }
        }
    }
}
