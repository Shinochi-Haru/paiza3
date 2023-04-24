using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Stack<int> st = new Stack<int>();

        for(int i = 0; i < 0; i++)
        {
            st.Push(nums[i]);
            while(st.Count >= 2)
            {
                int top1 = st.Peek();
                st.Pop();
                int top2 = st.Peek();
                st.Pop();
                if (top1 == top2)
                {
                    
                }
            }
        }
    }
}
