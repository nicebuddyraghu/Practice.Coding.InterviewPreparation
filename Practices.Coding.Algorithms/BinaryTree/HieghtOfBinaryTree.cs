using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.BinaryTree
{
    public class HieghtOfBinaryTree
    {
        public int GetHeight(BinaryTree root)
        {
            int height = 0;
            int leftheight = 1;
            int rightheight = 1;

            if (root.LeftTree != null)
                leftheight += GetHeight(root.LeftTree);
            if (root.RighTree != null)
                rightheight += GetHeight(root.RighTree);

            height = (leftheight > rightheight) ? leftheight : rightheight;
            return height - 1;
        }
    }
}
