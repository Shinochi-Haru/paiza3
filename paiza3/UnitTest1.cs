using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numArray = new int[] { 7, 1, 3, 4, 2 };
        for (int i = 1; i < numArray.Length; i++)
        {
            int sort = numArray[i];
            int j = i - 1;
            while (j >= 0 && numArray[j] > sort)
            {
                numArray[j + 1] = numArray[j];
                j--;
            }
            numArray[j + 1] = sort;
        }

        for (int i = 0; i < numArray.Length; i++)
        {
            Console.WriteLine(numArray[i]);
        }
    }
}
