using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class RemoveAllAdjacentDuplicatesInString
    {
        public class Solution
        {
            public string RemoveDuplicates(string s)
            {

                Stack<char> charStack = new Stack<char>();
                char previouschar = ' ';
                for (int index = 0; index < s.Length; index++)
                {
                    char presentchar = s[index];
                    if (presentchar == previouschar)
                    {
                        if (charStack.Count > 0)
                        {
                            charStack.Pop();
                            //Console.WriteLine($"Poping = {charStack.Pop()}");
                            if (charStack.Count > 0)
                            {
                                previouschar = charStack.Peek();
                            }
                            else
                            {
                                previouschar = ' ';
                            }
                        }
                    }
                    else
                    {
                        //Console.WriteLine($"Pushing = {presentchar}");
                        charStack.Push(presentchar);
                        previouschar = presentchar;
                    }
                }

                if (charStack.Count > 0)
                {
                    char[] newcharlist = new char[charStack.Count];
                    int index = charStack.Count - 1;
                    while (charStack.Count > 0)
                    {
                        //Console.WriteLine(charStack.Count);
                        newcharlist[index] = charStack.Pop();
                        index--;
                    }
                    return new string(newcharlist);
                }
                else
                {
                    return String.Empty;
                }

            }


        }

    }
}
