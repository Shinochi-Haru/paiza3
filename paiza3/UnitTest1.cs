using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        Queue<int> queue1 = new Queue<int>();
        Queue<int> queue2 = new Queue<int>();
        for (int i = 0; i < q; i++)
        {
            string[] query = Console.ReadLine().Split();
            if (query[0] == "1")
            {
                // PUSH
                int k = int.Parse(query[1]);
                int x = int.Parse(query[2]);
                if (k == 1)
                {
                    queue1.Enqueue(x);
                }
                else if (k == 2)
                {
                    queue2.Enqueue(x);
                }
            }
            else if (query[0] == "2")
            {
                // POP
                int k = int.Parse(query[1]);
                if (k == 1)
                {
                    Console.WriteLine(queue1.Dequeue());
                }
                else if (k == 2)
                {
                    Console.WriteLine(queue2.Dequeue());
                }
            }
            else if (query[0] == "3")
            {
                // SIZE
                Console.WriteLine(queue1.Count + " " + queue2.Count);
            }
        }
    }
}
