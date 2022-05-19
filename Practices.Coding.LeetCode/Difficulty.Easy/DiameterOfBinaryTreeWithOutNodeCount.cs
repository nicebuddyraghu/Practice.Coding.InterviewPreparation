namespace Practices.Coding.LeetCode.Difficulty.Easy
{
    public class DiameterOfBinaryTreeWithOutNodes
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
 
        /**
         * 
         * https://leetcode.com/problems/diameter-of-binary-tree/submissions/
         */
        public int DiameterOfBinaryTree(TreeNode root)
        {

            if (root == null)
                return 0;

            int leftheight = HeightOfBinaryTree(root.left);

            int rightheight = HeightOfBinaryTree(root.right);

            int leftdiameter = DiameterOfBinaryTree(root.left);

            int rightdiameter = DiameterOfBinaryTree(root.right);

            var nodediameter = leftheight + rightheight;
            var descendentdiameter = leftdiameter > rightdiameter ? leftdiameter : rightdiameter;

            return nodediameter > descendentdiameter ? nodediameter : descendentdiameter;

        }

        public int HeightOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

            var leftheight = HeightOfBinaryTree(root.left);
            var rightheight = HeightOfBinaryTree(root.right);

            var height = (leftheight > rightheight ? leftheight : rightheight) + 1;
            return height;
        }
    }

}
