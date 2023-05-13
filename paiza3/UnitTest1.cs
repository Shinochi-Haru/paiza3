using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        SortedSet<string> nameSet = new SortedSet<string>();

        for (int i = 0; i < nums[0]; i++)
        {
            nameSet.Add(Console.ReadLine());
        }

        for (int i = 0; i < nums[1]; i++)
        {
            var ivent = Console.ReadLine();
            if (ivent.Contains("join"))
            {
                var join = ivent.Split().ToArray();
                nameSet.Add(join[1]);
            }
            else if (ivent.Contains("leave"))
            {
                var leave = ivent.Split().ToArray();
                nameSet.Remove(leave[1]);
            }
            else if (ivent.Contains("handshake"))
            {
                foreach (var name in nameSet)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
