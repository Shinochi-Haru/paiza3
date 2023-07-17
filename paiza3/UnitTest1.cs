using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        List<int> intList = new List<int>();

        for (int i = 1; i < num; i++)
        {
            for (int j = i + 1; j <= num; j++)
            {
                int gcd = GetGCD(i, j);
                intList.Add(gcd);
            }
        }

        int maxGCD = intList.Max();
        Console.WriteLine(maxGCD);
    }

    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }
}
