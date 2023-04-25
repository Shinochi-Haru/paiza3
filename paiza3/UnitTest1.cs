using System;
using System.Collections.Generic;
using System.Text;

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

            // 連結用のStringBuilderを用意する
            StringBuilder sb = new StringBuilder();
            foreach (char c in queue)
            {
                // 文字列を連結する
                sb.Append(c);
                sb.Append(' ');
            }
            // 最後に空白を除去して、文字列に変換して出力する
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
