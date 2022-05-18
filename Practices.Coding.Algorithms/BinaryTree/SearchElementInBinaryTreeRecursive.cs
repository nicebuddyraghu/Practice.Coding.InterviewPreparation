namespace Practices.Coding.Algorithms.BinaryTree
{
    public class SearchElementInBinaryTreeRecursive
    {
        public bool Search(BinaryTree root, int value)
        {
            if(root.Data==value)
            {
                return true;
            }

            if(root.LeftTree!=null)
            {
                var leftexists = Search(root.LeftTree, value);
                if (leftexists)
                    return true;
            }

            if(root.RighTree!=null)
            {
                var rightexists = Search(root.RighTree, value);
                if (rightexists)
                    return true;
            }

            return false;
        }
    }
}
