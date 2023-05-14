using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        // �`���b�g�ɎQ�����������o�[��ێ����郊�X�g
        List<string> membership = new List<string>();
        // �X�[�p�[�`���b�g�̏���ێ����郊�X�g
        List<Tuple<long, string>> superchat = new List<Tuple<long, string>>();
        // �����o�[���Ƃ̎󂯎�������z�̍��v��ێ����鎫��
        Dictionary<string, long> money_sum = new Dictionary<string, long>();

        // ���͂��󂯎��A�������s��
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            string E = input[1];

            if (E == "give")
            {
                // "give"�̏ꍇ�́A�󂯎�������z�����Z����
                long money = long.Parse(input[2]);
                if (money_sum.ContainsKey(name))
                {
                    money_sum[name] += money;
                }
                else
                {
                    money_sum[name] = money;
                }
            }
            else
            {
                // "join"�̏ꍇ�́A�`���b�g�ɎQ�����������o�[�Ƃ��ēo�^����
                membership.Add(name);
            }
        }

        // �X�[�p�[�`���b�g�̏����쐬����
        foreach (var item in money_sum)
        {
            superchat.Add(Tuple.Create(item.Value, item.Key));
        }

        // �X�[�p�[�`���b�g�̏�����ёւ���i���z���������A�����ꍇ�͖��O�̏����j
        superchat.Sort((x, y) =>
        {
            int result = y.Item1.CompareTo(x.Item1);
            if (result == 0)
            {
                result = x.Item2.CompareTo(y.Item2);
            }
            return result;
        });

        // �`���b�g�ɎQ�����������o�[����ёւ���i���O�̏����j
        membership.Sort();

        // �X�[�p�[�`���b�g�̏����o�͂���
        foreach (var item in superchat)
        {
            Console.WriteLine(item.Item2);
        }

        // �`���b�g�ɎQ�����������o�[���o�͂���
        foreach (var item in membership)
        {
            Console.WriteLine(item);
        }
    }
}
