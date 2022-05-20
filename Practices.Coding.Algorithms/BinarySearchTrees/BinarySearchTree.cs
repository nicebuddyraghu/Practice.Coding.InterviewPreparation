namespace Practices.Coding.Algorithms.BinarySearchTrees
{
    public class BinarySearchTree
    {
        public int val { get; set; }
        public BinarySearchTree left { get; set; }
        public BinarySearchTree right { get; set; }
        public BinarySearchTree(int data, BinarySearchTree lefttree, BinarySearchTree righttree)
        {
            val = data;
            left = lefttree;
            right = righttree;
        }
    }
}
