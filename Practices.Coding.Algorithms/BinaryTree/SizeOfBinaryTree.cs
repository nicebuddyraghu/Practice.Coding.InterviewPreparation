namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SizeOfBinaryTree
    {
        public int GetSize(TreeNode root)
        {
            int sum = 0;
            if (root == null)
            {
                return sum;
            }
            else
            {
                if (root.left != null)
                    sum += GetSize(root.left);
                if (root.right != null)
                    sum += GetSize(root.right);

                sum += 1; //Including the current node.
            }

            return sum;
        }
    }
}
