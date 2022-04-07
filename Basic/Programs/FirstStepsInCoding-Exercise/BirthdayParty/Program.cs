using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomRent = double.Parse(Console.ReadLine());

            double cakePrice = roomRent * 20 / 100;
            double drinksPrice =cakePrice- (cakePrice * 45 / 100);
            double animatorPrice = roomRent * 1 / 3;
            double sum = roomRent + cakePrice + drinksPrice + animatorPrice;

            Console.WriteLine(sum);
        }
    }
}
