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
        int sum = 0;         // ‹æŠÔ‚Ì˜a
        int max_sum = 0;     // ‹æŠÔ‚Ì˜a‚ÌÅ‘å
        int left_num = -1;   // ‹æŠÔ‚Ì˜a‚ªÅ‘å‚É‚È‚é¶’[‚Ì’l
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
