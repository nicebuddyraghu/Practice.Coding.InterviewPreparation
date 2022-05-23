using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Graphs
{
    public class TopologicalSortUsingAdjList
    {
        public void Sort(GraphAdjLinkedList<int> graph)
        {
            Dictionary<int, int> indegreelist = new Dictionary<int, int>();
            Stack<int> nodestack = new Stack<int>();
            int[] visited = new int[graph.Vertices.Length];

            
            for(int index=0;index<graph.Vertices.Length;index++)
            {
                var indegree = GetInDegree(graph, graph.Vertices[index]);
                indegreelist.Add(graph.Vertices[index], indegree);
                if (indegree == 0)
                    nodestack.Push(graph.Vertices[index]);
                visited[index] = 0;
            }
            DFSRecursive dfsRecursive = new DFSRecursive();
            for(int index=0;index<graph.Vertices.Length;index++)
            {
                if(visited[index] ==0)
                {
                    visited[index] = 1;
                    dfsRecursive.Traverse(graph, graph.Vertices[index], visited, nodestack);
                }
            }

            while(nodestack.Count>0)
            {
                var node = nodestack.Pop();
                Console.Write($"=>{node}");
            }
            Console.WriteLine();
        }

        public int GetInDegree(GraphAdjLinkedList<int> graph, int vertex)
        {
            var node= graph.AdjList[graph.Indextable[vertex]];
            int indegree = 0;
            while(node!=null)
            {
                indegree++;
                node = node.Next;
            }
            return indegree;
        }
    }
}
