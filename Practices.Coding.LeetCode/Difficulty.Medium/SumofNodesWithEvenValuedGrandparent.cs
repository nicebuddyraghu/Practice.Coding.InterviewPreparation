using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class SumofNodesWithEvenValuedGrandparent
    {
        /**
         *
         *https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/submissions/
         *
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

            List<TreeNode> evenvaluedchildren = new List<TreeNode>();

            internal int SumEvenGrandparent(TreeNode root)
            {

                TraverseTree(root);

                int sum = 0;
                foreach (var node in evenvaluedchildren)
                {
                    if (node.left != null)
                        sum += node.left.val;
                    if (node.right != null)
                        sum += node.right.val;
                }

                return sum;
            }

            public void TraverseTree(TreeNode root)
            {
                bool evenparent = false;

                if (root.val % 2 == 0)
                    evenparent = true;

                if (root.left != null)
                {
                    if (evenparent)
                        evenvaluedchildren.Add(root.left);
                    TraverseTree(root.left);
                }

                if (root.right != null)
                {
                    if (evenparent)
                        evenvaluedchildren.Add(root.right);
                    TraverseTree(root.right);
                }


            }
        }
    }
}
