using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class FindTheDeepestNodeInBinaryTree
    {
        public int FindDeepestNode(BinaryTree root)
        {
            Queue<BinaryTree> nodeQueue = new Queue<BinaryTree>();
            nodeQueue.Enqueue(root);
            Dictionary<BinaryTree, int> nodeLevelDictionary = new Dictionary<BinaryTree, int>();
            nodeLevelDictionary.Add(root, 0);
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                if (node.LeftTree != null)
                {
                    nodeQueue.Enqueue(node.LeftTree);
                    nodeLevelDictionary.Add(node.LeftTree, nodeLevelDictionary[node] + 1);
                }
                if (node.RighTree != null)
                {
                    nodeQueue.Enqueue(node.RighTree);
                    nodeLevelDictionary.Add(node.RighTree, nodeLevelDictionary[node] + 1);
                }
            }

            int height = 0;
            BinaryTree deepestNode = null;

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
