using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        int N, K;
        string[] input = Console.ReadLine().Split(' ');
        N = int.Parse(input[0]);
        K = int.Parse(input[1]);

        List<string> company = new List<string>();
        Dictionary<string, string> password = new Dictionary<string, string>();
        Dictionary<string, int> deposit = new Dictionary<string, int>();

        for (int i = 0; i < N; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            string c = data[0];
            string p = data[1];
            int m = int.Parse(data[2]);
            company.Add(c);
            password[c] = p;
            deposit[c] = m;
        }

        for (int i = 0; i < K; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            string g = data[0];
            string m = data[1];
            int p = int.Parse(data[2]);
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
