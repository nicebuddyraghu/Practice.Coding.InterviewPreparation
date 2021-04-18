using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class LongestSubStringWithoutRepeatingCharacters_LinearTimes
    {
        /**
         * 
         * https://leetcode.com/problems/longest-substring-without-repeating-characters/submissions/
         * 
         *          * 
         */
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {

                int startindex = 0;
                string lastlongestword = "";

                Dictionary<char, int> lastindexdic = new Dictionary<char, int>();

                for (int endindex = 0; endindex < s.Length; endindex++)
                {
                    if (!lastindexdic.ContainsKey(s[endindex]))
                    {
                        lastindexdic.Add(s[endindex], endindex);
                    }
                    else
                    {
                        Console.WriteLine($"Start Index:{startindex}, End Index:{endindex}");
                        string substring = s.Substring(startindex, endindex - startindex);

                        int lastindex = lastindexdic[s[endindex]];
                        startindex = startindex > lastindex + 1 ? startindex : lastindex + 1;

                        lastindexdic[s[endindex]] = endindex;

                        Console.WriteLine($"New Index:{startindex}, End Index:{endindex}");
                        if (substring.Length > lastlongestword.Length)
                            lastlongestword = substring;
                    }
                }

                string substringrem = string.Empty;
                if (lastindexdic.Count > 0)
                    substringrem = s.Substring(startindex);

                if (substringrem.Length > lastlongestword.Length)
                    lastlongestword = substringrem;

                return lastlongestword.Length;
            }
        }
    }
}
