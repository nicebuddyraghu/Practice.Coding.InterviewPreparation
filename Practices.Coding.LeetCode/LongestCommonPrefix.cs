using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class LongestCommonPrefix
    {
        /*
         * https://leetcode.com/problems/longest-common-prefix/
         */

        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {

                int prefixStartIndex = -1;
                int prefixEndIndex = -1;
                int minLength = 0;
                string prefix = string.Empty;

                if (strs == null || strs.Length == 0)
                {
                    return String.Empty;
                }
                minLength = strs[0].Length;

                foreach (string str in strs)
                {
                    if (minLength > str.Length)
                    {
                        minLength = str.Length;
                    }
                }

                //This stage you have the minimum string length;

                for (int index = 0; index < minLength; index++)
                {
                    char prefixChar = strs[0][index];
                    bool isPrefixValid = true;

                    foreach (string str in strs)
                    {
                        if (prefixChar != str[index])
                        {
                            isPrefixValid = false;
                            break;
                        }
                    }

                    if (isPrefixValid)
                    {
                        if (prefixStartIndex < 0)
                        {
                            prefixStartIndex = index;
                        }

                        if (index == minLength - 1)
                        {
                            prefixEndIndex = index;
                            if (prefixStartIndex >= 0 && prefixEndIndex >= 0)
                            {
                                prefix = strs[0].Substring(prefixStartIndex, prefixEndIndex - prefixStartIndex + 1);
                            }
                        }
                    }
                    else
                    {
                        prefixEndIndex = index - 1;

                        if (prefixStartIndex >= 0 && prefixEndIndex >= 0)
                        {
                            prefix = strs[0].Substring(prefixStartIndex, prefixEndIndex - prefixStartIndex + 1);
                        }
                        else
                            prefix = string.Empty;
                        break;
                    }
                }

                return prefix;
            }
        }
    }
}
