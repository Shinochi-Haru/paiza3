using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        int[,] g = new int[N, N];
        List<List<int>> G = new List<List<int>>();

        for (int i = 0; i < N; i++)
        {
            G.Add(new List<int>());
        }

        for (int i = 0; i < M; i++)
        {
            input = Console.ReadLine().Split();
            int a = int.Parse(input[0]) - 1;
            int b = int.Parse(input[1]) - 1;
            g[a, b] = 1;
            G[a].Add(b);
        }

        Console.WriteLine("—×Ús—ñ:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(g[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("—×ÚƒŠƒXƒg:");
        for (int i = 0; i < N; i++)
        {
            G[i].Sort();
            foreach (int neighbor in G[i])
            {
                Console.Write(neighbor + " ");
            }
            Console.WriteLine();
        }
    }
}
