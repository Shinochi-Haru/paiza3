using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<int>> adjList;
    static List<Tuple<int, int>> tree;

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        adjList = new Dictionary<int, List<int>>();
        tree = new List<Tuple<int, int>>();

        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            adjList[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse));
        }

        // 開始頂点を各頂点としてDFSを実行し、全域木の辺を構築する
        for (int i = 1; i <= n; i++)
        {
            DFS(i, new List<int>() { i });
        }

        // 辺が見つからない場合は -1 を出力
        Console.WriteLine("-1");
    }

    // 深さ優先探索（DFS）を用いて全域木の辺を構築する
    public static void DFS(int v, List<int> visited)
    {
        if (visited.Count == adjList.Count)
        {
            for (int i = 0; i < adjList.Count - 1; i++)
            {
                Console.WriteLine($"{visited[i]} {visited[i + 1]}");
            }
            Environment.Exit(0);
        }
        else
        {
            foreach (int i in adjList[v])
            {
                if (!visited.Contains(i))
                {
                    visited.Add(i);
                    DFS(i, visited);
                    visited.Remove(i);
                }
            }
        }
    }
}
