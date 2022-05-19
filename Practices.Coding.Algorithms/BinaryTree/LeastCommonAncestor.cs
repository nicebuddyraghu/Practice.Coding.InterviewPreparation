using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class LeastCommonAncestor
    {
        //Need to revise this code. leetcode is showing time limit exceeded.
        public class Solution
        {
            public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
            {

                TraverseTree(root, new List<TreeNode>(), p);
                TraverseTree(root, new List<TreeNode>(), q);

                Console.WriteLine(rootToNodeList.Count);
                int leftindex = 0;
                int rightindex = 0;
                var leftlist = rootToNodeList[0];
                var rightlist = rootToNodeList[1];
                while (leftindex < leftlist.Count && rightindex < rightlist.Count)
                {
                    if (leftlist[leftindex] != rightlist[rightindex])
                    {
                        return leftlist[leftindex - 1];
                    }
                    else
                    {
                        leftindex++;
                        rightindex++;
                    }
                }
                Console.WriteLine($"Index:{leftindex}");
                Console.WriteLine($"leftlist:{leftlist.Count}");
                Console.WriteLine($"rightlist:{rightlist.Count}");
                return leftlist[leftindex - 1];
            }

            List<List<TreeNode>> rootToNodeList = new List<List<TreeNode>>();

            public void TraverseTree(TreeNode root, List<TreeNode> path, TreeNode findnode)
            {
                if (root == null)
                    return;

                path.Add(root);

                if (root == findnode)
                {
                    rootToNodeList.Add(path);
                }

                if (root.left != null)
                {
                    var newleftpath = new List<TreeNode>();
                    newleftpath.AddRange(path);
                    TraverseTree(root.left, newleftpath, findnode);
                }

                if (root.right != null)
                {
                    var newrightpath = new List<TreeNode>();
                    newrightpath.AddRange(path);
                    TraverseTree(root.right, newrightpath, findnode);
                }


            }
        }
    }
}
