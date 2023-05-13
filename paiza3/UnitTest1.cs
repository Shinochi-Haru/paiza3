using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        int N, K;
        string[] S;
        List<Tuple<int, string>> history;

        // Input N, K and S[]
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        N = input[0];
        K = input[1];
        S = new string[N];
        for (int i = 0; i < N; i++)
        {
            S[i] = Console.ReadLine();
        }

        // Input history
        history = new List<Tuple<int, string>>();
        for (int i = 0; i < K; i++)
        {
            var line = Console.ReadLine().Split().ToArray();
            var time = int.Parse(line[0]);
            var str = line[1];
            history.Add(Tuple.Create(time, str));
        }

        // Sort history by time and output result
        history.Sort((x, y) => x.Item1.CompareTo(y.Item1));
        foreach (var h in history)
        {
            Console.WriteLine(h.Item2);
        }
    }
}
