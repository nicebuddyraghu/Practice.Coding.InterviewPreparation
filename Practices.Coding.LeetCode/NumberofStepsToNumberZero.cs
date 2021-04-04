using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class NumberofStepsToNumberZero
    {
        internal class Solution
        {
            internal int NumberOfSteps(int num)
            {

                var tempnum = num;
                var reducecount = 0;
                while (tempnum > 0)
                {
                    if (tempnum % 2 == 0)
                    {
                        tempnum = tempnum / 2;
                        reducecount++;
                    }
                    else
                    {
                        tempnum = tempnum - 1;
                        reducecount++;
                    }
                }

                return reducecount;
            }
        }
    }
}
