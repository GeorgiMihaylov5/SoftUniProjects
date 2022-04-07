using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[arrSize[0], arrSize[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var inputChar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputChar[j];
                }
            }

            int x = 3, y = 3;
            int maxSum = 0;
            int rowIndex = 0, colIndex = 0;

            for (int row = 0; row <= matrix.GetLength(0) - x; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - y; col++)
                {
                    int currentSum = 0;
                    for (int i = row; i < row + x; i++)
                    {
                        for (int j = col; j < col + y; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        rowIndex = row;
                        colIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = rowIndex; i < rowIndex + x; i++)
            {
                for (int j = colIndex; j < colIndex + y; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
