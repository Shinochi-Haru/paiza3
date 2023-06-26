using System;
using System.Linq;

class Program
{
    static int count = 0;

    static void QuickSort(int[] a, int left, int right)
    {
        if (left + 1 >= right)
        {
            return;
        }

        int pivot = a[right - 1];

        int cur_index = left;
        for (int i = left; i < right - 1; i++)
        {
            if (a[i] < pivot)
            {
                Swap(ref a[cur_index], ref a[i]);
                cur_index++;
                count++;
            }
        }

        Swap(ref a[cur_index], ref a[right - 1]);

        QuickSort(a, left, cur_index);
        QuickSort(a, cur_index + 1, right);
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var a = Console.ReadLine().Split().Select(int.Parse).ToArray();

        QuickSort(a, 0, n);

        for (int i = 0; i < n; i++)
        {
            if (i > 0) Console.Write(" ");
            Console.Write(a[i]);
        }
        Console.WriteLine();

        Console.WriteLine(count);
    }
}
