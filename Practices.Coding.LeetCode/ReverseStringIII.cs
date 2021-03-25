using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class ReverseStringIII
    {
        /***
         * 
         * 
         * 
         * 
         * https://leetcode.com/problems/reverse-words-in-a-string-iii/submissions/
         * 
         * 
         */

        internal class Solution
        {
            internal string ReverseWords(string s)
            {

                if (String.IsNullOrEmpty(s))
                    return String.Empty;

                var words = s.Split(' ');

                Stack<char> charStack = new Stack<char>();

                StringBuilder builder = new StringBuilder();

                int index = 0;
                foreach (var word in words)
                {
                    foreach (var ch in word)
                    {
                        charStack.Push(ch);
                    }

                    while (charStack.Count > 0)
                    {
                        builder.Append(charStack.Pop());
                    }

                    if (index < words.Length - 1)
                        builder.Append(" ");
                    index++;
                }

                return builder.ToString();
            }
        }
    }
}
