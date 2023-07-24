using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<int>> adjList; // �אڃ��X�g��ێ����鎫��
    static List<Tuple<int, int>> tree; // �S��؂̕ӂ�ێ����郊�X�g

    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        adjList = new Dictionary<int, List<int>>();
        tree = new List<Tuple<int, int>>();

        // �אڃ��X�g���쐬
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine()); // �אڂ��钸�_�̐�
            adjList[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // �אڂ��钸�_�̔ԍ������X�g�Ƃ��ĕۑ�
        }

        // �J�n���_��1�Ƃ���DFS�����s���A�S��؂��\�z����
        DFS(1, new List<int>() { 1 });

        // �S��؂̕ӂ��o��
        foreach (var edge in tree)
        {
            Console.WriteLine($"{edge.Item1} {edge.Item2}");
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
