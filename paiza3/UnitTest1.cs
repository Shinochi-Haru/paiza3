using System;

public class QuickSort
{
    public static void Main()
    {
        int[] arr = { 7, 2, 1, 6, 8, 5, 3, 4 };

        Console.WriteLine("元の配列: ");
        PrintArray(arr);

        QuickSortAlgorithm(arr, 0, arr.Length - 1);

        Console.WriteLine("ソートされた配列: ");
        PrintArray(arr);
    }

    private static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // 配列をパーティション分割する
            int pivotIndex = Partition(arr, low, high);

            // 2つのパーティションを再帰的にソートする
            QuickSortAlgorithm(arr, low, pivotIndex - 1);
            QuickSortAlgorithm(arr, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // ピボットを選択（ここでは配列の最後の要素）

        int i = low - 1; // iの初期値を設定

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j); // 要素を交換する
            }
        }

        Swap(arr, i + 1, high); // ピボットを正しい位置に移動する
        return i + 1; // ピボットのインデックスを返す
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }

    private static void PrintArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
