using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class LeafSimilarTrees
    {
        /**
        * Definition for a binary tree node.
            https://leetcode.com/problems/leaf-similar-trees/submissions/
        */

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

        internal class Solution
        {
            internal bool LeafSimilar(TreeNode root1, TreeNode root2)
            {

                List<int> firsttreelnodes = new List<int>();
                List<int> secondtreelnodes = new List<int>();

                InOrderTreeTraverse(root1, firsttreelnodes);
                InOrderTreeTraverse(root2, secondtreelnodes);

                if (firsttreelnodes.Count() != secondtreelnodes.Count())
                {
                    return false;
                }

                for (int index = 0; index < firsttreelnodes.Count(); index++)
                {
                    if (firsttreelnodes[index] != secondtreelnodes[index])
                        return false;
                }

                return true;
            }

            internal void InOrderTreeTraverse(TreeNode node, List<int> llist)
            {
                if (node == null) return;

                if (node.left == null && node.right == null)
                    llist.Add(node.val);

                if (node.left != null)
                    InOrderTreeTraverse(node.left, llist);
                if (node.right != null)
                    InOrderTreeTraverse(node.right, llist);
            }
        }
    }
}
