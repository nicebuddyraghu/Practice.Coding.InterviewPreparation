using System;

namespace Practices.Coding.Algorithms.Graphs
{
    public class DFSRecursive
    {
        public void Traverse(GraphAdjLinkedList<int> graph, int start, int[] visisted, System.Collections.Generic.Stack<int> stack)
        {
            var node = graph.AdjList[graph.Indextable[start]];
            visisted[graph.Indextable[start]] = 1;
           
            if (node == null) return;
            while(node!=null)
            {
                if(visisted[graph.Indextable[node.Vertex]]==0)
                    Traverse(graph, node.Vertex, visisted,stack);
               else
                    node = node.Next;
            }
            stack.Push(start);
        }
    }
}
