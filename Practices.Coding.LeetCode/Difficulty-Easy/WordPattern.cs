using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class WordPattern
    {
        /*****
         * 
         * 
         * https://leetcode.com/problems/word-pattern/submissions/
         * 
         */

        internal class Solution
        {
            internal bool WordPattern(string pattern, string s)
            {

                if (String.IsNullOrEmpty(s) || String.IsNullOrEmpty(pattern))
                    return false;

                if (s.Length > 3000)
                    return false;

                if (pattern.Length > 300)
                    return false;

                var patternWords = s.Split(' ');

                Console.WriteLine(patternWords.Length);

                if (patternWords.Length != pattern.Length)
                    return false;

                var isPatternMatching = true;
                var patternDictionary = new Dictionary<char, string>();

                for (var index = 0; index < pattern.Length; index++)
                {
                    var key = pattern[index];
                    var value = patternWords[index];

                    if (!patternDictionary.ContainsKey(key))
                    {
                        patternDictionary.Add(key, value);
                        Console.WriteLine($"{key}:{value} is added to the Dictionary");
                    }
                    else
                    {
                        Console.WriteLine($"{key}:{patternDictionary[key]} comparision with value {value}");
                        if (patternDictionary[key] != value)
                        {
                            isPatternMatching = false;
                            break;
                        }
                    }
                }

                if (!isPatternMatching)
                    return false;

                var stringDictionary = new Dictionary<string, char>();

                for (var index = 0; index < pattern.Length; index++)
                {
                    var key = patternWords[index];
                    var value = pattern[index];

                    if (!stringDictionary.ContainsKey(key))
                    {
                        stringDictionary.Add(key, value);
                        Console.WriteLine($"{key}:{value} is added to the Dictionary");
                    }
                    else
                    {
                        Console.WriteLine($"{key}:{stringDictionary[key]} comparision with value {value}");
                        if (stringDictionary[key] != value)
                        {
                            isPatternMatching = false;
                            break;
                        }
                    }
                }

                return isPatternMatching;
            }


        }
    }
}
