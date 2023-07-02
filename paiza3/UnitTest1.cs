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
        // ���͂�ǂݍ���
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // ���_�̐�
        s = int.Parse(input[1]); // �J�n���_
        t = int.Parse(input[2]); // �ڕW���_

        // �אڃ��X�g���\�z����
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine()); // ���_�̒l
            ad_list[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // �אڂ��钸�_�̃��X�g
        }

        // DFS�����s���ăg���C���𐶐�����
        DFS(s, new List<int> { s }, new List<List<int>>());

        // �g���C���̐��ƃg���C���̓��e���o�͂���
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
            e.Sort(); // �ӂ��\�[�g���ďd����h��
            if (!ContainsList(edges, e)) // ���ɒǉ�����Ă��Ȃ��ӂ̏ꍇ�̂ݒT���𑱂���
            {
                trail.Add(i); // �g���C���ɒ��_��ǉ�
                if (i != s)
                {
                    edges.Add(e); // �ӂ�ǉ�
                    if (i == t)
                    {
                        trails.Add(new List<int>(trail)); // �ڕW���_�ɓ��B������g���C����ǉ�
                    }
                    else
                    {
                        DFS(i, trail, edges); // �ċA�I�ɒT���𑱂���
                    }
                    edges.RemoveAt(edges.Count - 1); // �T�����I�������ӂ��폜
                }
                trail.RemoveAt(trail.Count - 1); // �T�����I������璸�_���폜
            }
        }
    }

    static bool ContainsList(List<List<int>> list1, List<int> list2)
    {
        // ���X�g�̔�r���s���w���p�[���\�b�h
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
