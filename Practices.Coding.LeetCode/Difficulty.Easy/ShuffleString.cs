using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    /***
     * 
     * https://leetcode.com/problems/shuffle-string/submissions/
     * 
     */
    internal class ShuffleString
    {
        internal class Solution
        {
            internal string RestoreString(string s, int[] indices)
            {

                char[] chararray = new Char[indices.Length];

                for (int index = 0; index < indices.Length; index++)
                {
                    var originalindex = indices[index];
                    var ch = s[index];
                    Console.WriteLine($"Index:{originalindex}, Char:{ch}");

                    chararray[originalindex] = ch;
                }

                var shuffledstring = new String(chararray);
                Console.WriteLine(shuffledstring);

                return shuffledstring;
            }
        }
    }
}
