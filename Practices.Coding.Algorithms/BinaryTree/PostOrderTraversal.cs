namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PostOrderTraversal
    {
        public void Traverse(BinaryTree root)
        {
            if (root == null) return;
            if (root.LeftTree != null) Traverse(root.LeftTree);
            if (root.RighTree != null) Traverse(root.RighTree);
            System.Console.Write($"=>: {root.Data}");
        }
    }
}
