using System;
class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());

        if(num != 1 && num % 1 == 0 && num % num == 0)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}