namespace Practices.Coding.Algorithms.BinaryTree
{
    public class BinaryTree
    {
        public BinaryTree(int data, BinaryTree leftTree, BinaryTree rightTree)
        {
            this.Data = data;
            this.LeftTree = leftTree;
            this.RighTree = rightTree;
        }
        public int Data { get; set; }
        public BinaryTree LeftTree { get; set; }
        public BinaryTree RighTree { get; set; }
    }
}
