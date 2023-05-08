using System;
using System.Collections.Generic;

class MainClass
{
    static bool IsPrime(int x)
    {
        if (x == 0 || x == 1)
        {
            return false;
        }

        for (int i = 2; i * i <= x; i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static void Main(string[] args)
    {
        List<int> ans = new List<int>();
        for (int i = 3; i * i <= 100000000; i += 2)
        {
            if (!IsPrime(i * i - 2))
            {
                ans.Add(i * i);
            }
        }

        if (ans.Count == 0)
        {
            Console.WriteLine("paiza's conjecture is correct.");
        }
        else
        {
            foreach (int a in ans)
            {
                Console.WriteLine(a);
            }
        }
    }
}
