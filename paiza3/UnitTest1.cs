using System;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        //long m1, m2, b1, b2;
        //m1 = long.Parse(Console.ReadLine());
        //m2 = long.Parse(Console.ReadLine());
        //b1 = long.Parse(Console.ReadLine());
        //b2 = long.Parse(Console.ReadLine());
        var longArray = Console.ReadLine().Split().Select(long.Parse).ToArray();

        for (long i = 0; i < longArray[1]; i++)
        {
            long cand = longArray[0] * i + longArray[2];
            if (cand % longArray[1] == longArray[3])
            {
                Console.WriteLine(cand);
                return;
            }
        }
    }
}
