using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Graphs
{

    public class GraphAdjList<T>
    {
        Dictionary<T, int> vertextable = new Dictionary<T, int>();
        public GraphAdjList(T[] vertices, Edge<T>[] edges, bool isDirectGraph = true)
        {
            this.Vertices = vertices;
            this.Edges = edges;

            if (vertices.Length == 0) return;
            AdjList = new List<List<T>>();
            for (int index = 0; index < vertices.Length; index++)
            {
                vertextable.Add(vertices[index], index);
                AdjList.Add(new List<T>());
            }

            foreach (var edge in edges)
            {
                if (!isDirectGraph)
                {
                    InsertEdge(edge);
                    InsertEdge(new Edge<T>(edge.Destination, edge.Source));
                }
                else
                {
                    InsertEdge(edge);
                }
            }
        }
        public T[] Vertices { get; set; }
        public Edge<T>[] Edges { get; set; }
        public List<List<T>> AdjList { get; set; }


        public void InsertEdge(Edge<T> edge)
        {
            T from = edge.Source;
            T to = edge.Destination;

            int vertexindex = vertextable[from];

            var node = AdjList[vertexindex];

            for (int index = 0; index < node.Count; index++)
            {
                if (node[index].ToString() == to.ToString())
                {
                    Console.Write($"Edge from {edge.Source} to {edge.Destination} is already available in the Graph");
                    return;
                }
            }

            node.Add(to);
        }

        public void RemoveEdge(Edge<T> edge)
        {
            T from = edge.Source;
            T to = edge.Destination;

            int vertexindex = vertextable[from];
            var node = AdjList[vertexindex];

            if (node.Count == 0)
            {
                Console.WriteLine($"There is no Edge from {from.ToString()} to {to.ToString()} in the given Graph");
                return;
            }

            node.Remove(to);
        }

        public void PrintGraph(GraphAdjLinkedList<T> graph)
        {
            Console.WriteLine($"Total No of Vertices:{graph.Vertices.Length}");

            foreach (var vertex in graph.Vertices)
            {
                Console.Write($"Vertex=> {vertex}");
            }
            Console.WriteLine();

            Console.WriteLine($"Total No of Edges:{graph.Edges.Length}");
            foreach (var edge in graph.Edges)
            {
                Console.WriteLine($"Edge from {edge.Source} to {edge.Destination}");
            }

            for (int index = 0; index < graph.Vertices.Length; index++)
            {
                foreach (var row in vertextable)
                {
                    if (row.Value == index)
                    {
                        Console.WriteLine($"Adjcent vertices of Vertex{row.Key} are");
                    }
                }
                var node = AdjList[index];
                for (int newindex = 0; newindex < node.Count; newindex++)
                {
                    Console.Write($"=>{node[newindex]}");
                }
                Console.WriteLine();
            }
        }

    }
}
