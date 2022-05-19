using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PostOrderTraversalNonRecurisve
    {
        //Using Two Stack Approach.
        public void Traverse(TreeNode root)
        {
            Stack<TreeNode> treeStack = new Stack<TreeNode>();
            Stack<TreeNode> tempStack = new Stack<TreeNode>();

            treeStack.Push(root);
            while(treeStack.Count>0)
            {
                var node = treeStack.Pop();
                tempStack.Push(node);

                if (node.left != null)
                {
                    treeStack.Push(node.left);
                }

                if(node.right!=null)
                {
                    treeStack.Push(node.right);
                }
            }

            while(tempStack.Count>0)
            {
                var node = tempStack.Pop();
                System.Console.Write($"=>: {node.val}");
            }

        }
    }
}
