using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    enum State
    {
        Floar,
        Wall,
        Start,
        Goal,
        Open,
        Close
    }
    static private State _currentState;
    static int[,] grid = new int[5, 5];
    static void Main()
    {
        _currentState = State.Start;

        switch (_currentState)
        {
            case State.Start:
                UpdateStartState();
                break;
            case State.Floar:

                break;
            case State.Wall:
                //UpdateChaseState();
                break;
            case State.Goal:
                //UpdateChaseState();
                break;
            case State.Open:
                //UpdateChaseState();
                break;
            case State.Close:
                //UpdateChaseState();
                break;
        }


        // Fill the grid with numbers
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                grid[row, col] = (row * 5) + (col + 1);
            }
        }

        // Display the grid
        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write(grid[row, col] + "\t");
            }
            Console.WriteLine();
        }

        // C#のコンソールに5×5のグリットを出力したい
        Console.ReadLine();
    }

    static void UpdateStartState()
    {
        if (_currentState == State.Floar)
        {
            _currentState = State.Open;
        }
        else if (_currentState == State.Wall)
        {
            _currentState = State.Close;
        }
    }

    static void UpdateFloarState()
    {
        if (_currentState == State.Wall)
        {
            _currentState = State.Close;
        }
        else if (_currentState == State.Floar)
        {
            _currentState = State.Open;
        }
    }
}