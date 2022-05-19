using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    class LevelOrderTraversal
    {
        public void Travers(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count>0)
            {
                var node = queue.Dequeue();
                System.Console.Write($"=>: {node.val}");

                if(node.left!=null)
                {
                    queue.Enqueue(node.left);
                }

                if(node.right!=null)
                {
                    queue.Enqueue(node.right);
                }
            }

        }
    }
}
