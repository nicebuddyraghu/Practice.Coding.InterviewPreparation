namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SearchElementInBinaryTreeRecursive
    {
        public bool Search(TreeNode root, int value)
        {
            if(root.val==value)
            {
                return true;
            }

            if(root.left!=null)
            {
                var leftexists = Search(root.left, value);
                if (leftexists)
                    return true;
            }

            if(root.right!=null)
            {
                var rightexists = Search(root.right, value);
                if (rightexists)
                    return true;
            }

            return false;
        }
    }
}
