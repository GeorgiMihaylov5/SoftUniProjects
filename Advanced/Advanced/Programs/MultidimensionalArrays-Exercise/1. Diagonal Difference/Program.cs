using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += matrix[i, i];
                secondaryDiagonalSum += matrix[i, n - i - 1];
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum-secondaryDiagonalSum));
        }
    }
}
