using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class CheckTwoStringArraysAreEqual
    {
        /**
         * 
         * https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/submissions/
         * 
         */
        internal class Solution
        {
            internal bool ArrayStringsAreEqual(string[] word1, string[] word2)
            {

                StringBuilder sb = new StringBuilder();

                foreach (var word in word1)
                {
                    sb.Append(word);
                }

                string firststring = sb.ToString();

                sb.Clear();

                foreach (var word in word2)
                {
                    sb.Append(word);
                }

                string secondstring = sb.ToString();

                if (secondstring == firststring)
                    return true;
                else
                    return false;

            }
        }
    }
}
