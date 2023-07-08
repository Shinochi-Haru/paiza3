using System;
using System.Linq;
public class AdjacencyMatrix
{
    private int[,] matrix;
    private int numVertices;

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int numVertices = int.Parse(input[0]);
        int numEdges = int.Parse(input[1]);

        AdjacencyMatrix matrix = new AdjacencyMatrix(numVertices);

        for (int i = 0; i < numEdges; i++)
        {
            string[] edgeInput = Console.ReadLine().Split();
            int source = int.Parse(edgeInput[0]) - 1;
            int destination = int.Parse(edgeInput[1]) - 1;

            matrix.AddEdge(source, destination);
        }

        // 隣接行列の出力
        for (int i = 0; i < numVertices; i++)
        {
            for (int j = 0; j < numVertices; j++)
            {
                Console.Write(matrix.HasEdge(i, j) ? "1" : "0");
            }
            Console.WriteLine();
        }
    }
    public AdjacencyMatrix(int numVertices)
    {
        this.numVertices = numVertices;
        matrix = new int[numVertices, numVertices];
    }

    public void AddEdge(int source, int destination)
    {
        // 無向グラフの場合、両方の方向にエッジを追加する
        matrix[source, destination] = 1;
        matrix[destination, source] = 1;
    }

    public void RemoveEdge(int source, int destination)
    {
        // エッジを削除する
        matrix[source, destination] = 0;
        matrix[destination, source] = 0;
    }

    public bool HasEdge(int source, int destination)
    {
        // エッジが存在するかどうかを判定する
        return matrix[source, destination] == 1;
    }
}
