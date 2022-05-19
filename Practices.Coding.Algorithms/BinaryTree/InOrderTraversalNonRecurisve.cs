using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class InOrderTraversalNonRecurisve
    {
        public void Traverse(TreeNode root)
        {
            Stack<TreeNode> treeStack = new Stack<TreeNode>();

            while (true)
            {
                while (root != null)
                {
                    treeStack.Push(root);
                    root = root.left;
                }

                if (treeStack.Count == 0) break;
                root = treeStack.Pop();
                System.Console.Write($"=>: {root.val}");
                root = root.right;
            }


        }
    }
}
