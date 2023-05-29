using System;

class Program
{
    static void Main()
    {
        // 入力を受け取り、nとsに値を割り当てる
        string[] input1 = Console.ReadLine().Split();
        int n = int.Parse(input1[0]);
        int s = int.Parse(input1[1]);

        // n回のループで処理を行う
        for (int i = 0; i < n; i++)
        {
            // vを受け取り、aに配列として格納する
            int v = int.Parse(Console.ReadLine());
            int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            // sとi+1が等しい場合、最大値を出力してループを終了する
            if (s == i + 1)
            {
                int max = GetMaxValue(a);
                Console.WriteLine(max);
                break;
            }
        }
    }

    // 配列の最大値を求めるメソッド
    static int GetMaxValue(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }
}
