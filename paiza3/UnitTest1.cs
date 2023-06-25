using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, List<int>> adjacencyList; // —×ÚƒŠƒXƒg
    static List<int> maxTrail; // Å’·Œo˜H

    static void Main(string[] args)
    {
        // “ü—Í‚ğó‚¯æ‚èA•Ï”‚ÉŠi”[
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]); // ƒm[ƒh”
        int s = int.Parse(input[1]); // n“_
        int t = int.Parse(input[2]); // I“_

        // —×ÚƒŠƒXƒg‚Ìì¬
        adjacencyList = new Dictionary<int, List<int>>();
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            int[] neighbors = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            adjacencyList[i] = new List<int>(neighbors);
        }

        // Å’·Œo˜H‚ğŠi”[‚·‚éƒŠƒXƒg‚Ì‰Šú‰»
        maxTrail = new List<int>();

        // [‚³—Dæ’Tõ‚ÌÀs
        DFS(s, new List<int> { s }, new List<Tuple<int, int>>(), t);

        // Œ‹‰Ê‚ğo—Í
        Console.WriteLine(string.Join(" ", maxTrail));
    }

    // [‚³—Dæ’Tõ‚ÌŠÖ”
    static void DFS(int v, List<int> trail, List<Tuple<int, int>> edges, int t)
    {
        foreach (int i in adjacencyList[v])
        {
            Tuple<int, int> e = Tuple.Create(Math.Min(i, v), Math.Max(i, v));

            if (!edges.Contains(e))
            {
                trail.Add(i);

                if (i != trail[0])
                {
                    edges.Add(e);

                    if (i == t && trail.Count > maxTrail.Count)
                    {
                        maxTrail = new List<int>(trail);
                    }
                    else
                    {
                        DFS(i, trail, edges, t);
                    }

                    edges.Remove(e);
                }

                trail.RemoveAt(trail.Count - 1);
            }
        }
    }
}
