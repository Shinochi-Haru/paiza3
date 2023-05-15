using System;
class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num >= 1 && num <= 5)
        {
            Console.WriteLine("raw");
        }
        else if (num >= 6 && num <= 7)
        {
            Console.WriteLine("soft boiled");
        }
        else
        {
            Console.WriteLine("hard boiled");
        }
    }
}