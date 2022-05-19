namespace Practices.Coding.Algorithms.BinaryTree
{
    public class IdenticalTrees 
    {
        public bool IsIdentifical(TreeNode root1, TreeNode root2)
        {
            bool identical = false;
            if(root1==null && root2==null)
            {
                identical = true;
                return identical;
            }
            else if(root1==null && root2!=null)
            {
                identical = false;
                return identical;
            }
            else if(root1!=null && root2==null)
            {
                identical = false;
                return identical;
            }
            else
            {
                if(root1.val == root2.val)
                {
                    identical = true;
                }
           }
            
           var leftidentical = IsIdentifical(root1.left, root2.left);
           if (leftidentical == false)
               return leftidentical;

           var rightidentical = IsIdentifical(root1.right, root2.right);
           if (rightidentical == false)
               return rightidentical;

           return identical;
        }
    }
}
