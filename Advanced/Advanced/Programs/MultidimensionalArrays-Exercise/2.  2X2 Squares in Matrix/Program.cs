using System;
using System.Linq;

namespace _2.__2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[arrSize[0], arrSize[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var inputChar = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputChar[j];
                }
            }

            int equalCells = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i,j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        equalCells++;
                    }
                }
            }
            Console.WriteLine(equalCells);
        }
    }
}
