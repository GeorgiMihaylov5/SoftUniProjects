using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "NoMoreMoney")
                {
                    break;
                }
                double increase = double.Parse(input);

                if(increase<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                sum += increase;
                Console.WriteLine($"Increase: {increase:f2}");
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
