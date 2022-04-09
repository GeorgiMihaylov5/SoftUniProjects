using System;
using System.Collections.Generic;
using System.Linq;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char [,] matrix = new char[n, n];
            Stack<char> woodBranches = new Stack<char>();
            int counter = 0;
            int beaverRow = 0;
            int beaverCol = 0;

            for (int i = 0; i < n; i++)
            {
                char[] input = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                    if (char.IsLower(input[j]))
                    {
                        counter++;
                    }
                    if (input[j] == 'B')
                    {
                        beaverRow = i;
                        beaverCol = j;
                    }
                }
            }

            string move = Console.ReadLine();
            while (move != "end")
            {
                if (move == "up")
                {
                    if (beaverRow == 0)
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.Pop();
                        
                        }
                    }
                    else
                    {
                        var next = matrix[beaverRow - 1, beaverCol];

                        if (char.IsLower(next))
                        {
                            woodBranches.Push(next);
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow - 1, beaverCol] = 'B';
                            counter--;
                        }
                        else if (next == '-')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow - 1, beaverCol] = 'B';
                        }
                        else if(next == 'F')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow - 1, beaverCol] = '-';

                            if (beaverRow - 1 == 0)
                            {
                                if (char.IsLower(matrix[n - 1, beaverCol]))
                                {
                                    woodBranches.Push(matrix[n - 1, beaverCol]);
                                    counter--;
                                }
                                beaverRow = n - 1;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                            else
                            {
                                if (char.IsLower(matrix[0, beaverCol]))
                                {
                                    woodBranches.Push(matrix[0, beaverCol]);
                                    counter--;
                                }
                                beaverRow = 0;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                            
                        }
                    }
                }
                else if (move == "down")
                {
                    if (beaverRow == n - 1)
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.Pop();
                        }
                    }
                    else
                    {
                        var next = matrix[beaverRow + 1, beaverCol];

                        if (char.IsLower(next))
                        {
                            woodBranches.Push(next);
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow + 1, beaverCol] = 'B';
                            counter--;
                        }
                        else if (next == '-')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow + 1, beaverCol] = 'B';
                        }
                        else if (next == 'F')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow + 1, beaverCol] = '-';
                            
                            if (beaverRow + 1 == 0)
                            {
                                if (char.IsLower(matrix[0, beaverCol]))
                                {
                                    woodBranches.Push(matrix[0, beaverCol]);
                                    counter--;
                                }
                                beaverRow = 0;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                            else
                            {
                                if (char.IsLower(matrix[n - 1, beaverCol]))
                                {
                                    woodBranches.Push(matrix[n - 1, beaverCol]);
                                    counter--;
                                }

                                beaverRow = n - 1;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                        }
                    }
                }
                else if (move == "right")
                {
                    if (beaverCol == n - 1)
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.Pop();
                        }
                    }
                    else
                    {
                        var next = matrix[beaverRow, beaverCol + 1];

                        if (char.IsLower(next))
                        {
                            woodBranches.Push(next);
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol + 1] = 'B';
                            counter--;
                        }
                        else if (next == '-')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol + 1] = 'B';
                        }
                        else if (next == 'F')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol + 1] = '-';
                            
                            if (beaverCol + 1 == 0)
                            {
                                if (char.IsLower(matrix[beaverRow, 0]))
                                {
                                    woodBranches.Push(matrix[beaverRow, 0]);
                                    counter--;
                                }
                                beaverCol = 0;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                            else
                            {
                                if (char.IsLower(matrix[beaverRow, n - 1]))
                                {
                                    woodBranches.Push(matrix[beaverRow, n - 1]);
                                    counter--;
                                }
                                beaverCol = n - 1;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                        }
                    }
                }
                else if (move == "left")
                {
                    if (beaverCol == 0)
                    {
                        if (woodBranches.Count > 0)
                        {
                            woodBranches.Pop();
                        }
                    }
                    else
                    {
                        var next = matrix[beaverRow, beaverCol - 1];

                        if (char.IsLower(next))
                        {
                            woodBranches.Push(next);
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol - 1] = 'B';
                            counter--;
                        }
                        else if (next == '-')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol - 1] = 'B';
                        }
                        else if (next == 'F')
                        {
                            matrix[beaverRow, beaverCol] = '-';
                            matrix[beaverRow, beaverCol - 1] = '-';

                            if (beaverCol - 1 == 0)
                            {
                                if (char.IsLower(matrix[beaverRow, n - 1]))
                                {
                                    woodBranches.Push(matrix[beaverRow, n - 1]);
                                    counter--;
                                }
                                beaverCol = n - 1;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                            else
                            {
                                if (char.IsLower(matrix[beaverRow, 0]))
                                {
                                    woodBranches.Push(matrix[beaverRow, 0]);
                                    counter--;
                                }
                                beaverCol = 0;
                                matrix[beaverRow, beaverCol] = 'B';
                            }
                        }
                    }
                }
                Print(n, matrix);

                move = Console.ReadLine();
            }
            if (counter > 0)
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {counter} branches left.");
            }
            else
            {
                Console.WriteLine($"The Beaver successfully collect {woodBranches.Count} wood branches: {string.Join(", ", woodBranches.OrderBy(x => x))}.");
            }

            Print(n, matrix);
        }
        static void Print(int n, char[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
