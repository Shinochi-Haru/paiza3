using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static Dictionary<int, List<int>> adjacencyList;

    static void Main()
    {
        int n, k;
        string[] input = Console.ReadLine().Split(' ');
        n = int.Parse(input[0]);
        k = int.Parse(input[1]);

        adjacencyList = new Dictionary<int, List<int>>();

        // ×ÚXgÌì¬
        for (int i = 1; i <= n; i++)
        {
            int v = int.Parse(Console.ReadLine());
            adjacencyList[i] = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));
        }

        HashSet<int> notVisited = new HashSet<int>(Enumerable.Range(1, n));

        // ¢KâÌ¸_ðTõµÄA¬ªð»è
        while (notVisited.Count > 0)
        {
            int v = notVisited.First();
            List<int> connectedComp = DFS(v, new List<int>() { v });

            if (connectedComp.Count > k)
            {
                Console.WriteLine("No");
                return;
            }

            notVisited.ExceptWith(connectedComp);
        }

        Console.WriteLine("Yes");
    }

    // [³DæTõiDFSjðs¤Ö
    static List<int> DFS(int v, List<int> connectedComp)
    {
        foreach (int i in adjacencyList[v])
        {
            if (!connectedComp.Contains(i))
            {
                connectedComp.Add(i);
                DFS(i, connectedComp);
            }
        }

        return connectedComp;
    }
}
