using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MaximumSixtyNine
    {
        /*
         * 
         * https://leetcode.com/problems/maximum-69-number/submissions/
         */
        internal class Solution
        {
            internal int Maximum69Number(int num)
            {

                List<int> numlist = new List<int>();

                var tempnum = num;
                while (tempnum > 0)
                {
                    var digit = tempnum % 10;
                    numlist.Add(digit);
                    tempnum = tempnum / 10;
                }

                var maxnum = num;
                for (int index = 0; index < numlist.Count; index++)
                {
                    var newnum = 0;
                    var multiply = 1;
                    var multiplyindex = 0;
                    foreach (var digit in numlist)
                    {
                        if (digit == 6 && multiplyindex == index)
                        {
                            newnum += 9 * multiply;
                        }
                        else
                            newnum += digit * multiply;
                        multiply = multiply * 10;

                        multiplyindex++;
                    }

                    Console.WriteLine($"New Number: {newnum}");
                    if (newnum > maxnum)
                        maxnum = newnum;
                }

                return maxnum;
            }
        }
    }
}
