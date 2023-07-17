using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool hasTripleCrown = false;
        bool hasDoubleCrown = false;

        for (int i = 0; i < n; i++)
        {
            string[] data = Console.ReadLine().Split(' ');
            double battingAverage = double.Parse(data[0]);
            int runsBattedIn = int.Parse(data[1]);
            int homeRuns = int.Parse(data[2]);

            if (battingAverage >= 0.3 && runsBattedIn >= 100 && homeRuns >= 30)
                hasTripleCrown = true;
            else if (battingAverage >= 0.3 && runsBattedIn >= 100)
                hasDoubleCrown = true;
            else if (battingAverage >= 0.3 && homeRuns >= 30)
                hasDoubleCrown = true;
            else if (runsBattedIn >= 100 && homeRuns >= 30)
                hasDoubleCrown = true;
        }

        if (hasTripleCrown)
            Console.WriteLine("Triple");
        else if (hasDoubleCrown)
            Console.WriteLine("Double");
        else
            Console.WriteLine("Nobody");
    }
}
