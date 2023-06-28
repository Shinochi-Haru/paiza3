using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = 0;
        List<int> trail = new List<int>();

        for(int i = 0; i < nums[0]; i++)
        {
            int v = int.Parse(Console.ReadLine());
            var edges = Console.ReadLine().Split().Select(int.Parse).ToList();
            DFS(v, trail, edges, nums[2]);
            count++;
        }
        for(int j = 0; j < nums[1]; j++)
        {
            Console.WriteLine(string.Join(" ",trail));
        }
    }

    static void DFS(int v, List<int> trail,List<int> edges, int k)
    {
        List<int> numList = new List<int>();
        for(int i = 0; i < v; i++)
        {
            if (k == 0)
            {
                numList.Add(trail[i]);
            }
            else if(k != 0)
            {
                edges.Add(i);
                DFS(i, trail, edges, k - 1);
                numList.Remove(i);
                edges.Remove(i);
            }
        }
    }
}