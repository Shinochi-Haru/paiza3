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

            // �A���p��StringBuilder��p�ӂ���
            StringBuilder sb = new StringBuilder();
            foreach (char c in queue)
            {
                // �������A������
                sb.Append(c);
                sb.Append(' ');
            }
            // �Ō�ɋ󔒂��������āA������ɕϊ����ďo�͂���
            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
