﻿using System;

namespace Practices.Coding.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Practices.Coding.Algorithms.BinaryTree.TreeNode(1, null, null);
            var node2 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(2, null, null);
            var node3 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(3, null, null);
            var node4 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(4, null, null);
            var node5 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(5, null, null);
            var node6 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(6, null, null);
            var node7 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(7, null, null);

            root.left = node2;
            root.right = node3;
            node2.left = node4;
            node2.right = node5;
            node3.left = node6;
            node3.right = node7;

            var root1 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(1, null, null);
            var node21 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(2, null, null);
            var node31 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(3, null, null);
            var node41 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(4, null, null);
            var node51 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(5, null, null);
            var node61 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(6, null, null);
            var node71 = new Practices.Coding.Algorithms.BinaryTree.TreeNode(7, null, null);

            root1.left = node21;
            root1.right = node31;
            node21.left = node41;
            node21.right = node51;
            node31.left = node61;
            node31.right = node71;
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

            //Height of the Tree
            /*
            Practices.Coding.Algorithms.BinaryTree.HieghtOfBinaryTreeNonRecursive hieghtOfBinaryTree = new BinaryTree.HieghtOfBinaryTreeNonRecursive();
            var height=hieghtOfBinaryTree.GetHeight(root);
            Console.WriteLine($"Height of the Tree: {height}");
            Console.WriteLine();

            Practices.Coding.Algorithms.BinaryTree.HieghtOfBinaryTreeNonRecursive hieghtOfBinaryTreeNonRecursive = new BinaryTree.HieghtOfBinaryTreeNonRecursive();
            height = hieghtOfBinaryTreeNonRecursive.GetHeight(root);
            Console.WriteLine($"Height of the Tree: {height}");
            Console.WriteLine();
            **/

            // Node count
            /**
            Practices.Coding.Algorithms.BinaryTree.FindNumberOfFullNodes findNumberOfFullNodes = new BinaryTree.FindNumberOfFullNodes();
            var fullnodeCount = findNumberOfFullNodes.GetFullNodeCount(root);
            Console.WriteLine($"full nodes in Tree: {fullnodeCount}");
            Console.WriteLine();

            Practices.Coding.Algorithms.BinaryTree.HalfNodeCount halfnodeCount = new BinaryTree.HalfNodeCount();
            var count = halfnodeCount.GetCount(root);
            Console.WriteLine($"Half nodes in Tree: {count}");
            Console.WriteLine();

            **/

            //Identical nodes.
            /**
            Practices.Coding.Algorithms.BinaryTree.IdenticalTrees findNumberOfFullNodes = new BinaryTree.IdenticalTrees();
            var isIdentical = findNumberOfFullNodes.IsIdentifical(root,root1);
            Console.WriteLine($"Tree are identical: {isIdentical}");
            Console.WriteLine();
            **/

            //Root to leaf nodes.
            /*
            Console.WriteLine();
            Practices.Coding.Algorithms.BinaryTree.RootToLeafNodes rootToLeafNodes = new BinaryTree.RootToLeafNodes();
            rootToLeafNodes.GetRootToLeaveNodes(root);
            Console.WriteLine();
            */

            //Mirror trees
            Practices.Coding.Algorithms.BinaryTree.Mirror mirror = new BinaryTree.Mirror();
            var mirrorTree = mirror.GetTree(root);
            Practices.Coding.Algorithms.BinaryTree.LevelOrderTraversal levelOrderOfTreeOrder = new BinaryTree.LevelOrderTraversal();
            levelOrderOfTreeOrder.Travers(root);
            Console.WriteLine();
            levelOrderOfTreeOrder.Travers(mirrorTree);
            Console.WriteLine();

            Console.WriteLine("Press Any Key To Exit!");
            Console.ReadLine();
        }
    }
}
