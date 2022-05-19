namespace Practices.Coding.Algorithms.BinaryTree
{
    public class DiameterOfBinaryTreeWithNodes
    {
            public int DiameterOfBinaryTree(TreeNode root)
            {

                if (root == null)
                    return 0;

                int leftheight = HeightOfBinaryTree(root.left);

                int rightheight = HeightOfBinaryTree(root.right);

                int leftdiameter = DiameterOfBinaryTree(root.left);

                int rightdiameter = DiameterOfBinaryTree(root.right);

                var nodediameter = leftheight + rightheight+1;
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
