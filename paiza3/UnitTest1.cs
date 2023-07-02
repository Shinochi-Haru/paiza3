using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<int>> ad_list = new Dictionary<int, List<int>>();
    static List<List<int>> trails = new List<List<int>>();
    static int t = 0;

    static void Main(string[] args)
    {
        // ���͂�ǂݍ���
        string[] input1 = Console.ReadLine().Split();
        int n = int.Parse(input1[0]); // ���_�̐�
        int s = int.Parse(input1[1]); // �J�n���_
        t = int.Parse(input1[2]); // �ڕW���_

        int k = int.Parse(Console.ReadLine()); // �폜���钸�_�̐�
        HashSet<int> S = new HashSet<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // �폜���钸�_�̏W��

        // �אڃ��X�g���\�z����
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine()); // ���_�̒l
            ad_list[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(), int.Parse)); // �אڂ��钸�_�̃��X�g
        }

        // ���_�̍폜
        foreach (int i in S)
        {
            foreach (int j in ad_list[i])
            {
                ad_list[j].Remove(i); // i�ɗאڂ��钸�_����i���폜
            }
            ad_list[i].Clear(); // i���̂��폜
        }

        // DFS�����s���ăg���C���𐶐�����
        DFS(s, new List<int> { s }, new List<List<int>>());

        // �ڕW���_�ɓ��B����g���C���̐��ƃg���C���̓��e���o�͂���
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
                edges.Add(e); // �ӂ�ǉ�
                if (i == t)
                {
                    trails.Add(new List<int>(trail)); // �ڕW���_�ɓ��B�����ꍇ�A�g���C����ǉ�
                }
                DFS(i, trail, edges); // �ċA�I�ɒT���𑱂���
                edges.RemoveAt(edges.Count - 1); // �T�����I�������ӂ��폜
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
