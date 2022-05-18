namespace Practices.Coding.Algorithms.BinaryTree
{
    public class InOrderTraversal
    {
        public void Traverse(BinaryTree root)
        {
            if (root == null) return;
            if (root.LeftTree != null) Traverse(root.LeftTree);
            System.Console.Write($"=>: {root.Data}");
            if (root.RighTree != null) Traverse(root.RighTree);
        }
    }
}
