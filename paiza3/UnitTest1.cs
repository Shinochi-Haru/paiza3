using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int[] numbers = new int[input];
        for (int i = 0; i < input; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            result = GetGCD(result, numbers[i]);
        }

        Console.WriteLine("Å‘åŒö–ñ”: " + result);
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
