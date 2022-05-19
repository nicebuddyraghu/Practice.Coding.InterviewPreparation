using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PreOrderTraversalNonRecurisve
    {
        public void Traverse(TreeNode root)
        {
            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            var node = root;
            treeStack.Push(root);
            while (treeStack.Count > 0)
            {
                node = treeStack.Pop();
                System.Console.Write($"=>: {node.val}");

                if (node.right != null)
                {
                    treeStack.Push(node.right);
                }

                if (node.left != null)
                {
                    treeStack.Push(node.left);
                }
            }

        }
    }
}
