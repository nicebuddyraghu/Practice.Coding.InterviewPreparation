using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    internal class MaxDepthofNarryTree
    {
        /***
         * 
         * 
         * https://leetcode.com/problems/maximum-depth-of-n-ary-tree/submissions/
         * 
         */

        // Definition for a Node.
        internal class Node {
            public int val;
            public IList<Node> children;

            public Node() {}

            public Node(int _val) {
                val = _val;
            }

            public Node(int _val, IList<Node> _children) {
                val = _val;
                children = _children;
            }
        }

        internal class Solution
        {
            internal int MaxDepth(Node root)
            {
                int parentDepth = 1;
                int childrenDepth = 0;

                if (root == null)
                    return 0;

                if (root != null && root.children == null)
                {
                    return parentDepth;
                }
                if (root != null && root.children != null)
                {
                    int maxChildDepth = 0;
                    foreach (var child in root.children)
                    {
                        int tempDepth = MaxDepth(child);
                        if (maxChildDepth < tempDepth)
                        {
                            maxChildDepth = tempDepth;
                        }
                    }

                    childrenDepth = maxChildDepth;
                }

                return parentDepth + childrenDepth;

            }
        }
    }
}
