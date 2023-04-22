using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int q = int.Parse(Console.ReadLine());
        Queue<char> queue = new Queue<char>();
        for (int i = 0; i < q; i++)
        {
            string[] query = Console.ReadLine().Split();
            if (query[0] == "1")
            {
                // PUSH
                char x = char.Parse(query[1]);
                queue.Enqueue(x);
            }
            else if (query[0] == "2")
            {
                // POP
                Console.WriteLine(queue.Dequeue());
            }
            //foreach (char c in queue)
            //{
            //    Console.Write(c + " ");
            //}
            //Console.WriteLine();
            for(int j = 0; j < q; j++)
            {
                Console.WriteLine(query);
            }
            Console.WriteLine();
        }
    }
}