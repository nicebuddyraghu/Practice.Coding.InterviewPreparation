using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class RootToLeafNodes
    {
        List<List<BinaryTree>> rootToNodeList = new List<List<BinaryTree>>();
        public List<List<BinaryTree>> GetRootToLeaveNodes(BinaryTree root)
        {
            TraverseTree(root, new List<BinaryTree>());

            foreach(var item in rootToNodeList)
            {
                foreach(var val in item)
                {
                    System.Console.Write($"=>: {val.Data}");
                }
                System.Console.WriteLine();
            }
            return rootToNodeList;
        }

        public void TraverseTree(BinaryTree root, List<BinaryTree> path)
        {
            if (root == null)
                return;

            path.Add(root);

            if (root.LeftTree != null)
            {
                var newleftpath = new List<BinaryTree>();
                newleftpath.AddRange(path);
                TraverseTree(root.LeftTree, newleftpath);
            }

            if (root.RighTree != null)
            {
                var newrightpath = new List<BinaryTree>();
                newrightpath.AddRange(path);
                TraverseTree(root.RighTree, newrightpath);
            }

            if(root.LeftTree==null && root.RighTree==null)
            {
                rootToNodeList.Add(path);
            }
        }
    }
}
