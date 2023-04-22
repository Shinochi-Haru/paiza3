using System;
using System.Collections.Generic;

class MainClass
{
    static List<char> stack = new List<char>();     // スタック本体
    static int stack_size = 0;  // スタックに入っている要素数

    public static void Main(string[] args)
    {
        int q = int.Parse(Console.ReadLine());
        for (int i = 0; i < q; i++)
        {
            string[] queryLine = Console.ReadLine().Split(' ');
            int query = int.Parse(queryLine[0]);
            if (query == 1)
            {
                // PUSH
                char x = char.Parse(queryLine[1]);
                stack.Add(x);
                stack_size++;
            }
            else if (query == 2)
            {
                // POP
                //stack_size--;
                //Console.WriteLine(stack[stack_size]);
                stack.RemoveAt(0);
            }
            for (int j = 0; j < stack_size; j++)
            {
                if (j > 0)
                {
                    Console.Write(" ");
                }
                Console.Write(stack[j]);
            }
            Console.WriteLine();
        }
    }
}
