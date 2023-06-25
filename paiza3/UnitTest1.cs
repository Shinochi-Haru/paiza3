using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, List<int>> adjacencyList; // �אڃ��X�g
    static List<int> maxTrail; // �Œ��o�H
    static int s; // �n�_
    static int t; // �I�_
    static int p; // ����̒l

    static void Main(string[] args)
    {
        // ���͂��󂯎��A�ϐ��Ɋi�[
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // �m�[�h��
        s = int.Parse(input[1]); // �n�_
        t = int.Parse(input[2]); // �I�_
        p = int.Parse(input[3]); // ����̒l

        // �אڃ��X�g�̍쐬
        adjacencyList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            int[] neighbors = Console.ReadLine().Split().Select(int.Parse).ToArray();
            adjacencyList[i] = new List<int>(neighbors);
        }

        // �Œ��o�H���i�[���郊�X�g�̏�����
        maxTrail = new List<int>();

        // �[���D��T���̎��s
        DFS(s, new List<int> { s }, new List<List<int>>());

        // ���ʂ��o��
        if (maxTrail.Count == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(string.Join(" ", maxTrail));
        }
    }

    // �[���D��T���̊֐�
    static void DFS(int v, List<int> trail, List<List<int>> edges)
    {
        foreach (int i in adjacencyList[v])
        {
            List<int> e = new List<int>() { Math.Min(i, v), Math.Max(i, v) };

            if (!ContainsEdge(edges, e))
            {
                trail.Add(i);
                edges.Add(e);

                if (i == t && CountValue(maxTrail, p) < CountValue(trail, p))
                {
                    maxTrail = new List<int>(trail);
                }

                DFS(i, trail, edges);

                edges.Remove(e);
                trail.RemoveAt(trail.Count - 1);
            }
        }
    }

    // �ӂ̃��X�g�Ɏw�肳�ꂽ�ӂ��܂܂�Ă��邩�𔻒肷��֐�
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

    // ���X�g���̓���̒l�̐��𐔂���֐�
    static int CountValue(List<int> list, int value)
    {
        int count = 0;
        foreach (int num in list)
        {
            if (num == value)
            {
                count++;
            }
        }
        return count;
    }
}
