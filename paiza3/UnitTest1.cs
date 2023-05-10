using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<string> nameList = new List<string>();
        //List<int> iventList = new List<int>();

        for(int i = 0; i < nums[0]; i++)
        {
            nameList.Add(Console.ReadLine());
        }

        for(int i = 0; i < nums[1]; i++)
        {
            string ivent = Console.ReadLine();
        }
    }
}
