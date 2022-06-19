using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class PerfectSquares
    {
        public class Solution
        {
            public int NumSquares(int n)
            {

                var squaresneed = GetSquaresNeeded(n, GetSquares(n));
                return squaresneed;
            }

            Dictionary<int, int> numberofSquaresDictionary = new Dictionary<int, int>();
            public int GetSquaresNeeded(int n, List<int> squares)
            {
                int minsquaresneeded = Int32.MaxValue;

                for (int index = 0; index < squares.Count; index++)
                {
                    if ((n - squares[index]) >= 0)
                    {
                        if (numberofSquaresDictionary.ContainsKey(n - squares[index]))
                        {
                            var subsquaresneeded = numberofSquaresDictionary[n - squares[index]];
                            if (subsquaresneeded < minsquaresneeded)
                            {
                                minsquaresneeded = subsquaresneeded;
                            }
                        }
                        else
                        {
                            var subsquaresneeded = GetSquaresNeeded(n - squares[index], squares) + 1;
                            numberofSquaresDictionary.Add(n - squares[index], subsquaresneeded);

                            if (subsquaresneeded < minsquaresneeded)
                            {
                                minsquaresneeded = subsquaresneeded;
                            }
                        }
                    }

                }

                return minsquaresneeded == Int32.MaxValue ? 0 : minsquaresneeded;
            }

            public List<int> GetSquares(int n)
            {
                List<int> squareslist = new List<int>();

                for (int num = 1; num <= n; num++)
                {
                    if (num * num <= n)
                    {
                        squareslist.Add(num * num);
                        //Console.WriteLine(num*num);
                    }
                }

                return squareslist;
            }
        }
    }
}
