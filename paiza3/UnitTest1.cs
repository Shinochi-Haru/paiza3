using System;
using System.Linq;

public class InsertionSort
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        InsertionSortAlgorithm(nums, n);
    }

    private static void InsertionSortAlgorithm(int[] a, int n)
    {
        for (int i = 1; i < n; i++)
        {
            for (int j = i; j > 0 && a[j - 1] > a[j]; j--)
            {
                Swap(ref a[j - 1], ref a[j]);
            }
            Console.WriteLine(string.Join(" ", a));
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
