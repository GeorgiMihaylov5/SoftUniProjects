using System;

namespace SantasHoliday
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string evaluation = Console.ReadLine();
            daysCount--;

            double percent = 0;
            double allSum = 0;
            double roomPrice = 0;
            
            if(room == "room for one person")
            {
                roomPrice = 18;
            }
            else if(room == "apartment")
            {
                if (daysCount < 10)
                {
                    percent = 30;
                }
                else if (daysCount <= 15)
                {
                    percent = 35;
                }
                else if (daysCount > 15)
                {
                    percent = 50;
                }
                roomPrice = 25;
            }
            else if(room == "president apartment")
            {
                if (daysCount < 10)
                {
                    percent = 10;
                }
                else if (daysCount <= 15)
                {
                    percent = 15;
                }
                else if (daysCount > 15)
                {
                    percent = 20;
                }
                roomPrice = 35;
            }

            allSum = daysCount * roomPrice;
            if(percent!=0)
            {
                allSum -= allSum * percent / 100;
            }

            if(evaluation == "positive")
            {
                allSum += allSum * 25 / 100;
            }
            else if(evaluation == "negative")
            {
                allSum -= allSum * 10 / 100;
            }

            Console.WriteLine($"{allSum:f2}");

        }
    }
}
