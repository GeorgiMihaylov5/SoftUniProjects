using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string[,] matrix = new string[arrSize[0], arrSize[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var inputMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = inputMatrix[j];
                }
            }

            string eror = "Invalid input!";
            string input = Console.ReadLine();

            while (input.ToUpper() != "END")
            {
                var swapCommand = input.Split().ToArray();

                if (swapCommand.Contains("swap") && swapCommand.Length != 5)
                {
                    Console.WriteLine(eror);
                }
                else
                {
                    int row1 = int.Parse(swapCommand[1]);
                    int col1 = int.Parse(swapCommand[2]);
                    int row2 = int.Parse(swapCommand[3]);
                    int col2 = int.Parse(swapCommand[4]);

                    try
                    {
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(eror);
                    }


                }
                input = Console.ReadLine();

            }
        }
        
    }
}

                 //if (swapCommand.Contains("swap") && swapCommand.Length != 5)
                //{
                //    Console.WriteLine(eror);
                //}
                //else
                //{
                //    int row1 = int.Parse(swapCommand[1]);
                //    int col1 = int.Parse(swapCommand[2]);
                //    int row2 = int.Parse(swapCommand[3]);
                //    int col2 = int.Parse(swapCommand[4]);

                //    if (row1 >= 0 && row1 < arrSize[0] &&
                //        row2 >= 0 && row2 < arrSize[0] &&
                //        col1 >= 0 && col1 < arrSize[1] &&
                //        col2 >= 0 && col2 < arrSize[1])
                //    {
                //        string temp = matrix[row1, col1];
                //        matrix[row1, col1] = matrix[row2, col2];
                //        matrix[row2, col2] = temp;

                //        for (int i = 0; i < matrix.GetLength(0); i++)
                //        {
                //            for (int j = 0; j < matrix.GetLength(1); j++)
                //            {
                //                Console.Write($"{matrix[i, j]} ");
                //            }
                //            Console.WriteLine();
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine(eror);
                //    }              
