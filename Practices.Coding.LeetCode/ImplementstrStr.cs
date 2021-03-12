using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ImplementstrStr
    {
        /****
         * 
         * https://leetcode.com/problems/implement-strstr/
         */
        internal class Solution
        {
            internal int StrStr(string haystack, string needle)
            {

                if (String.IsNullOrEmpty(haystack) && String.IsNullOrEmpty(needle))
                    return 0;

                if (String.IsNullOrEmpty(needle))
                    return 0;

                if (String.IsNullOrEmpty(haystack))
                    return -1;

                if (haystack.Length > 50000 || needle.Length > 5000)
                    return -1;

                if (haystack.Length < needle.Length)
                    return -1;

                var indexFoundAt = -1;
                var needleIndex = 0;
                var startMatching = false;
                for (var index = 0; index < haystack.Length; index++)
                {
                    if (haystack[index] == needle[0] && !startMatching)
                    {
                        startMatching = true;
                        indexFoundAt = index;

                        if (needleIndex == needle.Length - 1)
                        {
                            return indexFoundAt;
                        }
                        needleIndex++;
                    }
                    else if (haystack[index] == needle[needleIndex] && startMatching)
                    {
                        if (needleIndex == needle.Length - 1)
                        {
                            return indexFoundAt;
                        }
                        needleIndex++;
                    }
                    else
                    {
                        if (!startMatching)
                            indexFoundAt = -1;
                        else
                        {
                            index = indexFoundAt++;
                            indexFoundAt = -1;
                        }

                        startMatching = false;
                        needleIndex = 0;
                    }
                }

                return -1;

            }
        }
    }
}
