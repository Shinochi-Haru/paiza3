using System;

class Program
{
    static void Main()
    {
        var num1 = int.Parse(Console.ReadLine());
        for (int i = 0; i < num1; i++)
        {
            var num = int.Parse(Console.ReadLine());

            if (IsPrime(num))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
