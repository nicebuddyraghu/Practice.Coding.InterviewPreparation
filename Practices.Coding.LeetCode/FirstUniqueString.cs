using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class FirstUniqueString
    {
        /*
         * 
         * 
         * https://leetcode.com/problems/first-unique-character-in-a-string/submissions/
         * 
         * 
         */
        internal class Solution
        {
            internal int FirstUniqChar(string s)
            {

                if (String.IsNullOrEmpty(s))
                {
                    return -1;
                }

                Dictionary<char, int> charcount = new Dictionary<char, int>();

                foreach (char c in s)
                {
                    if (charcount.ContainsKey(c))
                    {
                        charcount[c]++;
                    }
                    else
                    {
                        charcount.Add(c, 1);
                    }
                }

                int index = 0;
                bool isUniqueExists = false;
                foreach (char c in s)
                {
                    if (charcount[c] == 1)
                    {
                        isUniqueExists = true;
                        break;
                    }
                    index++;
                }

                if (isUniqueExists)
                    return index;
                else
                    return -1;
            }
        }
    }
}
