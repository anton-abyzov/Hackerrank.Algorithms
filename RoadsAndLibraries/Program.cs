using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    private static Graph _graph;
    private static long _libraryCost;
    private static long _roadCost;
    private static int _n;

    static void Main(String[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < q; a0++)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            _n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            _libraryCost = Convert.ToInt64(tokens_n[2]);
            _roadCost = Convert.ToInt64(tokens_n[3]);
            _graph = new Graph();
            for (int i = 0; i < _n; i++)
            {
                _graph.Nodes.Add(new Graph.Node());
            }
            for (int a1 = 0; a1 < m; a1++)
            {
                string[] tokens_city_1 = Console.ReadLine().Split(' ');
                int city_1 = Convert.ToInt32(tokens_city_1[0]);
                int city_2 = Convert.ToInt32(tokens_city_1[1]);
                _graph.Nodes[city_1-1].Adjacents.Add(_graph.Nodes[city_2-1]);
                _graph.Nodes[city_2-1].Adjacents.Add(_graph.Nodes[city_1-1]);
            }
            var result = Solve();
            Console.WriteLine(result);
        }
        
    }

    private static long Solve()
    {
        if (_roadCost > _libraryCost)
            return _n * _libraryCost;

        HashSet<int> visited = new HashSet<int>();
        var queue = new Queue<Graph.Node>();
        
        long result = 0;

        for (var i = 0; i < _n; i++)
        {
            var connectedCitiesCount = 0;
            if (visited.Contains(_graph.Nodes.IndexOf(_graph.Nodes[i]))) continue;
            queue.Enqueue(_graph.Nodes[i]);

            while (queue.Any())
            {
                var currentCity = queue.Dequeue();
                if (visited.Contains(_graph.Nodes.IndexOf(currentCity)))
                    continue;
                connectedCitiesCount++;
                visited.Add(_graph.Nodes.IndexOf(currentCity));
                foreach (var road in currentCity.Adjacents)
                {
                    if (!visited.Contains(_graph.Nodes.IndexOf(road)))
                        queue.Enqueue(road);
                }
            }
            result += _libraryCost + (connectedCitiesCount - 1) * _roadCost;
        }
        return result;
    }
}


public class Graph : ICloneable
{
    public Graph()
    {
        Nodes = new List<Node>();
    }
    public class Node : ICloneable
    {
        public Node()
        {
            Adjacents = new List<Node>();
            
        }
        public List<Node> Adjacents { get; set; }

        public bool HasLibrary { get; set; }

        object ICloneable.Clone()
        {
            return new Node()
            {
                Adjacents = new List<Node>(Adjacents),
            };
        }
    }

    public List<Node> Nodes { get; set; }

    public object Clone()
    {
        return new Graph()
        {
            Nodes = new List<Node>(Nodes)
        };
    }
}


