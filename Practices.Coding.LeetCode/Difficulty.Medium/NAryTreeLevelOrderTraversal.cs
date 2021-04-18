using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class NAryTreeLevelOrderTraversal
    {
        /*
         * 
         * 
         * https://leetcode.com/problems/n-ary-tree-level-order-traversal/
         * 
         * 
         * 
         */
        // Definition for a Node.

        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }


        public class Solution
        {

            Dictionary<int, List<int>> elementdictionary = new Dictionary<int, List<int>>();

            public IList<IList<int>> LevelOrder(Node root)
            {
                TraverseTree(root, 1);
                IList<IList<int>> rootlist = new List<IList<int>>();

                foreach (var pair in elementdictionary)
                {
                    rootlist.Add(pair.Value);
                }

                Console.WriteLine(elementdictionary.Count);

                return rootlist;
            }

            public void TraverseTree(Node root, int height)
            {
                if (root == null)
                    return;

                if (elementdictionary.ContainsKey(height))
                {
                    elementdictionary[height].Add(root.val);
                }
                else
                {
                    elementdictionary.Add(height, new List<int>() { root.val });
                }


                if (root.children != null)
                {
                    foreach (var item in root.children)
                    {
                        int tempheight = height;
                        TraverseTree(item, ++tempheight);
                    }
                }

            }

        }
    }
}
