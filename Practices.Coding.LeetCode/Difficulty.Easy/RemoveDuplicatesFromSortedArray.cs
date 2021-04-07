using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class RemoveDuplicatesFromSortedArray
    {
        /*
         * https://leetcode.com/problems/remove-duplicates-from-sorted-array/
         */

        internal class Solution
        {
            internal int RemoveDuplicates(int[] nums)
            {
                System.Collections.Generic.HashSet<int> hashset = new System.Collections.Generic.HashSet<int>();

                foreach (var num in nums)
                {
                    if (!hashset.Contains(num))
                    {
                        hashset.Add(num);
                    }
                }

                int index = 0;
                foreach (var num in hashset)
                {
                    nums[index] = num;
                    index++;
                }

                return hashset.Count;
            }
        }
    }
}
