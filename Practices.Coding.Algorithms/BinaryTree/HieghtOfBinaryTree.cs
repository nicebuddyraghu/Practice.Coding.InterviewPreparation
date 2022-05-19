using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class HieghtOfBinaryTree
    {
        public int GetHeight(TreeNode root)
        {
            int height = 0;
            int leftheight = 1;
            int rightheight = 1;

            if (root.left != null)
                leftheight += GetHeight(root.left);
            if (root.right != null)
                rightheight += GetHeight(root.right);

            height = (leftheight > rightheight) ? leftheight : rightheight;
            return height - 1;
        }
    }
}
