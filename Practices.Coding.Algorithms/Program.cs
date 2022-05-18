using System;

namespace Practices.Coding.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Practices.Coding.Algorithms.BinaryTree.BinaryTree(1, null, null);
            var node2 = new Practices.Coding.Algorithms.BinaryTree.BinaryTree(2, null, null);
            var node3 = new Practices.Coding.Algorithms.BinaryTree.BinaryTree(3, null, null);
            var node4 = new Practices.Coding.Algorithms.BinaryTree.BinaryTree(4, null, null);
            var node5 = new Practices.Coding.Algorithms.BinaryTree.BinaryTree(5, null, null);
            var node6 = new Practices.Coding.Algorithms.BinaryTree.BinaryTree(6, null, null);
            var node7 = new Practices.Coding.Algorithms.BinaryTree.BinaryTree(7, null, null);

            root.LeftTree = node2;
            root.RighTree = node3;
            node2.LeftTree = node4;
            node2.RighTree = node5;
            node3.LeftTree = node6;
            node3.RighTree = node7;

            //Tree Traverse.
            /*
            Console.WriteLine("PreOrder Recursive.");
            Practices.Coding.Algorithms.BinaryTree.PreOrderTraversal preOrderRecursive = new BinaryTree.PreOrderTraversal();
            preOrderRecursive.Traverse(root);
            Console.WriteLine();
            Console.WriteLine("PreOrder Non-Recursive.");
            Practices.Coding.Algorithms.BinaryTree.PreOrderTraversalNonRecurisve preOrderNonRecursive = new BinaryTree.PreOrderTraversalNonRecurisve();
            preOrderNonRecursive.Traverse(root);
            
            Console.WriteLine();

            Console.WriteLine("InOrder Recursive.");
            Practices.Coding.Algorithms.BinaryTree.InOrderTraversal inOrderRecursive = new BinaryTree.InOrderTraversal();
            inOrderRecursive.Traverse(root);
            Console.WriteLine();
            Console.WriteLine("InOrder Non-Recursive.");
            Practices.Coding.Algorithms.BinaryTree.InOrderTraversalNonRecurisve inOrderNonRecursive = new BinaryTree.InOrderTraversalNonRecurisve();
            inOrderNonRecursive.Traverse(root);
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("PostOrder Recursive.");
            Practices.Coding.Algorithms.BinaryTree.PostOrderTraversal postOrderRecursive = new BinaryTree.PostOrderTraversal();
            postOrderRecursive.Traverse(root);
            Console.WriteLine();
            Console.WriteLine("PostOrder Non-Recursive.");
            Practices.Coding.Algorithms.BinaryTree.PostOrderTraversalNonRecurisve postOrderNonRecursive = new BinaryTree.PostOrderTraversalNonRecurisve();
            postOrderNonRecursive.Traverse(root);
            Console.WriteLine();

            Console.WriteLine("LevelOrder Non Recursive.");
            Practices.Coding.Algorithms.BinaryTree.LevelOrderTraversal levelOrderTraversal = new BinaryTree.LevelOrderTraversal();
            levelOrderTraversal.Travers(root);
            Console.WriteLine();

            **/

            //Find Max
            /*
            Practices.Coding.Algorithms.BinaryTree.FindMaximumInABinaryTree findMaxRecursive = new BinaryTree.FindMaximumInABinaryTree();
            int max = findMaxRecursive.Traverse(root,root.Data);
            Console.WriteLine($"Max in Recursive Mode: {max}");
            Console.WriteLine();

            Practices.Coding.Algorithms.BinaryTree.FindMaxInBinaryTreeNonRecursive findMaxInBinaryTreeNonRecursive = new BinaryTree.FindMaxInBinaryTreeNonRecursive();
            max = findMaxInBinaryTreeNonRecursive.Traverse(root, root.Data);
            Console.WriteLine($"Max in Recursive Mode: {max}");
            Console.WriteLine();

            ***/

            //Search.
            /**
            
            Practices.Coding.Algorithms.BinaryTree.SearchElementInBinaryTreeRecursive searchElementInBinaryTreeRecursive = new BinaryTree.SearchElementInBinaryTreeRecursive();
            var exists = searchElementInBinaryTreeRecursive.Search(root, 10);
            Console.WriteLine($"Values Exists: {exists}");
            Console.WriteLine();

            Practices.Coding.Algorithms.BinaryTree.SearchElementinBinaryTreeNonRecursive searchElementinBinaryTreeNonRecursive = new BinaryTree.SearchElementinBinaryTreeNonRecursive();
            exists = searchElementinBinaryTreeNonRecursive.Search(root, 7);
            Console.WriteLine($"Values Exists: {exists}");
            Console.WriteLine();

            **/

            //Size
            /*
            Practices.Coding.Algorithms.BinaryTree.SizeOfBinaryTree sizeOfBinaryTree = new BinaryTree.SizeOfBinaryTree();
            int size = sizeOfBinaryTree.GetSize(root);
            Console.WriteLine($"Size of the Tree In Recursive Mode: {size}");
            Console.WriteLine();

            Practices.Coding.Algorithms.BinaryTree.SizeOfBinaryTreeNonRecursive sizeOfBinaryTreeNonRecursive = new BinaryTree.SizeOfBinaryTreeNonRecursive();
            size = sizeOfBinaryTreeNonRecursive.GetSize(root);
            Console.WriteLine($"Size of the Tree in NonRecursive Mode: {size}");
            Console.WriteLine();
            **/
            
            //Level order in reverse Order.
            /*
             * 
            Practices.Coding.Algorithms.BinaryTree.LevelOrderOfTreeInReverseOrder levelOrderOfTreeInReverseOrder = new BinaryTree.LevelOrderOfTreeInReverseOrder();
            levelOrderOfTreeInReverseOrder.LevelOrderInReverseOrder(root);
            Console.WriteLine();

            **/


            Console.WriteLine("Press Any Key To Exit!");
            Console.ReadLine();
        }
    }
}
