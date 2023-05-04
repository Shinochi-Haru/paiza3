using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        int[] numbers = new int[num];
        for(int i = 0; i < num; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = GCD(result, numbers[i]);
        }

        Console.WriteLine("The GCD is {0}", result);
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GCD(b, a % b);
        }
    }
}
