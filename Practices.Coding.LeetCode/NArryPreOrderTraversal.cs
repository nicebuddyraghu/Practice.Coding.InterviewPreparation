using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    public class NArryPreOrderTraversal
    {
        /***
         * 
         * 
         * 
         * https://leetcode.com/problems/n-ary-tree-preorder-traversal/submissions/
         * 
         * 
         */

        // Definition for a Node.
        public class Node {
            public int val;
            public IList<Node> children;

            public Node() {}

            public Node(int _val) {
                val = _val;
            }

            public Node(int _val,IList<Node> _children) {
                val = _val;
                children = _children;
            }
        }

        public class Solution
        {
            public IList<int> Preorder(Node root)
            {

                var list = new List<int>();

                if (root != null)
                    list.Add(root.val);

                if (root != null && root.children != null)
                {
                    foreach (var childnode in root.children)
                    {
                        list.AddRange(Preorder(childnode));
                    }
                }

                return list;

            }
        }
    }
}
