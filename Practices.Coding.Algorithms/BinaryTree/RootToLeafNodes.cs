using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class RootToLeafNodes
    {
        List<List<TreeNode>> rootToNodeList = new List<List<TreeNode>>();
        public List<List<TreeNode>> GetRootToLeaveNodes(TreeNode root)
        {
            TraverseTree(root, new List<TreeNode>());

            foreach(var item in rootToNodeList)
            {
                foreach(var val in item)
                {
                    System.Console.Write($"=>: {val.val}");
                }
                System.Console.WriteLine();
            }
            return rootToNodeList;
        }

        public void TraverseTree(TreeNode root, List<TreeNode> path)
        {
            if (root == null)
                return;

            path.Add(root);

            if (root.left != null)
            {
                var newleftpath = new List<TreeNode>();
                newleftpath.AddRange(path);
                TraverseTree(root.left, newleftpath);
            }

            if (root.right != null)
            {
                var newrightpath = new List<TreeNode>();
                newrightpath.AddRange(path);
                TraverseTree(root.right, newrightpath);
            }

            if(root.left==null && root.right==null)
            {
                rootToNodeList.Add(path);
            }
        }
    }
}
