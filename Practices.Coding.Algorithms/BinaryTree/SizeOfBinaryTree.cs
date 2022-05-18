namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SizeOfBinaryTree
    {
        public int GetSize(BinaryTree root)
        {
            int sum = 0;
            if (root == null)
            {
                return sum;
            }
            else
            {
                if (root.LeftTree != null)
                    sum += GetSize(root.LeftTree);
                if (root.RighTree != null)
                    sum += GetSize(root.RighTree);

                sum += 1; //Including the current node.
            }

            return sum;
        }
    }
}
