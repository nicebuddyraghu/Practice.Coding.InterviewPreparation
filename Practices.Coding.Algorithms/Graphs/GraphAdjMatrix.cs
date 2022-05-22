using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Graphs
{
    public class Edge
    {
        public Edge(int source, int destination)
        {
            this.Source = source;
            this.Destination = destination;
        }
        public int Source { get; set; }
        public int Destination { get; set; }
    }

    public class GraphAdjMatrix
    {
        public GraphAdjMatrix(int vertices, int edges)
        {
            this.Vertices = vertices;
            this.Edges = edges;
            this.AdjMatrix = new int[vertices,vertices];
        }
        public int Vertices { get; set; }
        public int Edges { get; set; }
        public int[,] AdjMatrix { get; set; }
    }
}
