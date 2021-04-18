using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class LongestPalindromeString_BruteForce
    {
        /**
         * 
         * 
         * https://leetcode.com/problems/longest-palindromic-substring/
         * 
         * 
         * 
         */
        public class Solution
        {
            public string LongestPalindrome(string s)
            {

                List<string> palindromelist = new List<string>();

                for (int firstindex = 0; firstindex < s.Length; firstindex++)
                {
                    for (int secondindex = firstindex, charcount = 1; secondindex < s.Length; secondindex++, charcount++)
                    {
                        string substring = s.Substring(firstindex, charcount);

                        Console.WriteLine($"SubString: {substring}");

                        if (palindromelist.Contains(substring))
                            continue;

                        if (isPalindrome(substring))
                        {
                            Console.WriteLine($"SubString is Palindrome: {substring}");
                            palindromelist.Add(substring);
                        }


                    }
                }

                string maxpalindromestring = "";

                foreach (var str in palindromelist)
                {
                    if (str.Length > maxpalindromestring.Length)
                        maxpalindromestring = str;
                }

                return maxpalindromestring;
            }

            public bool isPalindrome(string str)
            {
                int mid = 0;

                if (str.Length % 2 == 0)
                    mid = (str.Length) / 2;
                else
                    mid = (str.Length + 1) / 2;

                bool isPalindrome = true;

                for (int index = 0, rindex = str.Length - 1; index < mid; index++, rindex--)
                {
                    if (str[index] != str[rindex])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                return isPalindrome;
            }
        }
    }
}
