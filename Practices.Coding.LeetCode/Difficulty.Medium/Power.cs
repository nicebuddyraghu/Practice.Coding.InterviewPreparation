using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * 
     * https://leetcode.com/problems/powx-n/
     * 
     * 
     */
    public class Power
    {
        public class Solution
        {
            public double MyPow(double x, int n)
            {

                if (n == 0)
                {
                    return 1;
                }
                else if (n == 1 || n == -1)
                {
                    if (n > 0)
                    {
                        return x;
                    }
                    else
                    {
                        return 1 / x;
                    }
                }
                else
                {
                    var multiply = GetPower(x, n);
                    return multiply;
                }
            }

            Dictionary<int, double> memo = new Dictionary<int, double>();

            public double GetPower(double x, int n)
            {
                if (n == 1)
                {
                    return x;
                }
                else if (n == -1)
                {
                    return 1 / x;
                }
                else
                {
                    int mid = (int)(n / 2);
                    if (n % 2 == 0)
                    {
                        var multiply = GetPower(x, mid);
                        return multiply * multiply;
                    }
                    else
                    {
                        var multiply = GetPower(x, mid);
                        return n > 0 ? multiply * multiply * x : multiply * multiply * (1 / x);
                    }
                }
            }
        }
    }
}
