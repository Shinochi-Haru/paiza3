using System;

class Program
{
    static void Main1(string[] args)
    {
        int[] numArray = new int [] { 7, 1, 3, 4, 2 };

        for(int i = 1; i < numArray.Length; i++)
        {
            int sort = numArray[i];

            if(sort < numArray[i - 1])
            {
                numArray[i - 1] = sort;
            }
        }

        for(int i = 0; i < numArray.Length; i++)
        {
            Console.WriteLine(numArray[i]);
        }
    }
}
