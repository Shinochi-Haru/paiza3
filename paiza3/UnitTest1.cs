using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<int>> ad_list = new Dictionary<int, List<int>>();
    static List<List<int>> trails = new List<List<int>>();
    static int s = 0;
    static int t = 0;

    static void Main(string[] args)
    {
        // 入力を読み込む
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // 頂点の数
        s = int.Parse(input[1]); // 開始頂点
        t = int.Parse(input[2]); // 目標頂点

        // 隣接リストを構築する
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine()); // 頂点の値
            ad_list[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // 隣接する頂点のリスト
        }

        // DFSを実行してトレイルを生成する
        DFS(s, new List<int> { s }, new List<List<int>>());

        // トレイルの数とトレイルの内容を出力する
        Console.WriteLine(trails.Count);
        foreach (var trail in trails)
        {
            Console.WriteLine(string.Join(" ", trail));
        }
    }

    static void DFS(int v, List<int> trail, List<List<int>> edges)
    {
        foreach (int i in ad_list[v])
        {
            List<int> e = new List<int>(new int[] { i, v });
            e.Sort(); // 辺をソートして重複を防ぐ
            if (!ContainsList(edges, e)) // 既に追加されていない辺の場合のみ探索を続ける
            {
                trail.Add(i); // トレイルに頂点を追加
                if (i != s)
                {
                    edges.Add(e); // 辺を追加
                    if (i == t)
                    {
                        trails.Add(new List<int>(trail)); // 目標頂点に到達したらトレイルを追加
                    }
                    else
                    {
                        DFS(i, trail, edges); // 再帰的に探索を続ける
                    }
                    edges.RemoveAt(edges.Count - 1); // 探索が終わったら辺を削除
                }
                trail.RemoveAt(trail.Count - 1); // 探索が終わったら頂点を削除
            }
        }
    }

    static bool ContainsList(List<List<int>> list1, List<int> list2)
    {
        // リストの比較を行うヘルパーメソッド
        foreach (var item in list1)
        {
            if (item.Count == list2.Count)
            {
                bool equal = true;
                for (int i = 0; i < item.Count; i++)
                {
                    if (item[i] != list2[i])
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
