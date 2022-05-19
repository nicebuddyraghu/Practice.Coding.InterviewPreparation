namespace Practices.Coding.Algorithms.BinaryTree
{
    public class FindMaximumInABinaryTree
    {
        public int Traverse(TreeNode root, int max)
        {
            if(root.val>max)
            {
                max = root.val;
            }

            if (root.left != null)
            {
                var rightmax = Traverse(root.left, max);
                if(rightmax>max)
                {
                    max = rightmax;
                }
            }

            if (root.right!=null)
            {
                var leftmax = Traverse(root.right, max);
                if(leftmax>max)
                {
                    max = leftmax;
                }
            }

            return max;
        }
    }
}
