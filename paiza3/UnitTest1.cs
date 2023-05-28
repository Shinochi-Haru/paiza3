using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int gcd = GetGCD(input[0],input[1]);
        int lcm = (input[0] * input[1]) / gcd;
        Console.WriteLine(lcm);
    }

    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
