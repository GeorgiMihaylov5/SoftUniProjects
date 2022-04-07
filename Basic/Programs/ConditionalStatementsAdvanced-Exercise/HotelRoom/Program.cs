using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            double apartamentPrice = 0;
            double studioPrice = 0;

            if(month == "May" || month == "October")
            {
                apartamentPrice = 65 * nightCount;
                studioPrice = 50 * nightCount;

                if(nightCount>7 && nightCount<=14)
                {
                    studioPrice -= studioPrice * 5 / 100;
                }
                else if(nightCount>14)
                {
                    studioPrice -= studioPrice * 30 / 100;
                }
            }
            else if(month == "June" || month == "September")
            {
                apartamentPrice = 68.70 * nightCount;
                studioPrice = 75.20 * nightCount;

                if (nightCount > 14)
                {
                    studioPrice -= studioPrice * 20 / 100;
                }
            }
            else if(month == "July" || month == "August")
            {
                apartamentPrice = 77 * nightCount;
                studioPrice = 76 * nightCount;
            }

            if(nightCount>14)
            {
                apartamentPrice -= apartamentPrice * 10 / 100;
            }
            Console.WriteLine($"Apartment: {apartamentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
