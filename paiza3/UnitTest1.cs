using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        List<string> data = new List<string>();

        for (int i = 0; i < num; i++)
        {
            var names = Console.ReadLine();
            if(data.Contains(names))
            {
                data.Add("NO");
            }
            else
            {
                data.Add("YES");
            }
            Console.WriteLine(data[i]);
        }
    }
}