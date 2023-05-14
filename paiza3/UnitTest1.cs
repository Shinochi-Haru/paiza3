using System; // 標準ライブラリのSystemをインポート
using System.Collections.Generic; // 標準ライブラリのSystem.Collections.Genericをインポート

class MainClass
{
    public static void Main(string[] args) // Mainメソッド
    {
        int N, K; // 変数の宣言
        string[] input = Console.ReadLine().Split(' '); // 標準入力から値を取得し、空白で分割した結果を配列に格納
        N = int.Parse(input[0]); // 配列の1番目の要素をint型に変換して変数Nに格納
        K = int.Parse(input[1]); // 配列の2番目の要素をint型に変換して変数Kに格納

        List<string> name = new List<string>(); // 名前を格納するリストを宣言
        Dictionary<string, List<KeyValuePair<string, int>>> receipt = new Dictionary<string, List<KeyValuePair<string, int>>>(); // レシートを格納する辞書を宣言

        for (int i = 0; i < N; i++) // N回ループ
        {
            name.Add(Console.ReadLine()); // 標準入力から名前を取得し、リストに追加
            receipt.Add(name[i], new List<KeyValuePair<string, int>>()); // 辞書に名前をキーとして、空のリストを値として追加
        }

        for (int i = 0; i < K; i++) // K回ループ
        {
            string[] data = Console.ReadLine().Split(' '); // 標準入力から値を取得し、空白で分割した結果を配列に格納
            string a = data[0]; // 配列の1番目の要素を変数aに格納
            string p = data[1]; // 配列の2番目の要素を変数pに格納
            int m = int.Parse(data[2]); // 配列の3番目の要素をint型に変換して変数mに格納
            receipt[a].Add(new KeyValuePair<string, int>(p, m)); // 辞書のキーがaのリストに、商品名と金額を格納したKeyValuePairを追加
        }

        for (int i = 0; i < N; i++) // N回ループ
        {
            Console.WriteLine(name[i]); // 名前を出力
            foreach (KeyValuePair<string, int> pm in receipt[name[i]]) // 名前をキーとしたリストの要素をループで取り出し
            {
                Console.WriteLine(pm.Key + " " + pm.Value); // 商品名と金額を出力
            }
            Console.WriteLine("-----"); // 区切り線を出力
        }
    }
}
