using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyVacation = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            bool haveMoney = false;
            int count = 0;
            int spendingCounter = 0;

            while (spendingCounter < 5)
            {
                if (money >= moneyVacation)
                {
                    haveMoney = true;
                    break;
                }

                string command = Console.ReadLine();
                double currentMoney = double.Parse(Console.ReadLine());

                if (command == "save")
                {
                    money += currentMoney;
                    spendingCounter = 0;
                }
                else if (command == "spend")
                {
                    money -= currentMoney;
                    spendingCounter++;
                    if (money < 0)
                        money = 0;
                }
                count++;
            }
            if (haveMoney)
            {
                Console.WriteLine($"You saved the money for {count} days.");
            }
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(count);
            }
        }
    }
}
