namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PostOrderTraversal
    {
        public void Traverse(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null) Traverse(root.left);
            if (root.right != null) Traverse(root.right);
            System.Console.Write($"=>: {root.val}");
        }
    }
}
