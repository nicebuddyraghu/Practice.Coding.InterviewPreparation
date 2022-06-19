using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class UglyNumberII
    {
        public class Solution
        {
            public int NthUglyNumber(int n)
            {

                int[] uglynumbers = new int[n];

                uglynumbers[0] = 1;

                int index2 = 0;
                int index3 = 0;
                int index5 = 0;
                for (int i = 1; i < n; i++)
                {
                    int num2 = uglynumbers[index2] * 2;
                    int num3 = uglynumbers[index3] * 3;
                    int num5 = uglynumbers[index5] * 5;

                    var min = (Math.Min(Math.Min(num5, num3), num2));
                    uglynumbers[i] = min;
                    if (min == num2)
                    {
                        index2++;
                    }
                    if (min == num3)
                    {
                        index3++;
                    }
                    if (min == num5)
                    {
                        index5++;
                    }

                    Console.Write($"=>{min}");
                }

                return uglynumbers[n - 1];
            }


        }
    }
}
