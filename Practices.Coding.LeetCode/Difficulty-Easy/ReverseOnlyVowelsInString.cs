using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ReverseOnlyVowelsInString
    {
        /*****
         * 
         * https://leetcode.com/problems/reverse-vowels-of-a-string/
         * 
         * 
         */
        internal class Solution
        {
            internal string ReverseVowels(string s)
            {

                Stack<Char> charstack = new Stack<Char>();

                foreach (char c in s)
                {
                    switch (c)
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                            charstack.Push(c);
                            break;
                        default:
                            break;
                    }
                }

                StringBuilder newstr = new StringBuilder();
                for (int index = 0; index < s.Length; index++)
                {
                    switch (s[index])
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                            newstr.Append(charstack.Pop().ToString());
                            break;
                        default:
                            newstr.Append(s[index].ToString());
                            break;
                    }
                }

                return newstr.ToString();
            }
        }
    }
}
