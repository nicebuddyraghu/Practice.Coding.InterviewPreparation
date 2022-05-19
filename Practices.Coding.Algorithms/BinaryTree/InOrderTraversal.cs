namespace Practices.Coding.Algorithms.BinaryTree
{
    public class InOrderTraversal
    {
        public void Traverse(TreeNode root)
        {
            if (root == null) return;
            if (root.left != null) Traverse(root.left);
            System.Console.Write($"=>: {root.val}");
            if (root.right != null) Traverse(root.right);
        }
    }
}
