using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class FindCommonCharacters
    {
        /**
         * 
         * 
         * https://leetcode.com/problems/find-common-characters/submissions/
         * 
         * 
         * 
         * 
         */
        public class Solution
        {
            public IList<string> CommonChars(string[] A)
            {

                List<Dictionary<char, int>> charcountdictionary = new List<Dictionary<char, int>>();

                for (int index = 0; index < A.Length; index++)
                {
                    Dictionary<char, int> chardicionary = new Dictionary<char, int>();

                    chardicionary.Add('a', 0);
                    chardicionary.Add('b', 0);
                    chardicionary.Add('c', 0);
                    chardicionary.Add('d', 0);
                    chardicionary.Add('e', 0);
                    chardicionary.Add('f', 0);
                    chardicionary.Add('g', 0);
                    chardicionary.Add('h', 0);
                    chardicionary.Add('i', 0);
                    chardicionary.Add('j', 0);
                    chardicionary.Add('k', 0);
                    chardicionary.Add('l', 0);
                    chardicionary.Add('m', 0);
                    chardicionary.Add('n', 0);
                    chardicionary.Add('o', 0);
                    chardicionary.Add('p', 0);
                    chardicionary.Add('q', 0);
                    chardicionary.Add('r', 0);
                    chardicionary.Add('s', 0);
                    chardicionary.Add('t', 0);
                    chardicionary.Add('u', 0);
                    chardicionary.Add('v', 0);
                    chardicionary.Add('w', 0);
                    chardicionary.Add('x', 0);
                    chardicionary.Add('y', 0);
                    chardicionary.Add('z', 0);

                    charcountdictionary.Add(chardicionary);
                }

                for (int index = 0; index < A.Length; index++)
                {
                    var dic = charcountdictionary[index];
                    foreach (var ch in A[index])
                    {
                        dic[ch] = dic[ch] + 1;
                    }

                    foreach (var pair in dic)
                    {
                        Console.WriteLine($"Key:{pair.Key},Value:{pair.Value}");
                    }
                    charcountdictionary[index] = dic;
                }

                var list = new List<string>();
                foreach (var ch in "abcdefghijklmnopqrstuvwxyz".ToList())
                {
                    bool isduplicate = true;
                    int min = charcountdictionary[0][ch];
                    for (int index = 0; index < A.Length; index++)
                    {
                        var dic = charcountdictionary[index];
                        if (dic[ch] == 0)
                        {
                            isduplicate = false;
                            Console.WriteLine($"No Duplicate Key:{ch},Value:{dic[ch]}");
                            break;
                        }
                        if (ch == 'd')
                            Console.WriteLine($"Duplicate D Key:{ch},Value:{dic[ch]}");
                        if (min >= dic[ch])
                            min = dic[ch];
                    }

                    Console.WriteLine($"char:{ch}, Minimum:{min}");

                    if (isduplicate)
                        for (int dup = 0; dup < min; dup++)
                            list.Add(ch.ToString());
                }

                return list;

            }
        }
    }
}
