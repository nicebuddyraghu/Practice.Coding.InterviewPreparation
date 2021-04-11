using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class CountGoodNodesInBinaryTree
    {
        /**
        * Definition for a binary tree node.
        https://leetcode.com/problems/count-good-nodes-in-binary-tree/submissions/
        */
        internal class Solution
        {
            internal class TreeNode
            {
                public int val;
                public TreeNode left;
                public TreeNode right;

                public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
                {
                    this.val = val;
                    this.left = left;
                    this.right = right;
                }
            }

            internal int GoodNodes(TreeNode root)
            {

                int goodnodes = GetGoodNodes(root, root.val);

                Console.WriteLine($"Good Nodes Count:{goodnodes}");

                return goodnodes;
            }

            internal int GetGoodNodes(TreeNode root, int max)
            {
                if (root == null) return 0;

                int totalgoodnodes = 0;
                if (max <= root.val)
                {
                    max = root.val;
                    Console.WriteLine($"Good Node:{max}");
                    ++totalgoodnodes;
                }

                if (root.left != null)
                    totalgoodnodes += GetGoodNodes(root.left, max);

                if (root.right != null)
                    totalgoodnodes += GetGoodNodes(root.right, max);

                return totalgoodnodes;
            }
        }
    }
}
