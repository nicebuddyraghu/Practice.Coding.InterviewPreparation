using System;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class CountPrimes
    {
        public class Solution
        {
            public int CountPrimes(int n)
            {

                if (n <= 1) return 0;
                bool[] prime = new bool[n];
                int totalprimes = 0;

                for (int i = 2; i < n; i++)
                {
                    prime[i] = true;
                }


                for (int i = 2; i <= n / 2; i++)
                {
                    if (prime[i] == true)
                    {
                        for (int j = i * 2; j < n;)
                        {
                            if (j < n)
                            {
                                prime[j] = false;
                            }
                            j = j + i;
                        }
                    }
                }
                Console.WriteLine("Break After");

                for (int i = 2; i < n; i++)
                {
                    if (prime[i] == true)
                    {
                        totalprimes++;
                    }
                }

                return totalprimes;
            }
        }
    }
}
