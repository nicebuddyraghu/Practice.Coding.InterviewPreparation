using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MergeSortedArray
    {

        /****
         * 
         * 
         * https://leetcode.com/problems/merge-sorted-array/
         * 
         */
        internal class Solution
        {
            internal void Merge(int[] nums1, int m, int[] nums2, int n)
            {

                var firstindex = 0;
                var secondindex = 0;
                Queue<int> numsqueue = new Queue<int>();

                if (n == 0)
                    return;

                for (; firstindex < m && secondindex < n;)
                {
                    if (nums1[firstindex] > nums2[secondindex])
                    {
                        numsqueue.Enqueue(nums2[secondindex]);
                        secondindex++;
                    }
                    else if (nums1[firstindex] < nums2[secondindex])
                    {
                        numsqueue.Enqueue(nums1[firstindex]);
                        firstindex++;
                    }
                    else
                    {
                        numsqueue.Enqueue(nums2[secondindex]);
                        numsqueue.Enqueue(nums1[firstindex]);
                        secondindex++;
                        firstindex++;
                    }
                }


                if (firstindex == m && secondindex < n)
                {
                    for (; secondindex < n;)
                    {
                        numsqueue.Enqueue(nums2[secondindex]);
                        secondindex++;
                    }
                }
                else if (firstindex < m && secondindex == n)
                {
                    for (; firstindex < m;)
                    {
                        numsqueue.Enqueue(nums1[firstindex]);
                        firstindex++;
                    }
                }

                int index = 0;
                while (numsqueue.Count > 0 && index < nums1.Length)
                {
                    nums1[index] = numsqueue.Dequeue();
                    index++;
                }
            }
        }
    }
}
