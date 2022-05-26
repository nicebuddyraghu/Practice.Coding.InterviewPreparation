namespace Practices.Coding.Algorithms.Sorting
{
    public class TreeSort
    {
        public void Sort(int[] nums)
        {
            BinarySearchTrees.BinarySearchTree binarySearchTree = null;
            BinarySearchTrees.BinarySearchTreeImplementation binarySearchTreeImplementation = new BinarySearchTrees.BinarySearchTreeImplementation();
            
            foreach (var num in nums)
            {
                binarySearchTree = binarySearchTreeImplementation.Insert(binarySearchTree, num);
            }

            Traverse(binarySearchTree);
        }

        public void Traverse(BinarySearchTrees.BinarySearchTree root)
        {
            if (root == null) return;
            if (root.left != null) Traverse(root.left);
            System.Console.Write($"=>: {root.val}");
            if (root.right != null) Traverse(root.right);
        }
    }
}
