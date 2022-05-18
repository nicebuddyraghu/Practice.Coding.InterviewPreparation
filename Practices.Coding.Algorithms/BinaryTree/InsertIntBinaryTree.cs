using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class InsertIntBinaryTree
    {
        public void Insert(BinaryTree root, int value)
        {
            Queue<BinaryTree> nodeQueue = new Queue<BinaryTree>();

            nodeQueue.Enqueue(root);
            while(nodeQueue.Count>0)
            {
                var node = nodeQueue.Dequeue();

                if(node.LeftTree==null && node.RighTree==null)
                {
                    node.LeftTree = new BinaryTree(value, null, null);
                    break;
                }

                if(node.LeftTree!=null)
                {
                    nodeQueue.Enqueue(node.LeftTree);
                }
                else
                {
                    node.LeftTree = new BinaryTree(value, null, null);
                    break;
                }

                if(node.RighTree!=null)
                {
                    nodeQueue.Enqueue(node.RighTree);
                }
                else
                {
                    node.LeftTree = new BinaryTree(value, null, null);
                    break;
                }
            }
        }
    }
}
