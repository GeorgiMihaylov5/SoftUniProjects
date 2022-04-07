using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int termOfDeposit = int.Parse(Console.ReadLine());
            double yearsPercent = double.Parse(Console.ReadLine());

            //double result = depositSum + (termOfDeposit * (depositSum * yearsPercent / 100) / 12);

            double interest = depositSum * yearsPercent/100;
            double interestForMonth = interest / 12;
            double sum = depositSum + (termOfDeposit * interestForMonth);
            Console.WriteLine(sum);
        }
    }
}
