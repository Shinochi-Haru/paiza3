using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<int>> adjacencyList; // 隣接リスト
    static List<int> maxTrail; // 最長経路

    static void Main(string[] args)
    {
        // 入力を受け取り、変数に格納
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // ノード数
        int s = int.Parse(input[1]); // 始点
        int t = int.Parse(input[2]); // 終点

        // 隣接リストの作成
        adjacencyList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            int[] neighbors = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            adjacencyList[i] = new List<int>(neighbors);
        }

        // 最長経路を格納するリストの初期化
        maxTrail = new List<int>();

        // 深さ優先探索の実行
        DFS(s, new List<int> { s }, new List<Tuple<int, int>>(), t);

        // 結果を出力
        Console.WriteLine(string.Join(" ", maxTrail));
    }

    // 深さ優先探索の関数
    static void DFS(int v, List<int> trail, List<Tuple<int, int>> edges, int t)
    {
        foreach (int i in adjacencyList[v])
        {
            Tuple<int, int> e = Tuple.Create(Math.Min(i, v), Math.Max(i, v));

            if (!edges.Contains(e))
            {
                trail.Add(i);

                if (i != trail[0])
                {
                    edges.Add(e);

                    if (i == t && trail.Count > maxTrail.Count)
                    {
                        maxTrail = new List<int>(trail);
                    }
                    else
                    {
                        DFS(i, trail, edges, t);
                    }

                    edges.Remove(e);
                }

                trail.RemoveAt(trail.Count - 1);
            }
        }
    }
}
