using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class IncreasingDecreasingStringII
    {
        public class Solution
        {
            /*
             * 
             * 
             * 
             * https://leetcode.com/problems/increasing-decreasing-string/submissions/
             * 
             * 
             * 
             * 
             */
            public string SortString(string s)
            {

                List<char> charlist = new List<char>();

                charlist = "abcdefghijklmnopqrstuvwxyz".ToList();

                Console.WriteLine(charlist.Count);
                List<char> orgcharlist = s.ToList();

                StringBuilder builder = new StringBuilder();

                while (orgcharlist.Count > 0)
                {
                    foreach (var ch in charlist)
                    {
                        for (int index = 0; index < orgcharlist.Count; index++)
                        {
                            if (ch == orgcharlist[index])
                            {
                                builder.Append(ch);
                                orgcharlist.RemoveAt(index);
                                break;
                            }
                        }
                    }

                    Console.WriteLine("String:" + builder.ToString());
                    foreach (var ch in orgcharlist)
                        Console.Write(ch);
                    Console.WriteLine();

                    for (int mainindex = charlist.Count - 1; mainindex >= 0; mainindex--)
                    {
                        for (int index = 0; index < orgcharlist.Count; index++)
                        {
                            if (charlist[mainindex] == orgcharlist[index])
                            {
                                builder.Append(charlist[mainindex]);
                                orgcharlist.RemoveAt(index);
                                break;
                            }
                        }
                    }

                    Console.WriteLine("String:" + builder.ToString());
                    foreach (var ch in orgcharlist)
                        Console.Write(ch);
                    Console.WriteLine();
                }

                return builder.ToString();
            }
        }
    }
}
