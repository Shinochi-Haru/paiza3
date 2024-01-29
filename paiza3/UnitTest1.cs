using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var num = int.Parse(Console.ReadLine());
        List<string> log = new List<string>();
        //string[] log = new string[num];
        string word;
        for (int i = 0; i < num; i++)
        {
            word = Console.ReadLine();
            if (log.Contains(word))
            {
                log.Remove(word);
            }
            // æ“ª‚É’Ç‰Á
            log.Insert(0, word);
        }

        for (int i = 0; i < log.Count; i++)
        {
            Console.WriteLine(log[i]);
        }
    }
}