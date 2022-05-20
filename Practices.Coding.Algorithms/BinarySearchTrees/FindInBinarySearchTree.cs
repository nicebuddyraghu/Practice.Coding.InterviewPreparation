namespace Practices.Coding.Algorithms.BinarySearchTrees
{
    public class FindInBinarySearchTree
    {
        public BinarySearchTree Find(BinarySearchTree root,int target)
        {
            if (root == null)
                return null;
            if(root.val == target)
            {
                return root;
            }

            if (root.val > target)
                return Find(root.left, target);
            else
                return Find(root.right, target);
        }

        public BinarySearchTree FindMinimum(BinarySearchTree root)
        {
            if (root.left != null)
                return FindMinimum(root.left);
            else
                return root;
        }

        public BinarySearchTree FindMaximum(BinarySearchTree root)
        {
            if (root.right != null)
                return FindMaximum(root.right);
            else
                return root;
        }

        public BinarySearchTree Insert(BinarySearchTree root, int insertdata)
        {
            if(root==null)
            {
                return new BinarySearchTree(insertdata, null, null);
            }

            if (root.val > insertdata)
            {
                root.left = Insert(root.left, insertdata);
            }
            else
            {
                root.right = Insert(root.right, insertdata);
            }

            return root;
        }

        public BinarySearchTree DeleteNode(BinarySearchTree root, int deletedata)
        {
            if (root == null)
                return null;

            if(root.val<deletedata)
            {
                root.right = DeleteNode(root.right, deletedata);
            }
            else if(root.val>deletedata)
            {
                root.left = DeleteNode(root.left, deletedata);
            }
            else
            {
                if (root.left == null && root.right == null)
                {
                    return null; 
                }
                else if (root.left != null && root.right == null)
                {
                    return root.left;
                }
                else if(root.left ==null && root.right ==null)
                {
                    return root.right;
                }
                else
                {
                    var maxnode = FindMaximum(root.left);
                    root = new BinarySearchTree(maxnode.val, null, null);
                    maxnode = null;
                }
            }

            return root;
        }
    }
}
