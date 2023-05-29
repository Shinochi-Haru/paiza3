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
        // ���͂��󂯎��
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0]; // ���_�̐�
        int s = input[1]; // �n�_
        t = input[2]; // �I�_
        p = input[3]; // p

        // �אڃ��X�g���쐬����
        adList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            adList[i] = Console.ReadLine().Split().Select(int.Parse).ToList();
        }

        // �ŒZ�p�X������������
        minPath = Enumerable.Range(1, n + 1).ToArray();

        // �[���D��T�������s����
        DFS(s, new List<int> { s });

        // ���ʂ��o�͂���
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