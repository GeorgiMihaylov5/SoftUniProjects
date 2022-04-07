using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArr = new double[rows][];
            int arrLength = 0;

            for (int i = 0; i < rows; i++)
            {
                jaggedArr[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();

                if (i > 0)
                {
                    arrLength = jaggedArr[i].Length;
                    if (arrLength == jaggedArr[i - 1].Length)
                    {
                        jaggedArr[i - 1] = jaggedArr[i-1].Select(x => x * 2).ToArray();
                        jaggedArr[i] = jaggedArr[i].Select(x => x * 2).ToArray();
                    }
                    else
                    {
                        jaggedArr[i] = jaggedArr[i].Select(x => x / 2).ToArray();
                        jaggedArr[i - 1] = jaggedArr[i-1].Select(x => x / 2).ToArray();
                    }

                }
                
                
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                var commands = input.Split().ToArray();
                string command = commands[0];

                if (command == "Add")
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    int value = int.Parse(commands[3]);

                    try
                    {
                        jaggedArr[row][col] += value;
                    }
                    catch (Exception)
                    {
                        
                    }
                }
                else if (command == "Subtract")
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    int value = int.Parse(commands[3]);

                    try
                    {
                        jaggedArr[row][col] -= value;
                    }
                    catch (Exception)
                    {

                    }
                }

                input = Console.ReadLine();
            }
            Print(jaggedArr);
        }
        static void Print(double[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
