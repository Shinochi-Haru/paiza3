using System;

class MainClass
{
    public static void Main(string[] args)
    {
        long m1, m2, b1, b2;
        m1 = long.Parse(Console.ReadLine());
        m2 = long.Parse(Console.ReadLine());
        b1 = long.Parse(Console.ReadLine());
        b2 = long.Parse(Console.ReadLine());

        for (long i = 0; i < m2; i++)
        {
            long cand = m1 * i + b1;
            if (cand % m2 == b2)
            {
                Console.WriteLine(cand);
                return;
            }
        }
    }
}
