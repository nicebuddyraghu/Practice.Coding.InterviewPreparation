using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    /*
     * https://leetcode.com/problems/palindrome-number/
     */
    internal class PalindromeNumber
    {
        internal class Solution
        {
            internal bool IsPalindrome(int x)
            {
                int reverse = Reverse(x);
                if (x < 0)
                    return false;

                if (x == reverse)
                    return true;
                else
                    return false;
            }

            internal int Reverse(int x)
            {
                bool isNegativeNumber = false;

                if (x < 0)
                {
                    isNegativeNumber = true;
                    x = x * -1; //Convert to Positive Integer.
                }

                int tempNumber = x;
                int maxTens = 0;
                while (tempNumber > 0)
                {
                    tempNumber = tempNumber / 10;
                    maxTens++;
                }

                tempNumber = x;
                int reverseNumber = 0;
                for (int i = maxTens - 1; i >= 0; i--)
                {
                    int lastDigit = tempNumber % 10;
                    tempNumber = tempNumber / 10;
                    reverseNumber = reverseNumber + (int)(System.Math.Pow(10, i) * lastDigit);
                }

                if (reverseNumber < 0) return 0;

                if (isNegativeNumber)
                    reverseNumber = reverseNumber * -1;

                if (reverseNumber > (System.Math.Pow(2, 32) - 1) || reverseNumber < (System.Math.Pow(2, 31) * -1))
                {
                    return 0;
                }

                return reverseNumber;
            }
        }
    }
}
