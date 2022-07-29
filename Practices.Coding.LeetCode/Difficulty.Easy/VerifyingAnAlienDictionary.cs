using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class VerifyingAnAlienDictionary
    {
        public class Solution
        {

            Dictionary<char, int> alienAlphabetsOrder = new Dictionary<char, int>();

            public bool IsAlienSorted(string[] words, string order)
            {

                UpdateAlienAlphabetsOrder(order);
                for (int index = 1; index < words.Length; index++)
                {
                    var word1 = words[index - 1];
                    var word2 = words[index];
                    if (!IsWordsOrderedWithAlienDictionary(word1, word2))
                        return false;
                }
                return true;
            }

            public bool IsWordsOrderedWithAlienDictionary(string word1, string word2)
            {
                var min = Math.Min(word1.Length, word2.Length);
                var index = 0;

                if (alienAlphabetsOrder[word1[index]] < alienAlphabetsOrder[word2[index]])
                {
                    return true;
                }

                while (index < min)
                {
                    if (alienAlphabetsOrder[word1[index]] > alienAlphabetsOrder[word2[index]])
                    {
                        return false;
                    }
                    index++;
                }

                if (word1.Length > min && word1.StartsWith(word2))
                {
                    return false;
                }

                return true;
            }

            public void UpdateAlienAlphabetsOrder(string order)
            {
                for (int index = 1; index <= order.Length; index++)
                {
                    alienAlphabetsOrder.Add(order[index - 1], index);
                }
            }

        }

    }
}
