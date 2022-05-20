namespace Practices.Coding.Algorithms.BinaryTree
{
    public class TreeNode
    {
        public TreeNode(int val, TreeNode leftTree, TreeNode rightTree)
        {
            this.val = val;
            this.left = leftTree;
            this.right = rightTree;
        }
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
        public int Level { get; set; }
    }
}
