using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataStructure
{
    class Graph
    {
        // Dictionary to store adjacency list
        private readonly Dictionary<int, List<int>> adj = new Dictionary<int, List<int>>();

        // Add an edge between u and v (undirected)
        public void AddEdge(int u, int v)
        {
            // Add u if not exists
            if (!adj.ContainsKey(u))
                adj[u] = new List<int>();

            // Add v if not exists
            if (!adj.ContainsKey(v))
                adj[v] = new List<int>();

            // Add edge u <-> v
            adj[u].Add(v);
            adj[v].Add(u);
        }

        // Print adjacency list
        public void PrintGraph()
        {
            foreach (var vertex in adj.Keys)
            {
                Console.Write(vertex + ": ");
                Console.WriteLine(string.Join(", ", adj[vertex]));
            }
        }
    }
}
