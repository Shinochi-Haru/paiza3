using System;
using System.Collections.Generic;

class MainClass
{
    static void ShellSort(int[] arr)
    {
        int n = arr.Length;
        int h = 1;

        while (h < n / 3)
        {
            h = 3 * h + 1;
        }

        while (h >= 1)
        {
            for (int i = h; i < n; i++)
            {
                for (int j = i; j >= h && arr[j] < arr[j - h]; j -= h)
                {
                    int temp = arr[j];
                    arr[j] = arr[j - h];
                    arr[j - h] = temp;
                }
            }
            h = h / 3;
        }
    }


    public static void Main(string[] args)
    {
        
    }
}
