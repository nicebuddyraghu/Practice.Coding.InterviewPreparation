using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.StringMatching
{
    public class TernaryTreeNode
    {
        public TernaryTreeNode(char ch, TernaryTreeNode leftnode, TernaryTreeNode equalnode, TernaryTreeNode rightnode, int isEndofWord)
        {
            data = ch;
            left = leftnode;
            right = rightnode;
            equal = equalnode;
            EndofWord = isEndofWord;
        }
        public Char data { get; set; }
        public int EndofWord { get; set; }

        public TernaryTreeNode left { get; set; }
        public TernaryTreeNode equal { get; set; }
        public TernaryTreeNode right { get; set; } 

    }

    public class TernaryTree
    {
       
        public void Insert(string key, TernaryTreeNode root)
        {
            IList<IList<int>> list = new List<IList<int>>();
            for(int index=0;index<key.Length;index++)
            {
                var ch = key[index];

                if (root != null)
                {
                    if (ch < root.data)
                    {
                        root.left = new TernaryTreeNode(ch, null, null, null, 0);
                    }
                    else if (ch > root.data)
                    {
                    }
                    else
                    {
                    }
                }
                else
                {
                    root = new TernaryTreeNode(ch, null, null, null, 0);
                }
            }
        }
    }
}
