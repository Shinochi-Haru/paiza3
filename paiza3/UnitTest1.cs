using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] nx = Console.ReadLine().Split();
        int n = int.Parse(nx[0]);
        int x = int.Parse(nx[1]);
        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> queue = new Queue<int>();
        int sum = 0;         // ��Ԃ̘a
        int max_sum = 0;     // ��Ԃ̘a�̍ő�
        int left_num = -1;   // ��Ԃ̘a���ő�ɂȂ鍶�[�̒l
        for (int i = 0; i < n; i++)
        {
            sum += a[i];
            queue.Enqueue(a[i]);
            if (queue.Count == x)
            {
                if (sum > max_sum)
                {
                    left_num = queue.Peek();
                    max_sum = sum;
                }
                sum -= queue.Dequeue();
            }
        }
        Console.WriteLine(max_sum + " " + left_num);
    }
}
