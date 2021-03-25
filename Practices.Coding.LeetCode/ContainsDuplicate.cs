using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ContainsDuplicate
    {
        /***
         * 
         * https://leetcode.com/problems/contains-duplicate/submissions/
         * 
         */
        internal class Solution
        {
            internal bool ContainsDuplicate(int[] nums)
            {

                if (nums == null)
                    return false;

                if (nums.Length == 0 || nums.Length > 100000)
                    return false;

                var numDic = new Dictionary<int, bool>();
                bool isDuplicateExists = false;

                for (var index = 0; index < nums.Length; index++)
                {
                    var number = nums[index];

                    if (numDic.ContainsKey(number))
                    {
                        isDuplicateExists = true;
                        break;
                    }
                    else
                        numDic.Add(number, true);
                }

                return isDuplicateExists;

            }
        }
    }
}
