using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class RomanToInteger
    {
        /* 
         * https://leetcode.com/problems/roman-to-integer/
         *  
         */

        internal class Solution
        {
            internal int RomanToInt(string s)
            {

                if (s.Length > 15)
                    return 0;

                Char previousChar = ' ';
                int sum = 0;

                foreach (Char currentChar in s)
                {
                    switch (currentChar)
                    {

                        case 'I':
                            sum += 1;
                            break;
                        case 'V':
                            if (previousChar == 'I')
                                sum += 3;
                            else
                                sum += 5;
                            break;
                        case 'X':
                            if (previousChar == 'I')
                                sum += 8;
                            else
                                sum += 10;
                            break;
                        case 'L':
                            if (previousChar == 'X')
                                sum += 30;
                            else
                                sum += 50;
                            break;
                        case 'C':
                            if (previousChar == 'X')
                                sum += 80;
                            else
                                sum += 100;
                            break;
                        case 'D':
                            if (previousChar == 'C')
                                sum += 300;
                            else
                                sum += 500;
                            break;
                        case 'M':
                            if (previousChar == 'C')
                                sum += 800;
                            else
                                sum += 1000;
                            break;
                        default:
                            break;
                    }

                    previousChar = currentChar;

                }

                return sum;
            }
        }
    }
}
