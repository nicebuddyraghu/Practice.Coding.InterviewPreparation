using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class RemoveOutermostParenthesis
    {
        /**
         * 
         * https://leetcode.com/problems/remove-outermost-parentheses/submissions/
         * 
         * 
         * 
         */
        internal class Solution
        {
            internal string RemoveOuterParentheses(string S)
            {

                int count = 0;
                Queue<char> charstack = new Queue<char>();
                StringBuilder sb = new StringBuilder();

                foreach (var ch in S)
                {
                    if (ch == '(')
                    {
                        count++;
                        Console.WriteLine(count);
                        charstack.Enqueue('(');

                    }
                    else
                    {
                        count--;
                        Console.WriteLine(count);
                        charstack.Enqueue(')');

                        if (count == 0)
                        {
                            if (charstack.Count > 1)
                                charstack.Dequeue();

                            while (charstack.Count > 1)
                            {
                                sb.Append(charstack.Dequeue());
                            }

                            if (charstack.Count == 1)
                                charstack.Dequeue();
                        }


                    }
                }

                return sb.ToString();
            }
        }
    }
}
