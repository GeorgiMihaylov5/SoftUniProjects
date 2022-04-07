using System;

namespace CleverLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMachine = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            int toysCount = 0;
            double moneyForBD = 0;
            double sum = 0;

            for (int i = 1; i <= age; i++)
            {
                if(i%2==0)
                {
                    moneyForBD += 10;
                    sum += moneyForBD;
                    sum--;
                }
                else
                {
                    toysCount++;
                }
            }

            sum += toysCount * toysPrice;

            if(sum>=washMachine)
                Console.WriteLine($"Yes! {sum-washMachine:f2}" );
            else
                Console.WriteLine($"No! {washMachine-sum:f2}");
        }
    }
}
