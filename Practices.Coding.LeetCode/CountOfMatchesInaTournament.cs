using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class CountOfMatchesInaTournament
    {
        /*
         * 
         * https://leetcode.com/problems/count-of-matches-in-tournament/submissions/
         * 
         */
        internal class Solution
        {
            internal int NumberOfMatches(int n)
            {

                int totalmatches = 0;

                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        totalmatches = totalmatches + (n / 2);
                        n = n / 2;
                    }
                    else
                    {
                        totalmatches = totalmatches + ((n - 1) / 2);
                        n = ((n - 1) / 2) + 1;
                    }
                }

                return totalmatches;
            }
        }
    }
}
