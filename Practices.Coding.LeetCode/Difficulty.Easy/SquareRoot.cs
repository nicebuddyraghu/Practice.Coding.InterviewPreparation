using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class SquareRoot
    {
        /**
         * 
         * https://leetcode.com/problems/sqrtx/
         * 
         */
        internal class Solution
        {
            internal int MySqrt(int x)
            {

                int root = 0;
                for (int i = 1; i <= x; i++)
                {
                    int square = i * i;
                    if (square <= x && square > 0)
                    {
                        root = i;
                        //Console.WriteLine($"value {i}: {square}");
                    }
                    else
                    {
                        break;
                    }

                }

                return root;
            }
        }
    }
}
