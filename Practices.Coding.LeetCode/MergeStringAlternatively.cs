using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MergeStringAlternatively
    {
        /*
         * 
         * https://leetcode.com/problems/merge-strings-alternately/submissions/
         * 
         * 
         */
        internal class Solution
        {
            internal string MergeAlternately(string word1, string word2)
            {

                int minlength = word1.Length >= word2.Length ? word2.Length : word1.Length;

                StringBuilder sb = new StringBuilder();

                for (int index = 0; index < minlength; index++)
                {
                    var firstChar = word1[index];
                    var secondChar = word2[index];

                    sb.Append(firstChar);
                    sb.Append(secondChar);
                }

                if (word1.Length != word2.Length)
                {
                    if (word1.Length == minlength)
                    {
                        for (int index = minlength; index < word2.Length; index++)
                        {
                            sb.Append(word2[index]);
                        }
                    }
                    else
                    {
                        for (int index = minlength; index < word1.Length; index++)
                        {
                            sb.Append(word1[index]);
                        }
                    }
                }

                return sb.ToString();
            }
        }
    }
}
