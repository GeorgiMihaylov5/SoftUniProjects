using System;
using System.Collections.Generic;
using System.Linq;

namespace Beaver_at_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            int rowsBeaver = 0;
            int colsBeaver = 0;
            int counter = 0;
            Stack<char> stack = new Stack<char>();

            for (int rows = 0; rows < n; rows++)
            {
                char[] rowsInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int cols = 0; cols < rowsInput.Length; cols++)
                {
                    matrix[rows, cols] = rowsInput[cols];
                    char letter = rowsInput[cols];

                    if (rowsInput[cols] == 'B')
                    {
                        rowsBeaver = rows;
                        colsBeaver = cols;
                    }
                    else if (char.IsLower(letter))
                    {
                        counter++;
                    }
                }
            }

            string commands = Console.ReadLine();
            while (commands != "end")
            {
                if (counter == 0)
                {
                    break;
                }
                if (commands == "up")
                {
                    if (IsInRange(matrix, rowsBeaver - 1, colsBeaver))
                    {
                        rowsBeaver -= 1;
                        char nextPosition = matrix[rowsBeaver, colsBeaver];
                        if (char.IsLower(nextPosition))
                        {
                            stack.Push(nextPosition);
                            counter--;
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver + 1, colsBeaver] = '-';
                        }
                        else if (nextPosition == 'F')
                        {
                            if (rowsBeaver > 0)
                            {
                                matrix[0, colsBeaver] = 'B';
                                matrix[rowsBeaver + 1, colsBeaver] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                rowsBeaver = 0;
                            }
                            else
                            {
                                char letter = matrix[n - 1, colsBeaver];
                                matrix[n - 1, colsBeaver] = 'B';
                                matrix[rowsBeaver + 1, colsBeaver] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                rowsBeaver = n - 1;
                                if (char.IsLower(letter))
                                {
                                    stack.Push(letter);
                                    //counter--;
                                }
                            }
                        }
                        else
                        {
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver + 1, colsBeaver] = '-';
                        }
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (commands == "down")
                {
                    if (IsInRange(matrix, rowsBeaver + 1, colsBeaver))
                    {
                        rowsBeaver += 1;
                        char nextPositon = matrix[rowsBeaver, colsBeaver];
                        if (char.IsLower(nextPositon))
                        {
                            stack.Push(nextPositon);
                            counter--;
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver - 1, colsBeaver] = '-';
                        }
                        else if (nextPositon == 'F')
                        {
                            if (rowsBeaver < n)
                            {
                                matrix[n - 1, colsBeaver] = 'B';
                                matrix[rowsBeaver - 1, colsBeaver] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                rowsBeaver = n - 1;
                            }
                            else
                            {
                                char letter = matrix[0, colsBeaver];
                                matrix[0, colsBeaver] = 'B';
                                matrix[rowsBeaver - 1, colsBeaver] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                rowsBeaver = 0;
                                if (char.IsLower(letter))
                                {
                                    stack.Push(letter);
                                    //counter--;
                                }
                            }
                        }
                        else
                        {
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver - 1, colsBeaver] = '-';
                        }
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (commands == "left")
                {
                    if (IsInRange(matrix, rowsBeaver, colsBeaver - 1))
                    {
                        colsBeaver -= 1;
                        char nextPosition = matrix[rowsBeaver, colsBeaver];
                        if (char.IsLower(nextPosition))
                        {
                            stack.Push(nextPosition);
                            counter--;
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver, colsBeaver + 1] = '-';
                        }
                        else if (nextPosition == 'F')
                        {
                            if (colsBeaver > 0)
                            {
                                matrix[rowsBeaver, 0] = 'B';
                                matrix[rowsBeaver, colsBeaver + 1] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                colsBeaver = 0;
                            }
                            else
                            {
                                char letter = matrix[rowsBeaver, n - 1];
                                matrix[rowsBeaver, n - 1] = 'B';
                                matrix[rowsBeaver, colsBeaver + 1] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                colsBeaver = n - 1;
                                if (char.IsLower(letter))
                                {
                                    stack.Push(letter);
                                    //counter--;
                                }
                            }
                        }
                        else
                        {
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver, colsBeaver + 1] = '-';
                        }
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (commands == "right")
                {
                    if (IsInRange(matrix, rowsBeaver, colsBeaver + 1))
                    {
                        colsBeaver += 1;
                        char nextPosition = matrix[rowsBeaver, colsBeaver];
                        if (char.IsLower(nextPosition))
                        {
                            stack.Push(nextPosition);
                            counter--;
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver, colsBeaver - 1] = '-';
                        }
                        else if (nextPosition == 'F')
                        {
                            if (rowsBeaver < n)
                            {
                                matrix[rowsBeaver, n - 1] = 'B';
                                matrix[rowsBeaver, colsBeaver - 1] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                colsBeaver = n - 1;
                            }
                            else
                            {
                                char letter = matrix[rowsBeaver, 0];
                                matrix[rowsBeaver, 0] = 'B';
                                matrix[rowsBeaver, colsBeaver - 1] = '-';
                                matrix[rowsBeaver, colsBeaver] = '-';
                                colsBeaver = 0;
                                if (char.IsLower(letter))
                                {
                                    stack.Push(letter);
                                    //counter--;
                                }
                            }
                        }
                        else
                        {
                            matrix[rowsBeaver, colsBeaver] = 'B';
                            matrix[rowsBeaver, colsBeaver - 1] = '-';
                        }
                    }
                    else
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                }

                commands = Console.ReadLine();
            }

            if (counter == 0)
            {
                Console.Write($"The Beaver successfully collect {stack.Count} wood branches: ");
                Console.WriteLine($"{string.Join(", ", stack.OrderBy(x => x))}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {counter} branches left.");
            }
            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    Console.Write($"{matrix[rows, cols]} ");
                }
                Console.WriteLine();
            }
        }

        public static bool IsInRange(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }

    }
}