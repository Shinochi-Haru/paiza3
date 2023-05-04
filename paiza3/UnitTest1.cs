using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write($"Prime factors of {n} are: ");
        int factor = 2;
        while (n > 1)
        {
            if (n % factor == 0)
            {
                Console.Write($"{factor} ");
                n /= factor;
            }
            else
            {
                factor++;
            }
        }
        Console.WriteLine();
    }
}
