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
    }
}
