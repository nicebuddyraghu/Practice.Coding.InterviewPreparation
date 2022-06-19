using System.Collections.Generic;

namespace Practices.Coding.LeetCode.Difficulty.Medium
{
    public class CloneGraph
    {
        
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}

        public class Solution
        {
            Dictionary<int, Node> visited = new Dictionary<int, Node>();
            public Node CloneGraph(Node node)
            {
                if (node == null) return null;

                var clonenode = new Node(node.val);
                if (!visited.ContainsKey(node.val))
                {
                    visited.Add(clonenode.val, clonenode);
                }

                foreach (var neighbour in node.neighbors)
                {
                    if (!visited.ContainsKey(neighbour.val))
                        clonenode.neighbors.Add(CloneGraph(neighbour));
                    else
                        clonenode.neighbors.Add(visited[neighbour.val]);
                }

                return clonenode;
            }
        }
    }
}
