using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, List<int>> adjList;
    static List<Tuple<int, int>> tree;

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine()); // ���_��
        int k = int.Parse(Console.ReadLine()); // �폜���钸�_��
        HashSet<int> S = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // �폜���钸�_�̏W��
        adjList = new Dictionary<int, List<int>>();
        tree = new List<Tuple<int, int>>();

        // �אڃ��X�g���쐬
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine()); // �אڂ��钸�_�̐�
            adjList[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // �אڂ��钸�_�̔ԍ������X�g�Ƃ��ĕۑ�
        }

        // �폜����ӂ�����
        foreach (int i in S)
        {
            foreach (int j in adjList[i])
            {
                adjList[j].Remove(i); // �אڂ��钸�_����폜���钸�_���폜
            }
            adjList[i].Clear(); // �폜���钸�_��אڃ��X�g����폜
        }

        HashSet<int> vertices = new HashSet<int>(Enumerable.Range(1, n).Where(x => !S.Contains(x))); // �폜����Ă��Ȃ����_�̏W��

        // �J�n���_���폜����Ă��Ȃ����_�̒��ōŏ��̂��̂Ƃ���DFS�����s���A�S��؂��\�z����
        DFS(vertices.Min(), new List<int>() { vertices.Min() });

        // �S��؂̕ӂ̐��� n - k - 1 �Ȃ�ΑS��؂��o�́A����ȊO�� -1 ���o��
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

    // �[���D��T���iDFS�j��p���đS��؂��\�z����
    public static void DFS(int v, List<int> visited)
    {
        foreach (int i in adjList[v])
        {
            if (!visited.Contains(i))
            {
                visited.Add(i); // ���_i��K�ꂽ���Ƃ��L�^
                tree.Add(new Tuple<int, int>(v, i)); // ���_v���璸�_i�ւ̕ӂ�S��؂ɒǉ�
                DFS(i, visited); // ���_i����ċA�I��DFS�����s
            }
        }
    }
}
