using System;
using System.Collections.Generic;

namespace Practices.Coding.Algorithms.Graphs
{
    public class Edge<T>
    {
        public Edge(T source, T destination)
        {
            this.Source = source;
            this.Destination = destination;
        }
        public T Source { get; set; }
        public T Destination { get; set; }
    }

    public class ListNode<T>
    {
        public ListNode(T vertex, ListNode<T> edgenode)
        {
            this.Vertex = vertex;
            this.Next = edgenode;
        }
        public T Vertex { get; set; }
        public ListNode<T> Next { get; set; }
    }

    public class GraphAdjLinkedList<T>
    {
        Dictionary<T,int> vertextable = new Dictionary<T,int>();
        public GraphAdjLinkedList(T[] vertices, Edge<T>[] edges, bool isDirectGraph=true)
        {
            this.Vertices = vertices;
            this.Edges = edges;

            if (vertices.Length == 0) return;
            for(int index=0;index<vertices.Length;index++)
            {
                vertextable.Add(vertices[index],index);
            }
            AdjList = new ListNode<T>[vertices.Length];

            foreach(var edge in edges)
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
        public ListNode<T>[] AdjList { get; set; }


        public void InsertEdge(Edge<T> edge)
        {
            T from = edge.Source;
            T to = edge.Destination;

            int vertexindex = vertextable[from];
            var node = AdjList[vertexindex];

            if(node==null)
            {
                AdjList[vertexindex]= new ListNode<T>(to, null);
                return;
            }

            ListNode<T> previousnode = null;
            while(node!=null)
            {
                if(node.Vertex.ToString() == to.ToString())
                {
                    Console.WriteLine("Edge is already available in the graph!");
                    return;
                }
                else
                {
                    previousnode = node;
                    node = node.Next;
                }
            }

            previousnode.Next = new ListNode<T>(to, null);
        }

        public void RemoveEdge(Edge<T> edge)
        {
            T from = edge.Source;
            T to = edge.Destination;

            int vertexindex = vertextable[from];
            var node = AdjList[vertexindex];

            if (node == null)
            {
                Console.WriteLine($"There is no Edge from {from.ToString()} to {to.ToString()} in the given Graph");
                return;
            }

            ListNode<T> previousnode = null;
            while(node!=null)
            {
                if(node.Vertex.ToString()==to.ToString())
                {
                    if (previousnode == null)
                        node = null;
                    else
                        previousnode.Next = node.Next;
                }
                node = node.Next;
            }
        }

        public void PrintGraph(GraphAdjLinkedList<T> graph)
        {
            Console.WriteLine($"Total No of Vertices:{graph.Vertices.Length}");
            
            foreach(var vertex in graph.Vertices)
            {
                Console.Write($"Vertex=> {vertex}");
            }
            Console.WriteLine();

            Console.WriteLine($"Total No of Edges:{graph.Edges.Length}");
            foreach (var edge in graph.Edges)
            {
                Console.WriteLine($"Edge from {edge.Source} to {edge.Destination}");
            }

            for(int index=0;index<graph.Vertices.Length;index++)
            {
                foreach(var row in vertextable)
                {
                    if(row.Value == index)
                    {
                        Console.WriteLine($"Adjcent vertices of Vertex{row.Key} are");
                    }
                }
                var node = AdjList[index];
                while(node!=null)
                {
                    Console.Write($"=>{node.Vertex}");
                    node = node.Next;
                }
                Console.WriteLine();
            }
        }

    }

   
}
