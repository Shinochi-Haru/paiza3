using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        int k = int.Parse(input[2]);

        List<int>[] adjacencyList = new List<int>[n + 1];
        for (int i = 1; i <= n; i++)
        {
            adjacencyList[i] = new List<int>();
        }

        for (int i = 0; i < m; i++)
        {
            string[] edge = Console.ReadLine().Split(' ');
            int u = int.Parse(edge[0]);
            int v = int.Parse(edge[1]);
            adjacencyList[u].Add(v);
            adjacencyList[v].Add(u);
        }

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Node {i}: ");
            foreach (int neighbor in adjacencyList[i])
            {
                Console.Write($"{neighbor} ");
            }
            Console.WriteLine();
        }
    }
}
