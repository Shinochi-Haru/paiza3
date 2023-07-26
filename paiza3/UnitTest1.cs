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

        // �J�n���_���e���_�Ƃ���DFS�����s���A�S��؂̕ӂ��\�z����
        for (int i = 1; i <= n; i++)
        {
            DFS(i, new List<int>() { i });
        }

        // �ӂ�������Ȃ��ꍇ�� -1 ���o��
        Console.WriteLine("-1");
    }

    // �[���D��T���iDFS�j��p���đS��؂̕ӂ��\�z����
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
