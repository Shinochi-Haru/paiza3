using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, List<int>> adjList;
    static List<Tuple<int, int>> tree;

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // 頂点数
        int k = int.Parse(Console.ReadLine()); // 削除する頂点数
        HashSet<int> S = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // 削除する頂点の集合
        adjList = new Dictionary<int, List<int>>();
        tree = new List<Tuple<int, int>>();

        // 隣接リストを作成
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine()); // 隣接する頂点の数
            adjList[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // 隣接する頂点の番号をリストとして保存
        }

        // 削除する辺を処理
        foreach (int i in S)
        {
            foreach (int j in adjList[i])
            {
                adjList[j].Remove(i); // 隣接する頂点から削除する頂点を削除
            }
            adjList[i].Clear(); // 削除する頂点を隣接リストから削除
        }

        HashSet<int> vertices = new HashSet<int>(Enumerable.Range(1, n).Where(x => !S.Contains(x))); // 削除されていない頂点の集合

        // 開始頂点を削除されていない頂点の中で最小のものとしてDFSを実行し、全域木を構築する
        DFS(vertices.Min(), new List<int>() { vertices.Min() });

        // 全域木の辺の数が n - k - 1 ならば全域木を出力、それ以外は -1 を出力
        if (tree.Count == n - k - 1)
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
