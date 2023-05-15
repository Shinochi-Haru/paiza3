using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        List<string> data = new List<string>();
        HashSet<string> names = new HashSet<string>();

        for (int i = 0; i < num; i++)
        {
            string name = Console.ReadLine();

            if (names.Contains(name))
            {
                data.Add("NO");
            }
            else
            {
                data.Add("YES");
                names.Add(name);
            }

            Console.WriteLine(data[i]);
        }
    }
}
