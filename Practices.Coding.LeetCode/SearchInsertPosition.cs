using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class SearchInsertPosition
    {
        /**
         * 
         * https://leetcode.com/problems/search-insert-position/
         */
        internal class Solution
        {
            internal int SearchInsert(int[] nums, int target)
            {

                if (nums == null)
                    return -1;

                if (nums.Length > 10000)
                    return -1;

                for (var index = 0; index < nums.Length; index++)
                {

                    if (nums[index] == target)
                        return index;
                    else if (nums[index] > target)
                        return index;
                }

                return nums.Length;
            }
        }
    }
}
