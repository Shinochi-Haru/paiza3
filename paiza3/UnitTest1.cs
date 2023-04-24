using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            b[i] = a[i];
        }

        for (int i = n - 1; i >= 0; i--)
        {
            if (i != n - 1)
            {
                Console.Write(" ");
            }
            Console.Write(b[i]);
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    b[j] *= 2;
                }
            }
        }
        Console.WriteLine();
    }
}
