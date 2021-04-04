using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ShuffleArray
    {
        /***
         * 
         * https://leetcode.com/problems/shuffle-the-array/submissions/
         * 
         */

        internal class Solution
        {
            internal int[] Shuffle(int[] nums, int n)
            {

                var newnums = new int[2 * n];
                int newindex = 0;
                for (var index = 0; index < n; index++)
                {
                    int firstnumber = nums[index];
                    int secondnumber = nums[index + n];
                    newnums[newindex] = firstnumber;
                    newnums[newindex + 1] = secondnumber;
                    newindex += 2;
                }

                return newnums;
            }
        }
    }
}
