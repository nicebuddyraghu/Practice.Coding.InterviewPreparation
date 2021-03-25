using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class FindTheDifference
    {
        /***
         * 
         * https://leetcode.com/problems/find-the-difference/submissions/
         * 
         * 
         */

        internal class Solution
        {
            internal char FindTheDifference(string s, string t)
            {

                var sDictionary = new Dictionary<char, int>();
                var tDictionary = new Dictionary<char, int>();

                foreach (var ch in s)
                {
                    if (sDictionary.ContainsKey(ch))
                        sDictionary[ch]++;
                    else
                        sDictionary.Add(ch, 1);
                }

                foreach (var ch in t)
                {
                    if (tDictionary.ContainsKey(ch))
                        tDictionary[ch]++;
                    else
                        tDictionary.Add(ch, 1);
                }

                foreach (var pair in tDictionary)
                {
                    if (!sDictionary.ContainsKey(pair.Key))
                        return pair.Key;
                    else
                    {
                        if (pair.Value > sDictionary[pair.Key])
                            return pair.Key;
                    }
                }

                return ' ';
            }
        }
    }
}
