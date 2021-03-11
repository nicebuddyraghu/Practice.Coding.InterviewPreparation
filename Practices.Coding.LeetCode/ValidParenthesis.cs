using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ValidParenthesis
    {
        /*
         * 
         * https://leetcode.com/problems/valid-parentheses/
         * 
         */

        public class Solution
        {
            public bool IsValid(string s)
            {

                if (String.IsNullOrEmpty(s))
                    return false;

                if (s.Length > 10000)
                    return false;

                Char lastChar = ' ';
                bool isValid = true;
                System.Collections.Stack charStack = new System.Collections.Stack();

                foreach (Char currentChar in s)
                {
                    switch (currentChar)
                    {
                        case '(':
                            charStack.Push(currentChar);
                            break;
                        case ')':
                            if (charStack.Count > 0)
                            {
                                lastChar = (Char)charStack.Pop();
                                if (lastChar != '(')
                                    isValid = false;
                            }
                            else
                                isValid = false;
                            break;
                        case ']':
                            if (charStack.Count > 0)
                            {
                                lastChar = (Char)charStack.Pop();
                                if (lastChar != '[')
                                    isValid = false;
                            }
                            else
                                isValid = false;
                            break;
                        case '[':
                            charStack.Push(currentChar);
                            break;
                        case '{':
                            charStack.Push(currentChar);
                            break;
                        case '}':
                            if (charStack.Count > 0)
                            {
                                lastChar = (Char)charStack.Pop();
                                if (lastChar != '{')
                                    isValid = false;
                            }
                            else
                                isValid = false;
                            break;
                        default:
                            isValid = false;
                            break;
                    }

                    if (!isValid)
                    {
                        break;
                    }

                }

                if (charStack.Count > 0)
                    return false;

                Console.WriteLine(isValid);

                if (!isValid)
                    return false;
                else
                    return true;
            }
        }
    }
}
