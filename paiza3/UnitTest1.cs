using System;

namespace ƒVƒmƒ`ƒnƒ‹
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 7, 1, 3, 4, 2 };
            InsertionSort(numArray, numArray.Length);
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }

        static void InsertionSort(int[] sortArray, int n)
        {
            if (n <= 1)
            {
                return;
            }

            InsertionSort(sortArray, n - 1);

            int sort = sortArray[n - 1];
            int j = n - 2;

            while (j >= 0 && sortArray[j] > sort)
            {
                sortArray[j + 1] = sortArray[j];
                j--;
            }

            sortArray[j + 1] = sort;
        }
    }
}
