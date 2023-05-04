using System;

class Program
{
    static void Main()
    {
        int num1, num2;
        num1 = int.Parse(Console.ReadLine());
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Å‘åŒö–ñ”: " + GCD(num1, num2));
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        return GCD(b, a % b);
    }
}
