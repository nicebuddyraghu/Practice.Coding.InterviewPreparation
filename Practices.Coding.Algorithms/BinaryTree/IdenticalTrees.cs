namespace Practices.Coding.Algorithms.BinaryTree
{
    public class IdenticalTrees 
    {
        public bool IsIdentifical(BinaryTree root1, BinaryTree root2)
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
                if(root1.Data == root2.Data)
                {
                    identical = true;
                }
           }
            
           var leftidentical = IsIdentifical(root1.LeftTree, root2.LeftTree);
           if (leftidentical == false)
               return leftidentical;

           var rightidentical = IsIdentifical(root1.RighTree, root2.RighTree);
           if (rightidentical == false)
               return rightidentical;

           return identical;
        }
    }
}
