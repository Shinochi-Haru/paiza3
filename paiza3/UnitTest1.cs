using System;
using System.Collections.Generic;

public class AdjacencyList
{
    private List<List<int>> adjacencyList;
    private int numVertices;

    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int numVertices = int.Parse(input[0]);
        int numEdges = int.Parse(input[1]);

        AdjacencyList adjacencyList = new AdjacencyList(numVertices);

        for (int i = 0; i < numEdges; i++)
        {
            string[] edgeInput = Console.ReadLine().Split();
            int source = int.Parse(edgeInput[0]) - 1;
            int destination = int.Parse(edgeInput[1]) - 1;

            adjacencyList.AddEdge(source, destination);
        }

        // —×ÚƒŠƒXƒg‚Ìo—Í
        for (int i = 0; i < numVertices; i++)
        {
            foreach (int neighbor in adjacencyList.GetNeighbors(i))
            {
                Console.Write(neighbor + 1);
            }
            Console.WriteLine();
        }
    }

    public AdjacencyList(int numVertices)
    {
        this.numVertices = numVertices;
        adjacencyList = new List<List<int>>(numVertices);

        for (int i = 0; i < numVertices; i++)
        {
            adjacencyList.Add(new List<int>());
        }
    }

    public void AddEdge(int source, int destination)
    {
        adjacencyList[source].Add(destination);
        adjacencyList[destination].Add(source);
    }

    public void RemoveEdge(int source, int destination)
    {
        adjacencyList[source].Remove(destination);
        adjacencyList[destination].Remove(source);
    }

    public bool HasEdge(int source, int destination)
    {
        return adjacencyList[source].Contains(destination);
    }

    public List<int> GetNeighbors(int vertex)
    {
        return adjacencyList[vertex];
    }
}
