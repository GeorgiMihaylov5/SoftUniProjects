using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[arrSize[0], arrSize[1]];

            string snake = Console.ReadLine();

            int snakeIndex = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (snakeIndex >= snake.Length)
                        {
                            snakeIndex = 0;
                        }
                        matrix[i, j] = snake[snakeIndex];
                        snakeIndex++;
                    }
                }
                else
                {
                    for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                    {
                        if (snakeIndex >= snake.Length)
                        {
                            snakeIndex = 0;
                        }
                        matrix[i, j] = snake[snakeIndex];
                        snakeIndex++;
                    }
                }
            }
            Print(matrix);
        }
        static void Print(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
