using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 逆ポーランド記法の式を入力
        string input = Console.ReadLine();

        // スタックを用意
        var stack = new Stack<int>();

        // 入力された式をスペースで分割して配列に変換
        string[] tokens = input.Split(' ');

        foreach (string token in tokens)
        {
            int num;
            if (int.TryParse(token, out num))
            {
                // トークンが数値の場合はスタックに積む
                stack.Push(num);
            }
            else
            {
                // トークンが演算子の場合はスタックから2つ取り出して計算
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(operand1 + operand2);
                        break;
                    case "-":
                        stack.Push(operand1 - operand2);
                        break;
                    case "*":
                        stack.Push(operand1 * operand2);
                        break;
                    case "/":
                        stack.Push(operand1 / operand2);
                        break;
                    default:
                        Console.WriteLine("不正な演算子です。");
                        return;
                }
            }
        }

        // 計算結果を出力
        Console.WriteLine("計算結果は {0} です。", stack.Pop());
    }
}
