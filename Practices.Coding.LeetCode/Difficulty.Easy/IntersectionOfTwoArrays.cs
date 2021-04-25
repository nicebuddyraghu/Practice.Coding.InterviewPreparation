using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class IntersectionOfTwoArrays
    {
        /*
         * 
         * 
         * https://leetcode.com/problems/intersection-of-two-arrays/
         * 
         * 
         * 
         * 
         * 
         */
        public class Solution
        {
            public int[] Intersection(int[] nums1, int[] nums2)
            {
                Dictionary<int, int> firstcounts = new Dictionary<int, int>();

                for (int index = 0; index < nums1.Length; index++)
                {
                    if (!firstcounts.ContainsKey(nums1[index]))
                        firstcounts.Add(nums1[index], 1);
                    else
                        firstcounts[nums1[index]] = firstcounts[nums1[index]] + 1;
                }

                Dictionary<int, int> secondcounts = new Dictionary<int, int>();

                for (int index = 0; index < nums2.Length; index++)
                {
                    if (!secondcounts.ContainsKey(nums2[index]))
                        secondcounts.Add(nums2[index], 1);
                    else
                        secondcounts[nums2[index]] = secondcounts[nums2[index]] + 1;
                }

                List<int> intlist = new List<int>();
                foreach (var pairone in firstcounts)
                {
                    if (secondcounts.ContainsKey(pairone.Key))
                    {
                        intlist.Add(pairone.Key);
                    }
                }

                return intlist.ToArray();
            }
        }
    }
}
