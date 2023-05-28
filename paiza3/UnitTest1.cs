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

    public static int GcdOfMultipleNumbers(params int[] numbers)
    {
        if (numbers.Length < 2)
        {
            throw new ArgumentException("At least two numbers are required.");
        }

        int gcd = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            gcd = EuclideanAlgorithm(gcd, numbers[i]);
        }

        return gcd;
    }

    public static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int gcd = GcdOfMultipleNumbers(input);

        Console.WriteLine(gcd);
    }
}
