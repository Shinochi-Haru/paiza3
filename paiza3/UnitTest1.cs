using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        Stack<int> numsStack = new Stack<int>();
        Console.WriteLine(num);

        for (int i = 0; i < num; i++)
        {
            int numValue = int.Parse(Console.ReadLine());
            numsStack.Push(numValue);
            numValue = numsStack.Pop();
            Console.WriteLine(numValue);
        }

        //while (numsStack.Count > 0)
        //{
            
        //}
    }
}
