using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N, K;
        N = Console.Read() - '0';
        K = Console.Read() - '0';

        List<string> company = new List<string>(N);
        Dictionary<string, string> password = new Dictionary<string, string>();
        Dictionary<string, int> deposit = new Dictionary<string, int>();

        for (int i = 0; i < N; i++)
        {
            int money;
            string pass;
            company.Add(Console.ReadLine());
            pass = Console.ReadLine();
            money = int.Parse(Console.ReadLine());
            password[company[i]] = pass;
            deposit[company[i]] = money;
        }

        for (int i = 0; i < K; i++)
        {
            string g, m;
            int p;
            g = Console.ReadLine();
            m = Console.ReadLine();
            p = int.Parse(Console.ReadLine());
            if (m == password[g])
            {
                deposit[g] -= p;
            }
        }

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(company[i] + " " + deposit[company[i]]);
        }
    }
}
