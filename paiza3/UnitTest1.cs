using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        List<string> membership = new List<string>();
        Dictionary<string, long> money_sum = new Dictionary<string, long>();

        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0];
            string E = input[1];

            if (E == "give")
            {
                long money = long.Parse(input[2]);
                if (money_sum.ContainsKey(name))
                {
                    money_sum[name] += money;
                }
                else
                {
                    money_sum[name] = money;
                }
            }
            else
            {
                membership.Add(name);
            }
        }

        List<KeyValuePair<string, long>> sorted_sum = money_sum.OrderByDescending(x => x.Value).ToList();

        foreach (KeyValuePair<string, long> pair in sorted_sum)
        {
            Console.WriteLine(pair.Key);
        }

        foreach (string name in membership.OrderBy(x => x))
        {
            Console.WriteLine(name);
        }
    }
}
