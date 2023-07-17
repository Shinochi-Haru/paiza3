using System;
using System.Linq;
class Program
{
    static void Main()
    {
        Console.ReadLine();
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(nums.Max() - nums.Min());
    }
}