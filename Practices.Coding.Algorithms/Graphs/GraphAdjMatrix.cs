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


    public class GraphAdjMatrix<T>
    {
        System.Collections.Generic.Dictionary<T, int> indextable = new System.Collections.Generic.Dictionary<T, int>();
        public GraphAdjMatrix(T[] vertices, Edge<T>[] edges)
        {
            this.Vertices = vertices;
            this.Edges = edges;
            this.AdjMatrix = new int[vertices.Length, vertices.Length];

            for(int index=0;index<vertices.Length;index++)
            {
                indextable.Add(vertices[index], index);
            }

            for(int rowindex =0; rowindex<vertices.Length;rowindex++)
            {
                for(int colindex=0;colindex<vertices.Length;colindex++)
                {
                    AdjMatrix[rowindex, colindex] = 0;
                }
            }

            for(int edgeindex=0;edgeindex<edges.Length; edgeindex++)
            {
                T from = edges[edgeindex].Source;
                T to = edges[edgeindex].Destination;

                int varfromindex = indextable[from];
                int vartoindex = indextable[to];

                AdjMatrix[varfromindex, vartoindex] = 1;
            }
        }

        public System.Collections.Generic.Dictionary<T, int> IndexTable => indextable;
        public T[] Vertices { get; set; }
        public Edge<T>[] Edges { get; set; }
        public int[,] AdjMatrix { get; set; }
    }
}
