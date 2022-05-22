using System;

namespace Practices.Coding.Algorithms.Graphs
{
    public class DFSRecursive
    {
        public void Traverse(GraphAdjLinkedList<int> graph, int start, int[] visisted)
        {
            Console.WriteLine($"DFS Visisted=>{start}");
            visisted[start] = 1;
            var node = graph.AdjList[start];
            if (node == null) return;
            while(node!=null)
            {
                if(visisted[node.Vertex]==0)
                    Traverse(graph, node.Vertex, visisted);
               else
                    node = node.Next;
            }
        }
    }
}
