namespace Practices.Coding.Algorithms.BinaryTree
{
    public class FindMaximumInABinaryTree
    {
        public int Traverse(BinaryTree root, int max)
        {
            if(root.Data>max)
            {
                max = root.Data;
            }

            if (root.LeftTree != null)
            {
                var rightmax = Traverse(root.LeftTree, max);
                if(rightmax>max)
                {
                    max = rightmax;
                }
            }

            if (root.RighTree!=null)
            {
                var leftmax = Traverse(root.RighTree, max);
                if(leftmax>max)
                {
                    max = leftmax;
                }
            }

            return max;
        }
    }
}
