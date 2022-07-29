using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class BullsAndCows
    {
        public class Solution
        {
            public string GetHint(string secret, string guess)
            {
                Dictionary<char, List<int>> secretDictionary = new Dictionary<char, List<int>>();
                Dictionary<char, List<int>> guessDictionary = new Dictionary<char, List<int>>();

                for (int index = 0; index < secret.Length; index++)
                {
                    if (secretDictionary.ContainsKey(secret[index]))
                    {
                        secretDictionary[secret[index]].Add(index);
                    }
                    else
                    {
                        secretDictionary.Add(secret[index], new List<int>() { index });
                    }
                }

                Console.WriteLine("ch");
                for (int index = 0; index < guess.Length; index++)
                {
                    if (guessDictionary.ContainsKey(guess[index]))
                    {
                        guessDictionary[guess[index]].Add(index);
                    }
                    else
                    {
                        guessDictionary.Add(guess[index], new List<int>() { index });
                    }
                }

                Console.WriteLine("ch");
                int totalbulls = 0;
                int totalcows = 0;
                foreach (var keypair in secretDictionary)
                {
                    int bulls = 0;
                    int cows = 0;
                    if (guessDictionary.ContainsKey(keypair.Key))
                    {
                        for (int i = 0; i < secretDictionary[keypair.Key].Count; i++)
                        {
                            for (int j = 0; j < guessDictionary[keypair.Key].Count; j++)
                            {
                                if (secretDictionary[keypair.Key][i] == guessDictionary[keypair.Key][j])
                                {
                                    bulls++;
                                }
                            }
                        }

                        if (secretDictionary[keypair.Key].Count <= guessDictionary[keypair.Key].Count)
                        {
                            if (bulls < secretDictionary[keypair.Key].Count)
                                cows = secretDictionary[keypair.Key].Count - bulls;
                        }
                        else
                        {
                            if (guessDictionary[keypair.Key].Count > 0)
                            {
                                cows = guessDictionary[keypair.Key].Count - bulls;
                            }
                        }
                    }
                    totalbulls = totalbulls + bulls;
                    totalcows = totalcows + cows;

                }

                return $"{totalbulls}A{totalcows}B";
            }
        }
    }
}
