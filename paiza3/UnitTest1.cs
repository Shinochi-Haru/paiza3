using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] intArray = new int[n];
        int factor = 2;
        for(int i = 0; i < n; i++)
        {
            intArray[i] = int.Parse(Console.ReadLine());
            if (intArray[i] % factor == 0)
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
