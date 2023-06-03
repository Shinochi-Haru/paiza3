using System;
using System.Linq;

public class QuickSort
{
    public static void Main()
    {
        var num = Console.ReadLine();
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        for (int i = 0; i < nums.Length; i++)
        {
            int key = nums[i];
            int j = nums.Length - 1;
            while (j >= 0 && nums[j] > key)
            {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = key;
            Console.WriteLine(nums[i]);
        }
    }
}
