using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        var NK = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var N = NK[0];
        var K = NK[1];

        SortedSet<string> member = new SortedSet<string>();
        for (int i = 0; i < N; i++)
        {
            string name = Console.ReadLine();
            member.Add(name);
        }

        for (int i = 0; i < K; i++)
        {
            string[] line = Console.ReadLine().Split();
            var S = line[0];

            if (S == "handshake")
            {
                foreach (var x in member)
                {
                    Console.WriteLine(x);
                }
            }
            else
            {
                var name = line[1];
                if (S == "join")
                {
                    member.Add(name);
                }
                else
                {
                    member.Remove(name);
                }
            }
        }
    }
}
