using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(nums[0] - nums[1] + nums[2]);
    }
}