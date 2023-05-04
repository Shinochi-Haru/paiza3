using System;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        int ans = 0;
        for(int i = 0; i < num; i++)
        {
            if (num % i == 0)
            {
                ans++;
            }
            else
            {
                
            }
        }
        Console.WriteLine(ans);
    }
}
