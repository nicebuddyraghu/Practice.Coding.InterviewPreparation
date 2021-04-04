using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class TruncateSentence
    {
        /*
         * 
         * https://leetcode.com/problems/truncate-sentence/submissions/
         * 
         */
        internal class Solution
        {
            internal string TruncateSentence(string s, int k)
            {

                var strarray = s.Split(' ');

                StringBuilder sb = new StringBuilder();
                for (int index = 0; index < k; index++)
                {
                    sb.Append(strarray[index]);
                    if (index < k - 1)
                        sb.Append(" ");
                }

                return sb.ToString();
            }
        }
    }
}
