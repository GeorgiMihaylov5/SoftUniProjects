using System;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                var row = Console.ReadLine();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int maxAttacksCount = int.MinValue;
            int removedKnightsCount = 0;

            while (maxAttacksCount != 0)
            {
                maxAttacksCount = int.MinValue;
                int knightIndexRow = 0, knightIndexCol = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        int currentAttacksCount = 0;

                        if (matrix[row, col] == 'K')
                        {
                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                            {
                                currentAttacksCount++;
                            }
                            if (row - 2 >= 0 && col + 1 < n && matrix[row - 2, col + 1] == 'K')
                            {
                                currentAttacksCount++;
                            }
                            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                            {
                                currentAttacksCount++;
                            }
                            if (row - 1 >= 0 && col + 2 < n && matrix[row - 1, col + 2] == 'K')
                            {
                                currentAttacksCount++;
                            }
                            if (row + 1 < n && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                            {
                                currentAttacksCount++;
                            }
                            if (row + 1 < n && col + 2 < n && matrix[row + 1, col + 2] == 'K')
                            {
                                currentAttacksCount++;
                            }
                            if (row + 2 < n && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                            {
                                currentAttacksCount++;
                            }
                            if (row + 2 < n && col + 1 < n && matrix[row + 2, col + 1] == 'K')
                            {
                                currentAttacksCount++;
                            }

                            if (currentAttacksCount > maxAttacksCount)
                            {
                                maxAttacksCount = currentAttacksCount;
                                knightIndexRow = row;
                                knightIndexCol = col;
                            }
                        }
                    }
                }
                if (maxAttacksCount > 0)
                {
                    removedKnightsCount++;
                    matrix[knightIndexRow, knightIndexCol] = '0';
                }
            }
            Console.WriteLine(removedKnightsCount);
        }

        static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
