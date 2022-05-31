using System;
using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /**
     * 
     * 
     * 
     * https://leetcode.com/problems/group-anagrams/
     * 
     */
    class GroupAnagramsOptimal
    {
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {

                Dictionary<string, List<string>> anagramgrouplist = new Dictionary<string, List<string>>();
                
                for (int index = 0; index <= strs.Length - 1; index++)
                {
                    var str = strs[index];
                    var hashkey = GetHash(str);
                    if (anagramgrouplist.ContainsKey(hashkey))
                    {
                        anagramgrouplist[hashkey].Add(str);
                    }
                    else
                    {
                        anagramgrouplist.Add(hashkey, new List<string> { str });
                    }
                }

                IList<IList<string>> list = new List<IList<string>>();

                foreach (var anagramlist in anagramgrouplist.Values)
                {
                    anagramlist.Sort();
                    list.Add(anagramlist);
                }

                return list;
            }

            public string GetHash(string str)
            {
                int[] charlist = new int[26];

                for (int index = 0; index <= 25; index++)
                {
                    charlist[index] = -1;
                }

                for (int index = 0; index <= str.Length - 1; index++)
                {
                    int hashindex = str[index] - 'a';
                    charlist[hashindex] = charlist[hashindex] + 1;
                }

                string hashkey = String.Empty;
                for (int index = 0; index <= 25; index++)
                {
                    hashkey += charlist[index].ToString();
                }

                return hashkey;
            }
        }
    }
}
