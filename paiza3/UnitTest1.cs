using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<int>> adjacencyList; // �אڃ��X�g
    static List<int> maxTrail; // �Œ��o�H

    static void Main(string[] args)
    {
        // ���͂��󂯎��A�ϐ��Ɋi�[
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // �m�[�h��
        int s = int.Parse(input[1]); // �n�_
        int t = int.Parse(input[2]); // �I�_

        // �אڃ��X�g�̍쐬
        adjacencyList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            int[] neighbors = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            adjacencyList[i] = new List<int>(neighbors);
        }

        // �Œ��o�H���i�[���郊�X�g�̏�����
        maxTrail = new List<int>();

        // �[���D��T���̎��s
        DFS(s, new List<int> { s }, new List<Tuple<int, int>>(), t);

        // ���ʂ��o��
        Console.WriteLine(string.Join(" ", maxTrail));
    }

    // �[���D��T���̊֐�
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
