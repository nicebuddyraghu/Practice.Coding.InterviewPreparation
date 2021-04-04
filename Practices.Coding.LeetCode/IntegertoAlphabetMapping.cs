using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class IntegertoAlphabetMapping
    {
        /***
         * 
         * 
         * https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/submissions/
         * 
         * 
         * 
         */
        internal class Solution
        {
            internal string FreqAlphabets(string s)
            {

                Dictionary<string, string> stringchardictionary = new Dictionary<string, string>();
                Dictionary<char, char> chardictionary = new Dictionary<char, char>();

                chardictionary.Add('1', 'a');
                chardictionary.Add('2', 'b');
                chardictionary.Add('3', 'c');
                chardictionary.Add('4', 'd');
                chardictionary.Add('5', 'e');
                chardictionary.Add('6', 'f');
                chardictionary.Add('7', 'g');
                chardictionary.Add('8', 'h');
                chardictionary.Add('9', 'i');
                stringchardictionary.Add("10#", "j");
                stringchardictionary.Add("11#", "k");
                stringchardictionary.Add("12#", "l");
                stringchardictionary.Add("13#", "m");
                stringchardictionary.Add("14#", "n");
                stringchardictionary.Add("15#", "o");
                stringchardictionary.Add("16#", "p");
                stringchardictionary.Add("17#", "q");
                stringchardictionary.Add("18#", "r");
                stringchardictionary.Add("19#", "s");
                stringchardictionary.Add("20#", "t");
                stringchardictionary.Add("21#", "u");
                stringchardictionary.Add("22#", "v");
                stringchardictionary.Add("23#", "w");
                stringchardictionary.Add("24#", "x");
                stringchardictionary.Add("25#", "y");
                stringchardictionary.Add("26#", "z");

                foreach (var pair in stringchardictionary)
                {
                    s = s.Replace(pair.Key, pair.Value);
                }

                foreach (var pair in chardictionary)
                {
                    s = s.Replace(pair.Key, pair.Value);
                }

                return s;


            }
        }
    }
}
