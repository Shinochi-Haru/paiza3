using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        string[] pixels = new string[n];
        for (int i = 0; i < n; i++)
        {
            pixels[i] = Console.ReadLine();
        }

        // ‚’¼‚ÉÜ‚è‚½‚½‚ÞÛ
        bool isLineSymmetry1 = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (pixels[i][j] != pixels[i][m - j - 1])
                {
                    isLineSymmetry1 = false;
                    break;
                }
            }
        }

        // …•½‚ÉÜ‚è‚½‚½‚ÞÛ
        bool isLineSymmetry2 = true;
        for (int j = 0; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                if (pixels[i][j] != pixels[n - i - 1][j])
                {
                    isLineSymmetry2 = false;
                    break;
                }
            }
        }

        bool isLineSymmetry = isLineSymmetry1 || isLineSymmetry2;

        // “_‘ÎÌ
        bool isPointSymmetry = true;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (pixels[i][j] != pixels[n - i - 1][m - j - 1])
                {
                    isPointSymmetry = false;
                    break;
                }
            }
        }

        if (isLineSymmetry && isPointSymmetry)
        {
            Console.WriteLine("line point symmetry");
        }
        else if (isLineSymmetry)
        {
            Console.WriteLine("line symmetry");
        }
        else if (isPointSymmetry)
        {
            Console.WriteLine("point symmetry");
        }
        else
        {
            Console.WriteLine("none");
        }
    }
}
