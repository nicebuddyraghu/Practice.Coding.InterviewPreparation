using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class ZigZagOrderTraversal
    {
        public void Traverse(TreeNode root)
        {
            root.Level = 0;
            Stack<TreeNode> forwardstack = new Stack<TreeNode>();
            Stack<TreeNode> backwardstack = new Stack<TreeNode>();
            forwardstack.Push(root);
            TreeNode node = root;
            bool toggle = false;
            while (forwardstack.Count>0 || backwardstack.Count>0)
            {
                if (toggle == false)
                {
                    node = forwardstack.Pop();
                }
                else
                {
                    node = backwardstack.Pop();
                }

                System.Console.Write($"=>: {node.val}");

                if (!toggle)
                {
                    if(node.left!=null)
                    {
                        backwardstack.Push(node.left);
                    }
                    if(node.right!=null)
                    {
                        backwardstack.Push(node.right);
                    }
                }
                else
                {
                    if (node.right != null)
                    {
                        forwardstack.Push(node.right);
                    }
                    if (node.left != null)
                    {
                        forwardstack.Push(node.left);
                    }
                }

                if (forwardstack.Count == 0)
                {
                    toggle = true;
                }
                else if (backwardstack.Count == 0)
                {
                    toggle = false;
                }
            }

        }
    }
}
