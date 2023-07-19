using System;
using System.Collections.Generic;
using System.Linq;
//‘o•ûŒü˜AŒ‹ƒŠƒXƒg
class Program
{
    private static int[] numArray;
    private static int count;

    private static void CustomList()
    {
        numArray = new int[4];
        count = 0;
    }

    private static void AddList()
    {
        count++;
        if(count == numArray.Length)
        {
            int[] array = new int[count];
            Array.Copy(numArray, array, numArray.Length);
            numArray = array;
        }
    }

    private static void RemoveList()
    {
        count--;
        if(count == numArray.Length)
        {
            int[] removeArray = new int[count];
            Array.Copy(numArray, removeArray, numArray.Length);
            numArray = removeArray;
        }
    }

    private static void SwapList()
    {

    }

    private static void Sort()
    {

    }
}
