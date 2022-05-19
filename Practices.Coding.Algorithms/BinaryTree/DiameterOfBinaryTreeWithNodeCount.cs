namespace Practices.Coding.Algorithms.BinaryTree
{
    public class DiameterOfBinaryTreeWithNodes
    {
            public int DiameterOfBinaryTree(BinaryTree root)
            {

                if (root == null)
                    return 0;

                int leftheight = HeightOfBinaryTree(root.LeftTree);

                int rightheight = HeightOfBinaryTree(root.RighTree);

                int leftdiameter = DiameterOfBinaryTree(root.LeftTree);

                int rightdiameter = DiameterOfBinaryTree(root.RighTree);

                var nodediameter = leftheight + rightheight+1;
                var descendentdiameter = leftdiameter > rightdiameter ? leftdiameter : rightdiameter;

                return nodediameter > descendentdiameter ? nodediameter : descendentdiameter;

            }

            public int HeightOfBinaryTree(BinaryTree root)
            {
                if (root == null)
                    return 0;

                var leftheight = HeightOfBinaryTree(root.LeftTree);
                var rightheight = HeightOfBinaryTree(root.RighTree);

                var height = (leftheight > rightheight ? leftheight : rightheight) + 1;
                return height;
            }
        }
    }
