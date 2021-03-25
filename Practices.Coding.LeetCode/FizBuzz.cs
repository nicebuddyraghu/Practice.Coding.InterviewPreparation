using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class FizBuzz
    {
        /**
         * 
         * 
         * 
         * https://leetcode.com/problems/fizz-buzz/submissions/
         * 
         * 
         * 
         */

        internal class Solution
        {
            internal IList<string> FizzBuzz(int n)
            {

                Console.WriteLine($"{1 % 5 == 0}");

                string fizzBuzz = "FizzBuzz";
                string fizz = "Fizz";
                string buzz = "Buzz";
                var list = new List<string>();
                for (int index = 1; index <= n; index++)
                {
                    if ((index % 3 == 0) && (index % 5 == 0))
                    {
                        list.Add(fizzBuzz);
                    }
                    else if (index % 3 == 0)
                    {
                        list.Add(fizz);
                    }
                    else if (index % 5 == 0)
                    {
                        list.Add(buzz);
                    }
                    else
                        list.Add(index.ToString());
                }

                return list;
            }
        }
    }
}
