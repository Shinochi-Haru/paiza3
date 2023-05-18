using System;

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
        int num1 = 48;
        int num2 = 36;
        int gcd = EuclideanAlgorithm(num1, num2);

        Console.WriteLine("Å‘åŒö–ñ”: " + gcd);
    }
}
