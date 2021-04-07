using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.LeetCode
{
    /***
     *
     *
     *https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
     *
     *
     *
     */
    class FindCorrespondingNodeInBinaryTree
    {
       internal class TreeNode {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int x) { val = x; }
       }
         

        internal class Solution
        {
            internal TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
            {

                Stack<TreeNode> nodestack = new Stack<TreeNode>();

                nodestack.Push(cloned);

                TreeNode nodeFound = null;

                while (nodestack.Count > 0)
                {
                    var node = nodestack.Peek();

                    if (node.val == target.val)
                        nodeFound = node;
                    nodestack.Pop();

                    if (node.left != null)
                        nodestack.Push(node.left);
                    if (node.right != null)
                        nodestack.Push(node.right);
                }

                return nodeFound;

            }


        }
    }
}
