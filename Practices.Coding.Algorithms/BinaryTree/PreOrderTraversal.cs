namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PreOrderTraversal
    {
        public void Traverse(TreeNode root)
        {
            if (root == null) return;
            System.Console.Write($"=>: {root.val}");
            if (root.left != null) Traverse(root.left);
            if (root.right != null) Traverse(root.right);
        }
    }
}
