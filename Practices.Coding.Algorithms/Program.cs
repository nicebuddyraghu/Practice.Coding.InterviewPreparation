using System;

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
            //node31.right = node71;
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

            /*
            Practices.Coding.Algorithms.BinaryTree.Mirror mirror = new BinaryTree.Mirror();
            var mirrorTree = mirror.GetTree(root);
            Practices.Coding.Algorithms.BinaryTree.LevelOrderTraversal levelOrderOfTreeOrder = new BinaryTree.LevelOrderTraversal();
            levelOrderOfTreeOrder.Travers(root);
            Console.WriteLine();
            levelOrderOfTreeOrder.Travers(mirrorTree);
            Console.WriteLine();

            var isMirror = mirror.CheckMirror(root, mirrorTree);
            Console.WriteLine($"Is tree mirrored: {isMirror}");

            isMirror = mirror.CheckMirror(root, root1);
            Console.WriteLine($"Is tree mirrored: {isMirror}");

            */

            //ZigZag Trees
            /*
            Practices.Coding.Algorithms.BinaryTree.ZigZagOrderTraversal zigZagOrder = new BinaryTree.ZigZagOrderTraversal();
            zigZagOrder.Traverse(root);
            Console.WriteLine();
            */

            /*
            Practices.Coding.Algorithms.BinarySearchTrees.BinarySearchTree bst = new BinarySearchTrees.BinarySearchTree(4,null,null);
            bst.left = new BinarySearchTrees.BinarySearchTree(3, null, null);
            bst.left.left = new BinarySearchTrees.BinarySearchTree(1, null, null);
            bst.left.right = new BinarySearchTrees.BinarySearchTree(2, null, null);
            bst.right = new BinarySearchTrees.BinarySearchTree(5, null, null);
            bst.right.left = new BinarySearchTrees.BinarySearchTree(6, null, null);
            bst.right.right = new BinarySearchTrees.BinarySearchTree(7, null, null);

            Practices.Coding.Algorithms.BinarySearchTrees.FindInBinarySearchTree findInBinarySearchTree = new BinarySearchTrees.FindInBinarySearchTree();
            var node = findInBinarySearchTree.Find(bst, 1);
            if (node == null)
                Console.WriteLine("Target not exists in the Bst");
            else
                Console.WriteLine($"Target exists in Bst {node.val}");

            node = findInBinarySearchTree.FindMinimum(bst);
            Console.WriteLine($"Minimum in Bst {node.val}");

            node = findInBinarySearchTree.FindMaximum(bst);
            Console.WriteLine($"Maximum in Bst {node.val}");

            node = findInBinarySearchTree.Insert(bst,10);

            Console.WriteLine($"Inserted Node : {node.val}");

            node = findInBinarySearchTree.DeleteNode(bst, 1);
            Console.WriteLine($"deleted node repalced with {node.val}");
            Console.WriteLine();
            */

            //Graph implementation.
            /* 
            char[] vertices = new char[] { 'A', 'B', 'C', 'D', 'E'};
            Graphs.Edge<char> edge1 = new Graphs.Edge<char>('A', 'B');
            Graphs.Edge<char> edge2 = new Graphs.Edge<char>('A', 'C');
            Graphs.Edge<char> edge3 = new Graphs.Edge<char>('B', 'D');
            Graphs.Edge<char> edge4 = new Graphs.Edge<char>('C', 'D');
            Graphs.Edge<char> edge5 = new Graphs.Edge<char>('C', 'E');
            Graphs.Edge<char>[] edges = new Graphs.Edge<char>[] { edge1,edge2,edge3,edge4,edge5};
            Graphs.GraphAdjLinkedList<char> graphAdjLinkedList = new Graphs.GraphAdjLinkedList<char>(vertices, edges);
            graphAdjLinkedList.PrintGraph(graphAdjLinkedList);

            Graphs.GraphAdjList<char> graphAdjList = new Graphs.GraphAdjList<char>(vertices, edges);
            graphAdjList.PrintGraph(graphAdjLinkedList);

            */
            /*
            int[] vertices = new int[] { 0,1,2,3,4,5 };
            Graphs.Edge<int> edge1 = new Graphs.Edge<int>(0, 1);
            Graphs.Edge<int> edge2 = new Graphs.Edge<int>(0, 2);
            Graphs.Edge<int> edge3 = new Graphs.Edge<int>(0, 5);
            Graphs.Edge<int> edge4 = new Graphs.Edge<int>(1, 3);
            Graphs.Edge<int> edge5 = new Graphs.Edge<int>(2, 4);
            Graphs.Edge<int> edge6 = new Graphs.Edge<int>(3, 5);
            Graphs.Edge<int>[] edges = new Graphs.Edge<int>[] { edge1, edge2, edge3, edge4, edge5,edge6 };
            Graphs.GraphAdjLinkedList<int> graphAdjLinkedList = new Graphs.GraphAdjLinkedList<int>(vertices, edges,false);
            graphAdjLinkedList.PrintGraph(graphAdjLinkedList);
            Console.WriteLine();
            */
            //DFS
            /*
            int[] visisted = new int[6] { 0, 0, 0, 0, 0, 0 };
            Graphs.DFSRecursive dfsRecursive = new Graphs.DFSRecursive();
            dfsRecursive.Traverse(graphAdjLinkedList, 0, visisted);
            Console.WriteLine();
            Graphs.DFSNonRecursive dFSNonRecursive = new Graphs.DFSNonRecursive();
            dFSNonRecursive.Traverse(graphAdjLinkedList);
            Console.WriteLine();
            
            Graphs.BFSIterative bfsIterative = new Graphs.BFSIterative();
            bfsIterative.Traverse(graphAdjLinkedList, 0);

            */

            /*
             * 
            int[] vertics = new int[] {2,3,5,7,8,9,10,11 };
            Graphs.Edge<int> edge1 = new Graphs.Edge<int>(7,11);
            Graphs.Edge<int> edge2 = new Graphs.Edge<int>(7, 8);
            Graphs.Edge<int> edge3 = new Graphs.Edge<int>(5, 11);
            Graphs.Edge<int> edge4 = new Graphs.Edge<int>(3, 8);
            Graphs.Edge<int> edge5 = new Graphs.Edge<int>(11, 2);
            Graphs.Edge<int> edge6 = new Graphs.Edge<int>(11, 9);
            Graphs.Edge<int> edge7 = new Graphs.Edge<int>(8, 9);
            Graphs.Edge<int> edge8 = new Graphs.Edge<int>(11, 10);
            Graphs.Edge<int> edge9 = new Graphs.Edge<int>(3, 10);
            Graphs.Edge<int>[] edges = new Graphs.Edge<int>[] { edge1, edge2, edge3, edge4, edge5, edge6, edge7, edge8, edge9 };

            
            var graph = new Graphs.GraphAdjMatrix<int>(vertics, edges);
            Graphs.TopologicalSortUsingAdjMatrix topologicalSortAdjMatrix = new Graphs.TopologicalSortUsingAdjMatrix();
            topologicalSortAdjMatrix.TopoloicalSort(graph);
            Console.WriteLine();

            var directGraph = new Graphs.GraphAdjLinkedList<int>(vertics, edges);
            Graphs.TopologicalSortUsingAdjList topologicalSortUsingAdjList = new Graphs.TopologicalSortUsingAdjList();
            topologicalSortUsingAdjList.Sort(directGraph);
            */

            Heap.MaxHeap maxheap = new Heap.MaxHeap();
            maxheap.Insert(45);
            maxheap.Insert(20);
            maxheap.Insert(14);
            maxheap.Insert(12);
            maxheap.Insert(31);
            maxheap.Insert(7);
            maxheap.Insert(11);
            maxheap.Insert(13);
            maxheap.Insert(7);

            maxheap.PrintHeap();
            maxheap.Remove(3);
            maxheap.PrintHeap();
            maxheap.Remove(3);
            maxheap.PrintHeap();
            maxheap.Remove(3);
            maxheap.PrintHeap();
            maxheap.Remove(3);
            maxheap.PrintHeap();
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Exit!");
            Console.ReadLine();
        }
    }
}


