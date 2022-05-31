using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    /*
     * 
     * https://leetcode.com/problems/implement-trie-prefix-tree/
     * 
     * 
     */
    public class TrieImplementation
    {
        public class TrieNode
        {
            public static int AlphabetSize = 26;

            public TrieNode[] ChildNodes { get; }
            public char Data { get; }
            public int EndOfWord { get; set; }

            public TrieNode(char data)
            {
                Data = data;
                EndOfWord = 0;
                ChildNodes = new TrieNode[TrieNode.AlphabetSize];
                for (int index = 0; index < 26; index++)
                {
                    ChildNodes[index] = null;
                }
            }
        }
        public class Trie
        {

            TrieNode root = new TrieNode('/');

            public Trie()
            {

            }

            public void Insert(string word)
            {

                var rootnode = root;

                for (int index = 0; index <= word.Length - 1; index++)
                {
                    int trieindex = word[index] - 'a';
                    TrieNode childNode = null;
                    if (rootnode.ChildNodes[trieindex] == null)
                    {
                        childNode = new TrieNode(word[index]);
                        rootnode.ChildNodes[trieindex] = childNode;
                    }
                    else
                    {
                        childNode = rootnode.ChildNodes[trieindex];
                    }

                    if (index == word.Length - 1)
                    {
                        childNode.EndOfWord = 1;
                    }
                    rootnode = childNode;
                }
            }

            public bool Search(string word)
            {

                var rootnode = root;

                for (int index = 0; index <= word.Length - 1; index++)
                {
                    int trieindex = word[index] - 'a';
                    TrieNode childNode = null;
                    if (rootnode.ChildNodes[trieindex] == null)
                    {
                        return false;
                    }
                    else
                    {
                        childNode = rootnode.ChildNodes[trieindex];
                    }

                    if (childNode == null)
                        return false;
                    if (index == word.Length - 1 && childNode.EndOfWord == 1)
                    {
                        return true;
                    }
                    rootnode = childNode;
                }

                return false;
            }

            public bool StartsWith(string prefix)
            {
                var rootnode = root;

                for (int index = 0; index <= prefix.Length - 1; index++)
                {
                    int trieindex = prefix[index] - 'a';
                    TrieNode childNode = null;
                    if (rootnode.ChildNodes[trieindex] == null)
                    {
                        return false;
                    }
                    else
                    {
                        childNode = rootnode.ChildNodes[trieindex];
                    }

                    if (childNode == null)
                        return false;

                    if (index == prefix.Length - 1)
                    {
                        return true;
                    }
                    rootnode = childNode;
                }

                return false;
            }
        }

        /**
         * Your Trie object will be instantiated and called as such:
         * Trie obj = new Trie();
         * obj.Insert(word);
         * bool param_2 = obj.Search(word);
         * bool param_3 = obj.StartsWith(prefix);
         */
    }
}
