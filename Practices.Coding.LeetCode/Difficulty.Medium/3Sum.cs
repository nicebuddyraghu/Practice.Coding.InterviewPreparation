using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class _3Sum
    {
        public class Solution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                IList<IList<int>> listOfList = new List<IList<int>>();
                MergeSort mergesort = new MergeSort();
                nums = mergesort.Sort(nums, new int[nums.Length], 0, nums.Length - 1);

                foreach (var num in nums)
                {
                    Console.Write($"{num}->");
                }
                Console.WriteLine();
                for (int i = 0; i < nums.Length; i++)
                {
                    var firstnum = nums[i];
                    if (i > 0 && firstnum == nums[i - 1])
                        continue;
                    for (int j = i + 1, k = nums.Length - 1; j < k;)
                    {
                        if (i != j || i != k || j != k)
                        {
                            var threesum = firstnum + nums[j] + nums[k];
                            if (threesum > 0)
                            {
                                k--;
                            }
                            else if (threesum == 0)
                            {
                                List<int> newlist = new List<int>() { firstnum, nums[j], nums[k] };
                                listOfList.Add(newlist);
                                j++;
                                k--;
                                while (firstnum == nums[j] && j < k)
                                {
                                    j++;
                                }
                                while (nums[k] == nums[k + 1] && k > j)
                                {
                                    k--;
                                }
                            }
                            else
                            {
                                j++;
                            }

                        }
                    }
                }
                return listOfList;
            }
        }

        public class MergeSort
        {
            public int[] Sort(int[] elements, int[] temp, int left, int right)
            {
                if (right > left)
                {
                    int mid = (left + right) / 2;
                    Sort(elements, temp, left, mid);
                    Sort(elements, temp, mid + 1, right);
                    elements = Merge(elements, temp, left, mid + 1, right);
                }

                return elements;
            }

            public int[] Merge(int[] elements, int[] temp, int left, int mid, int right)
            {
                int leftend = mid - 1;
                int tempIndex = left;
                while ((left <= leftend) && (mid <= right))
                {
                    if (elements[left] <= elements[mid])
                    {
                        temp[tempIndex] = elements[left];
                        left++;
                    }
                    else
                    {
                        temp[tempIndex] = elements[mid];
                        mid++;
                    }
                    tempIndex++;
                }

                while (left <= leftend)
                {
                    temp[tempIndex] = elements[left];
                    tempIndex++;
                    left++;
                }

                while (mid <= right)
                {
                    temp[tempIndex] = elements[mid];
                    tempIndex++;
                    mid++;
                }

                for (; right >= 0; right--)
                {
                    elements[right] = temp[right];
                }

                return elements;
            }
        }


    }
}
