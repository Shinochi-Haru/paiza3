using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static Dictionary<int, int> Factorize(int n)
    {
        var factors = new Dictionary<int, int>();

        for (int i = 2; i * i <= n; i++)
        {
            while (n % i == 0)
            {
                if (factors.ContainsKey(i))
                {
                    factors[i]++;
                }
                else
                {
                    factors[i] = 1;
                }

                n /= i;
            }
        }

        if (n > 1)
        {
            if (factors.ContainsKey(n))
            {
                factors[n]++;
            }
            else
            {
                factors[n] = 1;
            }
        }

        return factors;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for(int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        var factors = Factorize(numbers[0]);

        for (int i = 1; i < n; i++)
        {
            var localFactors = Factorize(numbers[i]);

            foreach (var kvp in localFactors)
            {
                int factor = kvp.Key;
                int power = kvp.Value;

                if (factors.ContainsKey(factor))
                {
                    factors[factor] = Math.Max(factors[factor], power);
                }
                else
                {
                    factors[factor] = power;
                }
            }
        }

        long lcm = 1;
        foreach (var kvp in factors)
        {
            int factor = kvp.Key;
            int power = kvp.Value;

            for (int i = 0; i < power; i++)
            {
                lcm *= factor;
            }
        }

        Console.WriteLine(lcm);
    }
}
