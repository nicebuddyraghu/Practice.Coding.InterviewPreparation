using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Graphs
{
    public class DFSNonRecursive
    {
        public void Traverse(GraphAdjLinkedList<int> graph)
        {
            Stack<int> dfsstack = new Stack<int>();
            int[] visisted = new int[graph.Vertices.Length];
            for(int index=0;index<graph.Vertices.Length;index++)
            {
                visisted[index] = 0;
            }

            visisted[0] = 1;
            dfsstack.Push(graph.Vertices[0]);
            Console.WriteLine($"Visted Node: {graph.Vertices[0]}");
            var adjnode = graph.AdjList[0];
            
            while (adjnode!=null)
            {
                if(visisted[adjnode.Vertex]==0)
                {
                    visisted[adjnode.Vertex] = 1;
                    Console.WriteLine($"Visted Node: {adjnode.Vertex}");
                    dfsstack.Push(adjnode.Vertex);
                    adjnode = graph.AdjList[adjnode.Vertex];
                }
                else
                {
                    adjnode = adjnode.Next;

                    if(adjnode == null && dfsstack.Count>0)
                    {
                        var node = dfsstack.Pop();
                        adjnode = graph.AdjList[node];
                    }
                }
            }
        }
    }
}
