using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practices.Coding.Algorithms.Graphs
{
    public class GraphAdjMatrixImplementation
    {
        public GraphAdjMatrix Create(int vertics)
        {
            if (vertics <= 0)
                return null;

            var graph = new GraphAdjMatrix(vertics, 0);
            graph.Vertices = vertics;
            graph.Edges = 0;
            for(int rowvertex=0;rowvertex<vertics;rowvertex++)
            {
                for(int colvertex=0;colvertex<vertics;colvertex++)
                {
                    graph.AdjMatrix[rowvertex,colvertex] = 0;
                }
            }

            return graph;
        }

        public void DisplayGraph(GraphAdjMatrix graph)
        {
            if (graph.Vertices <= 0) 
                return;
            if (graph.Edges <= 0)
                return;

            for (int rowvertex = 0; rowvertex < graph.Vertices; rowvertex++)
            {
                for (int colvertex = 0; colvertex < graph.Vertices; colvertex++)
                {
                    Console.WriteLine(graph.AdjMatrix[rowvertex, colvertex]);
                }
            }
        }

        public void DisplayEdge(GraphAdjMatrix graph)
        {
            if (graph.Vertices <= 0)
                return;
            if (graph.Edges <= 0)
                return;

            for (int rowvertex = 0; rowvertex < graph.Vertices; rowvertex++)
            {
                for (int colvertex = 0; colvertex < graph.Vertices; colvertex++)
                {
                    if(graph.AdjMatrix[rowvertex, colvertex]==1)
                    {
                        Console.WriteLine($"Edge from vertex {rowvertex} to vertex{colvertex}");
                    }
                }
            }
        }

        public void InsertEdge(Edge edge, GraphAdjMatrix graph)
        {
            int sourcevertex = edge.Source;
            int destinationvertex = edge.Destination;

            for (int rowvertex = 0; rowvertex < graph.Vertices; rowvertex++)
            {
                var isedgeadded = false;
                for (int colvertex = 0; colvertex < graph.Vertices; colvertex++)
                {
                    if (graph.AdjMatrix[rowvertex, colvertex] == 0 && rowvertex == edge.Source && colvertex ==edge.Destination)
                    {
                        graph.AdjMatrix[rowvertex, colvertex] = 1;
                        Console.WriteLine($"Edge from vertex {rowvertex} to vertex{colvertex} is added in the graph");
                        isedgeadded = true;
                        break;
                    }
                }

                if (isedgeadded)
                    break;
            }
        }

        public void RemoveEdge(Edge edge, GraphAdjMatrix graph)
        {
            int sourcevertex = edge.Source;
            int destinationvertex = edge.Destination;

            for (int rowvertex = 0; rowvertex < graph.Vertices; rowvertex++)
            {
                var isedgeremoved = false;
                for (int colvertex = 0; colvertex < graph.Vertices; colvertex++)
                {
                    if (graph.AdjMatrix[rowvertex, colvertex] == 1 && rowvertex == edge.Source && colvertex == edge.Destination)
                    {
                        graph.AdjMatrix[rowvertex, colvertex] = 0;
                        Console.WriteLine($"Edge from vertex {rowvertex} to vertex{colvertex} is Removed in the graph");
                        isedgeremoved = true;
                        break;
                    }
                }

                if (isedgeremoved)
                    break;
            }
        }
    }
}
