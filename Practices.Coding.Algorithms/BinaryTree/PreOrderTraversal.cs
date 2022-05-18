namespace Practices.Coding.Algorithms.BinaryTree
{
    public class PreOrderTraversal
    {
        public void Traverse(BinaryTree root)
        {
            if (root == null) return;
            System.Console.Write($"=>: {root.Data}");
            if (root.LeftTree != null) Traverse(root.LeftTree);
            if (root.RighTree != null) Traverse(root.RighTree);
        }
    }
}
