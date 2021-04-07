using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class IsoMericStrings
    {
        /***
         * 
         * 
         * https://leetcode.com/problems/isomorphic-strings/submissions/
         * 
         */

        internal class Solution
        {
            internal bool IsIsomorphic(string s, string t)
            {

                //Validations
                if (String.IsNullOrEmpty(s) || String.IsNullOrEmpty(t))
                {
                    return false;
                }

                if (s.Length != t.Length)
                    return false;

                var isIsomeric = true;
                var charDictionary = new Dictionary<char, char>();

                for (int index = 0; index < s.Length; index++)
                {
                    var firstchar = s[index];
                    var secondchar = t[index];

                    if (!charDictionary.ContainsKey(firstchar))
                        charDictionary.Add(firstchar, secondchar);
                    else
                    {
                        if (charDictionary[firstchar] != secondchar)
                        {
                            isIsomeric = false;
                            break;
                        }
                    }
                }

                if (!isIsomeric)
                    return isIsomeric;

                charDictionary.Clear();

                for (int index = 0; index < s.Length; index++)
                {
                    var firstchar = t[index];
                    var secondchar = s[index];

                    if (charDictionary.ContainsValue(secondchar))
                    {
                        char key = ' ';
                        foreach (var pair in charDictionary)
                        {
                            if (pair.Value == secondchar)
                            {
                                key = pair.Key;
                                break;
                            }
                        }

                        if (key != firstchar)
                        {
                            isIsomeric = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!charDictionary.ContainsKey(firstchar))
                        {
                            charDictionary.Add(firstchar, secondchar);
                        }
                        else
                        {
                            isIsomeric = false;
                        }
                    }

                }

                return isIsomeric;
            }
        }
    }
}
