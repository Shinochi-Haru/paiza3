using System;
using System.Linq;

public class Program
{
    public static int EuclideanAlgorithm(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

    public static void Main(string[] args)
    {
        var num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int gcd = EuclideanAlgorithm(num[0], num[1]);

        Console.WriteLine(gcd);
    }
}
