using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class LengthOfLastWord
    {
        /**
         * 
         * https://leetcode.com/problems/length-of-last-word/submissions/
         * 
         */
        internal class Solution
        {
            internal int LengthOfLastWord(string s)
            {
                string[] strs = s.Split(' ');

                for (var index = strs.Length - 1; index >= 0; index--)
                {
                    if (string.IsNullOrEmpty(strs[index]))
                        continue;
                    else
                        return strs[index].Length;
                }

                return 0;
            }
        }
    }
}
