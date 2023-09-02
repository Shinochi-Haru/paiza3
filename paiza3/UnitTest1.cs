using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] m = new int[n];

        for (int i = 0; i < n; i++)
        {
            m[i] = int.Parse(Console.ReadLine());
        }

        int maxProfit = 0;
        int buyDay = 0;
        int sellDay = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int profit = m[j] - m[i];
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                    buyDay = i + 1;  // 1-based index
                    sellDay = j + 1; // 1-based index
                }
            }
        }

        Console.WriteLine(buyDay);
        Console.WriteLine(sellDay);
    }
}
