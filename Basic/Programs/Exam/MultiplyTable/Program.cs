using System;

namespace MultiplyTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string stringNum = num.ToString();

            for (int i = 1; i <= int.Parse(stringNum[2].ToString()); i++)
            {
                for (int j = 1; j <= int.Parse(stringNum[1].ToString()); j++)
                {
                    for (int k = 1; k <= int.Parse(stringNum[0].ToString()); k++)
                    {
                        Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                    }
                }
            }
        }
    }
}
