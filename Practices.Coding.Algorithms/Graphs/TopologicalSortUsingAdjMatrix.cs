using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.Graphs
{
    public class TopologicalSortUsingAdjMatrix
    {
        public void TopoloicalSort(GraphAdjMatrix<int> graph)
        {
            Dictionary<int, int> indegreelist = new Dictionary<int, int>();
            Queue<int> vertexqueue = new Queue<int>();
            for(int index=0; index<graph.Vertices.Length;index++)
            {
                var indegree = GetInDegree(graph, graph.Vertices[index]);
                indegreelist.Add(graph.Vertices[index], indegree);

                if(indegree==0)
                {
                    vertexqueue.Enqueue(graph.Vertices[index]);
                }
            }
            Console.WriteLine($"=>Here is the topological order for the graph");
            while (vertexqueue.Count>0)
            {
                var vertex = vertexqueue.Dequeue();
                Console.WriteLine($"=>{vertex}");
                var vertexindex = graph.IndexTable[vertex];
                for(int toindex=0;toindex<graph.Vertices.Length;toindex++)
                {
                    if(graph.AdjMatrix[vertexindex,toindex] ==1)
                    {
                        graph.AdjMatrix[vertexindex, toindex] = 0;
                        indegreelist[graph.Vertices[toindex]] -= 1;
                        if(indegreelist[graph.Vertices[toindex]] ==0)
                        {
                            vertexqueue.Enqueue(graph.Vertices[toindex]);
                        }
                    }
                }
            }
        }
        
        public int GetInDegree(GraphAdjMatrix<int> graph, int node)
        {
            int indegree = 0;
            int nodeindex = graph.IndexTable[node];
            for(int fromnodeindex=0;fromnodeindex<graph.Vertices.Length;fromnodeindex++)
            {
                if (graph.AdjMatrix[fromnodeindex, nodeindex] == 1)
                    indegree++;
            }
            return indegree;
        }
    }
}
