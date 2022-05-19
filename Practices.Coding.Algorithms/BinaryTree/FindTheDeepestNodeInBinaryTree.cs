using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class FindTheDeepestNodeInBinaryTree
    {
        public int FindDeepestNode(TreeNode root)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            Dictionary<TreeNode, int> nodeLevelDictionary = new Dictionary<TreeNode, int>();
            nodeLevelDictionary.Add(root, 0);
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                if (node.left != null)
                {
                    nodeQueue.Enqueue(node.left);
                    nodeLevelDictionary.Add(node.left, nodeLevelDictionary[node] + 1);
                }
                if (node.right != null)
                {
                    nodeQueue.Enqueue(node.right);
                    nodeLevelDictionary.Add(node.right, nodeLevelDictionary[node] + 1);
                }
            }

            int height = 0;
            TreeNode deepestNode = null;

            foreach (var item in nodeLevelDictionary.Keys)
            {
                if (height < nodeLevelDictionary[item])
                {
                    height = nodeLevelDictionary[item];
                    deepestNode = item;
                }
            }

            return height;
        }
    }
}
