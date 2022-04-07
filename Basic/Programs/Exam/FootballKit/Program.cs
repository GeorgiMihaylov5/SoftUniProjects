using System;

namespace FootballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double needMoney = double.Parse(Console.ReadLine());

            double shorts = tshirtPrice * 75 / 100;
            double socks = shorts * 20 / 100;

            double shoes = (tshirtPrice + shorts) * 2;

            double money = tshirtPrice + shorts + socks + shoes;
            money -= money * 15 / 100;

            if(money < needMoney)
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {needMoney-money:f2} lv. more.");
            }
            else
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {money:f2} lv.");
            }
        }
    }
}
