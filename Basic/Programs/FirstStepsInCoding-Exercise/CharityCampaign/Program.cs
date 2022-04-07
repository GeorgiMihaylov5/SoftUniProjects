using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDays = int.Parse(Console.ReadLine());
            int countOfEmployees = int.Parse(Console.ReadLine());
            int countOfCakes = int.Parse(Console.ReadLine());
            int countOfWaffles = int.Parse(Console.ReadLine());
            int countOfPancakes = int.Parse(Console.ReadLine());

            double sum = (countOfCakes * 45 + countOfWaffles * 5.8 + countOfPancakes * 3.2) * countOfEmployees;
            double allSum = sum * countOfDays;
            double sumAfterCosts = allSum - (allSum * 1 / 8);

            Console.WriteLine(sumAfterCosts);
        }
    }
}
