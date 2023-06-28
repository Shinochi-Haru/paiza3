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
                UpdateFloarState();
                break;
            case State.Wall:
                break;
            case State.Goal:
                //UpdateChaseState();
                break;
            case State.Open:
                UpdateOpenState();
                break;
            case State.Close:
                UpdateCloseState();
                break;
        }
        var maze = CreateMaze();
        var bfs = new MazeDfs(maze);
        bfs.Search();
        bfs.DebugPrint(maze);
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
    static void UpdateOpenState()
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
    static void UpdateCloseState()
    {

    }
    public static int[,] CreateMaze()
    {
        return new int[15, 15] {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                {1,0,0,0,1,0,0,0,0,0,0,0,0,0,1},
                {1,1,1,0,1,1,1,0,1,1,1,0,1,0,1},
                {1,0,1,0,0,0,1,0,0,0,1,0,1,0,1},
                {1,0,1,1,1,0,1,1,1,0,1,0,1,1,1},
                {1,0,1,0,0,0,0,0,0,0,1,0,0,0,1},
                {1,0,1,0,1,1,1,1,1,1,1,1,1,0,1},
                {1,0,0,0,0,0,0,0,1,0,1,0,0,0,1},
                {1,1,1,1,1,0,1,0,1,0,1,0,1,1,1},
                {1,0,0,0,1,0,1,0,0,0,1,0,0,0,1},
                {1,0,1,0,1,0,1,1,1,0,1,1,1,1,1},
                {1,0,1,0,1,0,0,0,1,0,1,0,0,0,1},
                {1,0,1,0,1,1,1,0,1,0,1,0,1,0,1},
                {1,0,1,0,0,0,0,0,1,0,0,0,1,0,1},
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
            };
    }

    public class MazeDfs
    {
        private int[,] Maze;            // ���H
        private int[] VisitedArray;     // �K��ϔz��
        private Cell Start;             // ���H�X�^�[�g
        private Cell Goal;              // ���H�S�[��

        // ���H�̉���
        private int MazeWidth
        {
            get { return this.Maze.GetLength(0); }
        }

        // ���H�̍���
        private int MazeHeight
        {
            get { return this.Maze.GetLength(1); }
        }

        // �R���X�g���N�^
        public MazeDfs(int[,] maze)
        {
            this.Maze = maze;
            this.VisitedArray = new int[MazeWidth * MazeHeight];
            this.Start = new Cell(1, 1);
            this.Goal = new Cell(MazeWidth - 2, MazeHeight - 2);
        }

        // �T������
        public void Search()
        {
            var isGoaled = false;
            var queue = new Stack<Cell>();
            queue.Push(Start);

            // �K��ϔz��� -1 �ŏ�����
            VisitedArray = Enumerable.Repeat(-1, VisitedArray.Length).ToArray();
            VisitedArray[ToIndex(Start)] = ToIndex(Start);

            // �T���҂��̃Z�����Ȃ��Ȃ�܂ő�����
            while (queue.Count > 0 && !isGoaled)
            {
                // �T���Ώۂ̃Z�������o��
                var target = queue.Pop();

                // �Ώۂ̃Z������㉺���E�̃Z����T������
                foreach (Direction dir in Enum.GetValues(typeof(Direction)))
                {
                    // ���̒T���Z�����쐬����
                    var nextCell = new Cell(target.X, target.Y);
                    switch (dir)
                    {
                        case Direction.Up:
                            nextCell.Y -= 1;
                            break;
                        case Direction.Right:
                            nextCell.X += 1;
                            break;
                        case Direction.Down:
                            nextCell.Y += 1;
                            break;
                        case Direction.Left:
                            nextCell.X -= 1;
                            break;
                    }
                    // �T�����Z�����͈͓�
                    if (nextCell.X >= 0 && nextCell.Y >= 0 && nextCell.X < MazeWidth && nextCell.Y < MazeHeight)
                    {
                        // ���T���̏ꍇ���ʘH�̏ꍇ�̂݃L���[�ɋl�߂�Ɠ����ɒT���Ϗ��ݒ�
                        if (VisitedArray[ToIndex(nextCell)] < 0
                            && Maze[nextCell.X, nextCell.Y] == Path)
                        {
                            // �T���Ϗ��
                            SetVisited(target, nextCell);
                            if (nextCell.X == Goal.X && nextCell.Y == Goal.Y)
                            {
                                // �T����₪�S�[���̏ꍇ�����ɔ����邽�߂ɒT�������폜���Ĕ�����
                                // console.log('�S�[����������܂����B���߂łƂ� ...');
                                queue.Clear();
                                queue.Push(nextCell);
                                isGoaled = true;
                                break;
                            }
                            else
                            {
                                // �L���[�ɋl�߂�
                                queue.Push(nextCell);
                            }
                        }
                    }
                }
            }
            // �T�����ʂ�z��ɐݒ�
            if (isGoaled)
            {
                SetRoute();
            }
        }

        // �S�[���ւ̃��[�g��2�����z��ɐݒ�
        public void SetRoute()
        {
            // �K��ς̔z�񂩂�S�[���܂ł̃��[�g��ݒ肷��
            var startIndex = ToIndex(Start);
            var goalIndex = ToIndex(Goal);
            var beforeIndex = VisitedArray[goalIndex];
            var route = new List<int>();

            while (beforeIndex >= 0 && beforeIndex != startIndex)
            {
                // �S�[������X�^�[�g�ւ̃��[�g�����ǂ�
                route.Add(beforeIndex);
                beforeIndex = VisitedArray[beforeIndex];
            }

            // �S�[���ւ̃��[�g��ݒ�
            foreach (var index in route)
            {
                var cell = ToCell(index);
                Maze[cell.X, cell.Y] = Route;
            }
        }

        // �K��σf�[�^�̐ݒ���s��
        private void SetVisited(Cell fromCell, Cell toCell)
        {
            var fromIndex = ToIndex(fromCell);
            var toIndex = ToIndex(toCell);
            VisitedArray[toIndex] = fromIndex;
        }

        // Cell��1�����z��̃C���f�b�N�X�ɕϊ�
        private int ToIndex(Cell cell)
        {
            return cell.X + MazeWidth * cell.Y;
        }

        // 1�����z��̃C���f�b�N�X���Z���ɕϊ�
        private Cell ToCell(int index)
        {
            return new Cell(index % MazeWidth, index / MazeWidth);
        }

        // �ʘH�E�Ǐ��
        const int Path = 0;
        const int Wall = 1;
        const int Route = 99;

        // �Z�����
        private struct Cell
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Cell(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        // ����
        private enum Direction
        {
            Up = 0,
            Right = 1,
            Down = 2,
            Left = 3
        }

        // �f�o�b�O�p����
        public void DebugPrint(int[,] maze)
        {
            var text = string.Empty;
            Console.WriteLine($"Width: {maze.GetLength(0)}");
            Console.WriteLine($"Height: {maze.GetLength(1)}");
            for (int y = 0; y < maze.GetLength(1); y++)
            {
                for (int x = 0; x < maze.GetLength(0); x++)
                {
                    if (x == Start.X && y == Start.Y)
                    {
                        text += "S ";
                    }
                    else if (x == Goal.X && y == Goal.Y)
                    {
                        text += " G";
                    }
                    else if (maze[x, y] == Path)
                    {
                        text += "  ";
                    }
                    else if (maze[x, y] == Wall)
                    {
                        text += "##";
                    }
                    else if (maze[x, y] == Route)
                    {
                        text += "..";
                    }
                }
                text += "\r\n";
            }
            Console.WriteLine(text);
        }
    }
}