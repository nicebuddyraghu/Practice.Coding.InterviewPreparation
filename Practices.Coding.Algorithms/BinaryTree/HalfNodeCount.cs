using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class HalfNodeCount
        {
            public int GetCount(BinaryTree root)
            {
                int fullnodecount = 0;
                Queue<BinaryTree> nodeQueue = new Queue<BinaryTree>();
                nodeQueue.Enqueue(root);
                while (nodeQueue.Count > 0)
                {
                    var node = nodeQueue.Dequeue();
                    if (node.LeftTree != null)
                    {
                        nodeQueue.Enqueue(node.LeftTree);
                    }
                    if (node.RighTree != null)
                    {
                        nodeQueue.Enqueue(node.RighTree);
                    }

                    if ((node.LeftTree != null && node.RighTree == null) || ((node.LeftTree == null && node.RighTree != null)))
                        fullnodecount += 1;
                }
                return fullnodecount;
            }
        }
}
 