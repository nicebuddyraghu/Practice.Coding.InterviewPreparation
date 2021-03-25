using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ReverseString
    {
        /****
         * 
         * https://leetcode.com/problems/reverse-string/    
         * 
         */
        internal class Solution
        {
            internal void ReverseString(char[] s)
            {

                int reverseindex = s.Length - 1;

                for (int index = 0; index < (int)(s.Length / 2); index++, reverseindex--)
                {
                    var tmpChar = s[index];
                    s[index] = s[reverseindex];
                    s[reverseindex] = tmpChar;

                }


            }
        }
    }
}
