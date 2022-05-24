using System;

namespace Practices.Coding.Algorithms.Heap
{
    public class DijkstraAlgorithm
    {
        public void Dijkstra(Graphs.GraphAdjLinkedList<GraphVertex<int>> graph, int startnode)
        {
            int[] distance = new int[graph.Vertices.Length];
            for(int index=0;index<graph.Vertices.Length;index++)
            {
                distance[index] = -1;
            }

            MinHeapPq<int> queue = new MinHeapPq<int>();
            queue.Insert(0, startnode);
            distance[0] = 0;

            while (queue.Count>0)
            {
                var vertex = queue.RemoveMin();
                Console.WriteLine($"Node is popped={vertex.Node}:weight={vertex.Weight}");
                var adjnode = graph.AdjList[graph.Indextable[vertex]];
                while(adjnode!=null)
                {
                    if(distance[graph.Indextable[adjnode.Vertex]]==-1)
                    {
                        distance[graph.Indextable[adjnode.Vertex]] = adjnode.Vertex.Weight;
                        queue.Insert(adjnode.Vertex.Weight, adjnode.Vertex.Node);
                    }
                    else
                    {
                        if (distance[graph.Indextable[adjnode.Vertex]] > (vertex.Weight + adjnode.Vertex.Weight))
                        {
                            distance[graph.Indextable[adjnode.Vertex]] = (vertex.Weight + adjnode.Vertex.Weight);
                            queue.ChangePriority(distance[graph.Indextable[adjnode.Vertex]], adjnode.Vertex);
                        }
                    }
                    adjnode = adjnode.Next;
                }
            }


        }
    }
}
