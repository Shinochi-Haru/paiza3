using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, List<int>> adjacencyList; // 隣接リスト
    static List<int> maxTrail; // 最長経路
    static int s; // 始点
    static int t; // 終点

    static void Main(string[] args)
    {
        // 入力を受け取り、変数に格納
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // ノード数
        s = int.Parse(input[1]); // 始点
        t = int.Parse(input[2]); // 終点

        // 隣接リストの作成
        adjacencyList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            int[] neighbors = Console.ReadLine().Split().Select(int.Parse).ToArray();
            adjacencyList[i] = new List<int>(neighbors);
        }

        // 最長経路を格納するリストの初期化
        maxTrail = new List<int>();

        // 深さ優先探索の実行
        DFS(s, new List<int> { s }, new List<List<int>>());

        // 結果を出力
        Console.WriteLine(string.Join(" ", maxTrail));
    }

    // 深さ優先探索の関数
    static void DFS(int v, List<int> trail, List<List<int>> edges)
    {
        foreach (int i in adjacencyList[v])
        {
            List<int> e = new List<int>() { Math.Min(i, v), Math.Max(i, v) };

            if (!ContainsEdge(edges, e))
            {
                trail.Add(i);
                edges.Add(e);

                if (i == t && trail.Count > maxTrail.Count)
                {
                    maxTrail = new List<int>(trail);
                }

                DFS(i, trail, edges);

                edges.Remove(e);
                trail.RemoveAt(trail.Count - 1);
            }
        }
    }

    // 辺のリストに指定された辺が含まれているかを判定する関数
    static bool ContainsEdge(List<List<int>> edges, List<int> e)
    {
        foreach (List<int> edge in edges)
        {
            if (edge[0] == e[0] && edge[1] == e[1])
            {
                return true;
            }
        }

        return false;
    }
}
