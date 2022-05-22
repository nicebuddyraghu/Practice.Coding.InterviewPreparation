namespace Practices.Coding.Algorithms.Graphs
{
    public class BFSIterative
    {
        public void Traverse(GraphAdjLinkedList<int> graph, int start)
        {
            int[] visited = new int[graph.Vertices.Length];
            for(int index=0; index<graph.Vertices.Length;index++)
            {
                visited[index] = 0;
            }

            System.Collections.Generic.Queue<int> nodequeue = new System.Collections.Generic.Queue<int>();
            visited[start] = 1;
            System.Console.WriteLine($"BFS Traversal: Visited Node:{start}");
            nodequeue.Enqueue(start);

            while(nodequeue.Count>0)
            {
                var node = nodequeue.Dequeue();
                var adjnode = graph.AdjList[node];
                while(adjnode!=null)
               {
                    if(visited[adjnode.Vertex]==0)
                    {
                        visited[adjnode.Vertex] =1;
                        System.Console.WriteLine($"BFS Traversal: Visited Node:{adjnode.Vertex}");
                        nodequeue.Enqueue(adjnode.Vertex);
                    }
                    adjnode = adjnode.Next;
                }
            }

        }
    }
}
