using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class Fibbonacci
    {
        internal class Solution
        {
            /***
             * 
             * 
             * https://leetcode.com/problems/fibonacci-number/submissions/
             * 
             */

            internal int fib(int n)
            {

                if (n == 0)
                    return 0;
                else if (n == 1)
                    return 1;
                else
                    return fib(n - 1) + fib(n - 2);

            }
        };
    }
}
