using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        int n, ans1 = 0, ans2 = 0;
        long multi = 0;
        n = int.Parse(Console.ReadLine());

        bool[] is_prime = new bool[n + 1];
        List<long> primes = new List<long>();

        for (int i = 0; i <= n; i++)
        {
            is_prime[i] = true;
        }
        is_prime[0] = false;
        is_prime[1] = false;

        for (int i = 2; i <= n; i++)
        {
            if (is_prime[i])
            {
                primes.Add(i);
                for (int j = i * 2; j <= n; j += i)
                {
                    is_prime[j] = false;
                }
            }
        }

        foreach (long p in primes)
        {
            long other_prime = n - p;
            if (is_prime[other_prime])
            {
                if (multi < p * other_prime)
                {
                    multi = p * other_prime;
                    ans1 = (int)p;
                    ans2 = (int)other_prime;
                }
            }
        }

        if (ans1 <= ans2)
        {
            Console.WriteLine(ans1);
            Console.WriteLine(ans2);
        }
        else
        {
            Console.WriteLine(ans2);
            Console.WriteLine(ans1);
        }
    }
}
