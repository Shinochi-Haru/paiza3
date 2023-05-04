using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        int ans = 1;
        Dictionary<int, int> divisors = new Dictionary<int, int>();

        for (int i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                if (divisors.ContainsKey(i))
                {
                    divisors[i]++;
                }
                else
                {
                    divisors.Add(i, 1);
                }
                n /= i;
            }
        }

        if (n != 1)
        {
            if (divisors.ContainsKey(n))
            {
                divisors[n]++;
            }
            else
            {
                divisors.Add(n, 1);
            }
        }

        foreach (KeyValuePair<int, int> kvp in divisors)
        {
            ans *= kvp.Value + 1;
        }

        Console.WriteLine($"Number of divisors of {n} is {ans}");
    }
}
