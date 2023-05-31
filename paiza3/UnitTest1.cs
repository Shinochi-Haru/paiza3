using System;

public class QuickSort
{
    public static void Main()
    {
        int[] arr = { 7, 2, 1, 6, 8, 5, 3, 4 };

        Console.WriteLine("���̔z��: ");
        PrintArray(arr);

        QuickSortAlgorithm(arr, 0, arr.Length - 1);

        Console.WriteLine("�\�[�g���ꂽ�z��: ");
        PrintArray(arr);
    }

    private static void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            // �z����p�[�e�B�V������������
            int pivotIndex = Partition(arr, low, high);

            // 2�̃p�[�e�B�V�������ċA�I�Ƀ\�[�g����
            QuickSortAlgorithm(arr, low, pivotIndex - 1);
            QuickSortAlgorithm(arr, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // �s�{�b�g��I���i�����ł͔z��̍Ō�̗v�f�j

        int i = low - 1; // i�̏����l��ݒ�

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                Swap(arr, i, j); // �v�f����������
            }
        }

        Swap(arr, i + 1, high); // �s�{�b�g�𐳂����ʒu�Ɉړ�����
        return i + 1; // �s�{�b�g�̃C���f�b�N�X��Ԃ�
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
