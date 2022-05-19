namespace Practices.Coding.Algorithms.BinaryTree
{
    public class Mirror
    {
        public TreeNode GetTree(TreeNode root)
        {
            if (root == null) return null;

            var mirronode = new TreeNode(root.val, null, null);

            if(root.left!=null)
            {
                mirronode.right = GetTree(root.left);
            }
            if(root.right!=null)
            {
                mirronode.left = GetTree(root.right);
            }

            return mirronode;
        }

        public bool CheckMirror(TreeNode root1, TreeNode root2)
        {
            bool ismirror = false;
            if (root1 == null && root2 == null)
            {
                ismirror = true;
                return ismirror;
            }
            else if(root1==null && root2!=null)
            {
                ismirror = false;
                return ismirror;
            }
            else if(root1!=null && root2==null)
            {
                ismirror = false;
                return ismirror;
            }
            
            if (root1.val == root2.val)
                ismirror = true;
            

            var ismirrorleftnode = CheckMirror(root1.left, root2.right);
            var ismirrorrightnode = CheckMirror(root1.right, root2.left);

            return ismirrorleftnode && ismirrorrightnode && ismirror;
        }
    }
}
