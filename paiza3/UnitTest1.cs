using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        Stack<char> st = new Stack<char>();
        for (int i = 0; i < n; i++)
        {
            if (st.Count > 0 && st.Peek() == '(' && s[i] == ')')
            {
                st.Pop();
            }
            else
            {
                st.Push(s[i]);
            }
        }
        if (st.Count == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
