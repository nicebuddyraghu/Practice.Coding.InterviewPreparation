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


    public class BinarySearchTreeImplementation
    {
        public BinarySearchTree Insert(BinarySearchTree root, int data)
        {
            if (root == null)
            {
                var node = new BinarySearchTree(data, null, null);
                return node;
            }
            if(root.val>data)
            {
                root.left=Insert(root.left, data);
            }
            else
            {
                root.right=Insert(root.right, data);
            }

            return root;
        }

        public BinarySearchTree FindMax(BinarySearchTree root)
        {
            if (root == null)
                return null;

           while(root.right!=null)
            {
                root = root.right;
            }

            return root;
        }

        public BinarySearchTree FindMin(BinarySearchTree root)
        {
            if(root==null)
            {
                return null;
            }

            while(root.left!=null)
            {
                root = root.left;
            }

            return root;
        }
        public BinarySearchTree Delete(BinarySearchTree root, int data)
        {
            if (root == null)
                return null;

            if(root.val>data)
            {
                root.left = Delete(root.left, data);
            }
            else if(root.val<data)
            {
                root.right = Delete(root.right, data);
            }
            else
            {
                if(root.left!=null && root.right!=null)
                {
                    var tempdeletenode = FindMax(root.left);
                    root.val = tempdeletenode.val;
                    root.left = Delete(root.left, tempdeletenode.val);
                }
                else
                {
                    if (root.left == null)
                    {
                        root = root.right;
                    }
                    if(root.right==null)
                    {
                        root = root.left;
                    }
                }

            }

            return root;
        }
    }
}
