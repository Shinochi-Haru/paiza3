using System;

class Program
{
    static void Main()
    {
        // ���͂��󂯎��An��s�ɒl�����蓖�Ă�
        string[] input1 = Console.ReadLine().Split();
        int n = int.Parse(input1[0]);
        int s = int.Parse(input1[1]);

        // n��̃��[�v�ŏ������s��
        for (int i = 0; i < n; i++)
        {
            // v���󂯎��Aa�ɔz��Ƃ��Ċi�[����
            int v = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // s��i+1���������ꍇ�A�ő�l���o�͂��ă��[�v���I������
            if (s == i + 1)
            {
                int max = GetMaxValue(a);
                Console.WriteLine(max);
                break;
            }
        }
    }

    // �z��̍ő�l�����߂郁�\�b�h
    static int GetMaxValue(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
