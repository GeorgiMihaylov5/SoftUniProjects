using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string num = Console.ReadLine();

            for (int i = 0; i < num.Length; i++)
            {
                sum += int.Parse(num[i].ToString());
            }
            Console.WriteLine(sum);
        }
    }
}
