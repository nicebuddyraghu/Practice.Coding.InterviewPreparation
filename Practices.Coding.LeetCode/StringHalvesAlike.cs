using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class StringHalvesAlike
    {
        /****
         * 
         * https://leetcode.com/problems/determine-if-string-halves-are-alike/submissions/
         * 
         * 
         * 
         * 
         */
        internal class Solution
        {
            internal bool HalvesAreAlike(string s)
            {

                Dictionary<char, bool> voweldictionary = new Dictionary<char, bool>();

                voweldictionary.Add('a', true);
                voweldictionary.Add('e', true);
                voweldictionary.Add('i', true);
                voweldictionary.Add('o', true);
                voweldictionary.Add('u', true);
                voweldictionary.Add('A', true);
                voweldictionary.Add('E', true);
                voweldictionary.Add('I', true);
                voweldictionary.Add('O', true);
                voweldictionary.Add('U', true);

                int firststrcount = 0;
                int secondstrcount = 0;

                for (int index = 0, sindex = s.Length / 2; index < s.Length / 2; index++, sindex++)
                {
                    if (voweldictionary.ContainsKey(s[index]))
                        firststrcount++;
                    if (voweldictionary.ContainsKey(s[sindex]))
                        secondstrcount++;
                }

                return firststrcount == secondstrcount ? true : false;

            }
        }
    }
}
