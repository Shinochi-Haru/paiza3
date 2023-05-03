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
                Console.WriteLine("pass");
            }
            else
            {
                Console.WriteLine("failure");
            }
        }
    }

    static bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        if (num <= 3)
        {
            return true;
        }
        if (num % 2 == 0 || num % 3 == 0)
        {
            return false;
        }
        int i = 5;
        while (i * i <= num)
        {
            if (num % i == 0 || num % (i + 2) == 0)
            {
                return false;
            }
            i += 6;
        }
        return true;
    }
}
