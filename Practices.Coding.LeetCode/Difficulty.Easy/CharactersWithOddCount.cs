using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class CharactersWithOddCount
    {
        /***
         * 
         * https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/submissions/
         * 
         * 
         * 
         * 
         */
        internal class Solution
        {
            internal string GenerateTheString(int n)
            {

                if (n % 2 == 0)
                {
                    char[] chararray = new char[n];

                    for (int index = 0; index < n - 1; index++)
                        chararray[index] = 'a';

                    chararray[n - 1] = 'b';

                    string str = new string(chararray);

                    return str;
                }
                else
                {
                    char[] chararray = new char[n];

                    for (int index = 0; index < n; index++)
                        chararray[index] = 'a';

                    string str = new string(chararray);

                    return str;
                }

            }
        }
    }
}
