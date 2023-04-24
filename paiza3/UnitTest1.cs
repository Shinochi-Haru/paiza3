using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> st = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            int a = int.Parse(Console.ReadLine());
            st.Push(a);
            while (st.Count >= 2)
            {
                int top1 = st.Peek(); // スタックの上から一番目
                st.Pop();
                int top2 = st.Peek(); // スタックの上から二番目
                st.Pop();
                if (top1 == top2)
                {
                    st.Push(2 * top2);
                }
                else
                {
                    st.Push(top2);
                    st.Push(top1);
                    break;
                }
            }
        }
        while (st.Count > 0)
        {
            Console.WriteLine(st.Peek());
            st.Pop();
        }
    }
}
