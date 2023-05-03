using System;

class Program
{
    static void Main()
    {
        int a = 2, fermat = 1;
        bool is_prime = true;
        int num = int.Parse(Console.ReadLine());
        int n = 0;

        for(int i = 0; i < num; i++)
        {
            n = int.Parse(Console.ReadLine());
        }

        if (n % a == 0)
        {
            is_prime = false;
        }

        for (int i = 0; i < n - 1; i++)
        {
            fermat *= a;
            fermat %= n;
        }

        if (fermat % n != 1)
        {
            is_prime = false;
        }

        if (is_prime)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
