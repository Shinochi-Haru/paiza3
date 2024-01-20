using System;

class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        char[] arrChar = new char[num];
        for (int i = 0; i < num; i++)
        {
            arrChar[i] = char.Parse(Console.ReadLine());
        }
        var num2 = int.Parse(Console.ReadLine());
        for (int j = 0; j < num2; j++)
        {
            string s = Console.ReadLine();
            foreach(char c in arrChar)
            {
                if(s.Contains(c.ToString()))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}