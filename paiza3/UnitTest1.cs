using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, List<int>> adList;
    static int[] minPath;
    static int t;
    static int p;
    static void Main()
    {
        // 入力を受け取る
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0]; // 頂点の数
        int s = input[1]; // 始点
        t = input[2]; // 終点
        p = input[3]; // p

        // 隣接リストを作成する
        adList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            adList[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        // 最短パスを初期化する
        minPath = Enumerable.Range(1, n + 1).ToArray();

        // 深さ優先探索を実行する
        DFS(s, new List<int> { s });

        // 結果を出力する
        if (minPath.Length == n + 1)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(string.Join(" ", minPath));
        }
    }

    static void DFS(int v, List<int> path)
    {
        if (path.Count < minPath.Length)
        {
            foreach (int i in adList[v])
            {
                if (!path.Contains(i))
                {
                    path.Add(i);
                    if (i == t && path.Contains(p))
                    {
                        minPath = path.ToArray();
                    }
                    else
                    {
                        DFS(i, path);
                    }
                    path.RemoveAt(path.Count - 1);
                }
            }
        }
    }
}