using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        Queue<int> que = new Queue<int>();
        int next_person = 0;
        int person_on_escalator = 0;
        for (int time = 1; time < 50000; time++)
        {
            if (next_person < n && time == a[next_person])
            {
                que.Enqueue(1);
                person_on_escalator++;
            }
            else
            {
                que.Enqueue(0);
            }
            if (que.Count > k)
            {
                person_on_escalator -= que.Dequeue();
            }
            if (next_person < n && time == a[next_person])
            {
                Console.WriteLine(person_on_escalator);
                next_person++;
            }
        }
    }
}
