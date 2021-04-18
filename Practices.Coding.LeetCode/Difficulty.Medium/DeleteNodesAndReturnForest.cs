using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class DeleteNodesAndReturnForest
    {
        /**
         * 
         * 
         * https://leetcode.com/problems/delete-nodes-and-return-forest/submissions/
         * 
         * 
         * 
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

        public class Solution
        {

            IList<TreeNode> nodeList = new List<TreeNode>();

            public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
            {



                root = TraverseTree(root, to_delete);
                nodeList.Add(root);
                int count = nodeList.Count;

                for (int index = 0; index < count; index++)
                {
                    if (nodeList[index] == null)
                        nodeList.RemoveAt(index);
                }

                return nodeList;
            }

            public TreeNode TraverseTree(TreeNode root, int[] to_delete)
            {
                if (root == null)
                    return null;

                bool todelete = false;
                foreach (var delete in to_delete)
                {
                    if (delete == root.val)
                        todelete = true;
                }

                if (!todelete)
                {
                    if (root.left != null)
                    {
                        root.left = TraverseTree(root.left, to_delete);
                    }
                    if (root.right != null)
                    {
                        root.right = TraverseTree(root.right, to_delete);
                    }
                }
                else
                {
                    if (root.left != null)
                    {
                        root.left = TraverseTree(root.left, to_delete);
                        if (root.left != null)
                            nodeList.Add(root.left);
                    }
                    if (root.right != null)
                    {
                        root.right = TraverseTree(root.right, to_delete);
                        if (root.right != null)
                            nodeList.Add(root.right);
                    }

                    root = null;
                }

                return root;
            }

        }

    }
}
