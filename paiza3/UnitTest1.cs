using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        // チャットに参加したメンバーを保持するリスト
        List<string> membership = new List<string>();
        // スーパーチャットの情報を保持するリスト
        List<Tuple<long, string>> superchat = new List<Tuple<long, string>>();
        // メンバーごとの受け取った金額の合計を保持する辞書
        Dictionary<string, long> money_sum = new Dictionary<string, long>();

        // 入力を受け取り、処理を行う
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            string name = input[0];
            string E = input[1];

            if (E == "give")
            {
                // "give"の場合は、受け取った金額を加算する
                long money = long.Parse(input[2]);
                if (money_sum.ContainsKey(name))
                {
                    money_sum[name] += money;
                }
                else
                {
                    money_sum[name] = money;
                }
            }
            else
            {
                // "join"の場合は、チャットに参加したメンバーとして登録する
                membership.Add(name);
            }
        }

        // スーパーチャットの情報を作成する
        foreach (var item in money_sum)
        {
            superchat.Add(Tuple.Create(item.Value, item.Key));
        }

        // スーパーチャットの情報を並び替える（金額が多い順、同じ場合は名前の昇順）
        superchat.Sort((x, y) =>
        {
            int result = y.Item1.CompareTo(x.Item1);
            if (result == 0)
            {
                result = x.Item2.CompareTo(y.Item2);
            }
            return result;
        });

        // チャットに参加したメンバーを並び替える（名前の昇順）
        membership.Sort();

        // スーパーチャットの情報を出力する
        foreach (var item in superchat)
        {
            Console.WriteLine(item.Item2);
        }

        // チャットに参加したメンバーを出力する
        foreach (var item in membership)
        {
            Console.WriteLine(item);
        }
    }
}
