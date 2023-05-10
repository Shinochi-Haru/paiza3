using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<string> nameList = new List<string>();
        List<string> iventList = new List<string>();

        for(int i = 0; i < nums[0]; i++)
        {
            nameList.Add(Console.ReadLine());
        }

        for(int i = 0; i < nums[1]; i++)
        {
            var ivent = Console.ReadLine();
            if(ivent.Contains("join"))
            {
                var join = ivent.Split().ToArray();
                nameList.Add(join[1]);
                Console.WriteLine(nameList[i]);
            }
            else if(ivent.Contains("leave"))
            {
                var leave = ivent.Split().ToArray();
                nameList.Remove(leave[1]);
            }
            else if (ivent.Contains("handsheak"))
            {
                Console.WriteLine(nameList[i]);
            }
        }
    }
}
