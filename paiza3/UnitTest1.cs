using System;
using System.Collections.Generic;

class MainClass
{
    static void Main()
    {
        int N, K;
        string[] input = Console.ReadLine().Split(' ');
        N = int.Parse(input[0]);
        K = int.Parse(input[1]);

        List<string> name = new List<string>();
        Dictionary<string, List<(string, int)>> receipt = new Dictionary<string, List<(string, int)>>();

        for (int i = 0; i < N; i++)
        {
            name.Add(Console.ReadLine());
        }

        for (int i = 0; i < K; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            string a = data[0];
            string p = data[1];
            int m = int.Parse(data[2]);

            if (!receipt.ContainsKey(a))
            {
                receipt[a] = new List<(string, int)>();
            }
            receipt[a].Add((p, m));
        }

        foreach (string n in name)
        {
            Console.WriteLine(n);
            if (receipt.ContainsKey(n))
            {
                foreach ((string, int) item in receipt[n])
                {
                    Console.WriteLine($"{item.Item1} {item.Item2}");
                }
            }
            Console.WriteLine("-----");
        }
    }
}
