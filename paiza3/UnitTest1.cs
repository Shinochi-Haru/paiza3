using System;

class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());

        if (IsPrime(num, 5))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    static bool IsPrime(int num, int k)
    {
        if (num <= 1)
        {
            return false;
        }

        if (num == 2 || num == 3)
        {
            return true;
        }

        if (num % 2 == 0)
        {
            return false;
        }

        Random rnd = new Random();
        for (int i = 0; i < k; i++)
        {
            int a = rnd.Next(2, num - 2);
            if (Gcd(a, num) != 1 || ModPow(a, num - 1, num) != 1)
            {
                return false;
            }
        }

        return true;
    }

    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        return a;
    }

    static int ModPow(int x, int y, int m)
    {
        int res = 1;
        while (y > 0)
        {
            if ((y & 1) != 0)
            {
                res = (res * x) % m;
            }
            x = (x * x) % m;
            y >>= 1;
        }

        return res;
    }
}
