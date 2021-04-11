using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    internal class AllElementsInTwoBinaryTree
    {
        /**
         * Definition for a binary tree node.
           https://leetcode.com/problems/all-elements-in-two-binary-search-trees/submissions/
        */

        public class TreeNode
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
            internal IList<int> GetAllElements(TreeNode root1, TreeNode root2)
            {

                List<int> newlist = new List<int>();

                GetTreeValues(root1, newlist);
                GetTreeValues(root2, newlist);


                newlist.Sort();

                return newlist;
            }


            internal void GetTreeValues(TreeNode node, IList<int> list)
            {
                if (node == null) return;

                if (node.left != null)
                {
                    GetTreeValues(node.left, list);
                }

                list.Add(node.val);

                if (node.right != null)
                {
                    GetTreeValues(node.right, list);
                }
            }

        }
    }
}
