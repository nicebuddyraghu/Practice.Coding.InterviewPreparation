using System;

namespace Practices.Coding.Algorithms.StringMatching
{
    public class Trie
    {
        static readonly int AlphabetSize = 26;

        public Trie()
        {
            rootNode = new TrieNode();
        }

        public class TrieNode
        {
            public TrieNode[] subNodes = new TrieNode[AlphabetSize];

            public bool isEndOfWord;

            public Char word { get; set; }
            public TrieNode()
            {
                isEndOfWord = false;
                for(int index=0;index<AlphabetSize;index++)
                {
                    subNodes[index] = null;
                }
            }
        }

        public TrieNode rootNode { get; set; }
        public void Insert(string str)
        {
            var root = rootNode;
            for (int index=0;index<str.Length;index++)
            {
                char ch = str[index];
                int subnodeindex = ch - 'a';

                if(root.subNodes[subnodeindex]==null)
                {
                    root.subNodes[subnodeindex] = new TrieNode();
                    root.subNodes[subnodeindex].word = ch;
                }
                root = root.subNodes[subnodeindex];
            }

            root.isEndOfWord = true;
        }

        public bool Search(string key)
        {
            var root = rootNode;
            bool stringexists = false;
            for (int index = 0; index < key.Length; index++)
            {
                char ch = key[index];
                int subnodeindex = ch - 'a';

                if (root.subNodes[subnodeindex] != null)
                {
                    root = root.subNodes[subnodeindex];

                    if (index == key.Length - 1 && root.isEndOfWord)
                    {
                        stringexists = true;
                        break;
                    }
                }
            }

            return stringexists;
        }

        public void Delete(string str)
        {
            System.Collections.Generic.Stack<TrieNode> trienodestack = new System.Collections.Generic.Stack<TrieNode>();
            var root = rootNode;
            bool stringexists = false;
            for (int index = 0; index < str.Length; index++)
            {
                char ch = str[index];
                int subnodeindex = ch - 'a';

                if (root.subNodes[subnodeindex] != null)
                {
                    root = root.subNodes[subnodeindex];
                    trienodestack.Push(root);

                    if (index == str.Length - 1 && root.isEndOfWord)
                    {
                        root.isEndOfWord = false;
                        stringexists = true;
                        break;
                    }
                }
            }

            if (stringexists)
            {
                int previouseindex = -1;
                for (int index = str.Length-1; index >=0; index++)
                {
                    char ch = str[index];
                    int subnodeindex = ch - 'a';
                    var node = trienodestack.Pop();

                    if(previouseindex>0)
                    {
                        node.subNodes[previouseindex] = null;
                    }
                    previouseindex = subnodeindex;
                }
            }
        }
    }
}
