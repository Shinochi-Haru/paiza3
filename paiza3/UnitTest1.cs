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

        // 隣接リストを作成
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine()); // 隣接する頂点の数
            adjList[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // 隣接する頂点の番号をリストとして保存
        }

        int k = int.Parse(Console.ReadLine()); // 削除する辺の数

        // 辺を削除
        for (int i = 0; i < k; i++)
        {
            int e, d;
            string[] input = Console.ReadLine().Split();
            e = int.Parse(input[0]);
            d = int.Parse(input[1]);
            adjList[e].Remove(d);
            adjList[d].Remove(e);
        }

        // 開始頂点を1としてDFSを実行し、全域木を構築する
        DFS(1, new List<int>() { 1 });

        // 枝の数が n - 1 ならば全域木を出力、それ以外は -1 を出力
        if (tree.Count == n - 1)
        {
            foreach (var edge in tree)
            {
                Console.WriteLine($"{edge.Item1} {edge.Item2}");
            }
        }
        else
        {
            Console.WriteLine("-1");
        }
    }

    // 深さ優先探索（DFS）を用いて全域木を構築する
    public static void DFS(int v, List<int> visited)
    {
        foreach (int i in adjList[v])
        {
            if (!visited.Contains(i))
            {
                visited.Add(i); // 頂点iを訪れたことを記録
                tree.Add(new Tuple<int, int>(v, i)); // 頂点vから頂点iへの辺を全域木に追加
                DFS(i, visited); // 頂点iから再帰的にDFSを実行
            }
        }
    }
}
