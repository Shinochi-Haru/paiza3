using System;
using System.Collections.Generic;

public class Program
{
    static Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
    static List<List<int>> paths = new List<List<int>>();
    static int n, s, t, k;
    static HashSet<int> S = new HashSet<int>();
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        n = int.Parse(input[0]);
        s = int.Parse(input[1]);
        t = int.Parse(input[2]);
        k = int.Parse(Console.ReadLine());

        S = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));

        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            adjacencyList[i] = new List<int>();

            string[] vertices = Console.ReadLine().Split();
            foreach (string vertex in vertices)
            {
                int neighbor = int.Parse(vertex);
                adjacencyList[i].Add(neighbor);
            }
        }

        foreach (int i in S)
        {
            foreach (int j in adjacencyList[i])
            {
                adjacencyList[j].Remove(i);
            }
            adjacencyList[i].Clear();
        }

        DFS(s, new List<int> { s });

        Console.WriteLine(paths.Count);
        foreach (List<int> path in paths)
        {
            Console.WriteLine(string.Join(" ", path));
        }
    }

    static void DFS(int v, List<int> path)
    {
        foreach (int neighbor in adjacencyList[v])
        {
            if (!path.Contains(neighbor))
            {
                path.Add(neighbor);

                if (neighbor == t)
                {
                    paths.Add(new List<int>(path));
                }
                else
                {
                    DFS(neighbor, path);
                }

                path.RemoveAt(path.Count - 1);
            }
        }
    }
}