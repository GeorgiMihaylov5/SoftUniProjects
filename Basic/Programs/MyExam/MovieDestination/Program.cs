using System;

namespace MovieDestination
{
    class Program
    {
        static void Main(string[] args)
        {
            double buget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int dayCount = int.Parse(Console.ReadLine());
            double price = 0;

            if(season == "Summer")
            {
                if(destination == "Dubai")
                {
                    price += 40000;
                }
                else if(destination == "Sofia")
                {
                    price += 12500;

                }
                else if(destination == "London")
                {
                    price += 20250;
                }
                price *= dayCount;
            }
            else if(season == "Winter")
            {
                if (destination == "Dubai")
                {
                    price += 45000;
                }
                else if (destination == "Sofia")
                {
                    price += 17000;
                }
                else if (destination == "London")
                {
                    price += 24000;
                }
                price *= dayCount;
            }

            if (destination == "Dubai")
                price -= price * 30 / 100;
            else if (destination == "Sofia")
                price += price * 25 / 100;

            if(price>buget)
                Console.WriteLine($"The director needs {price-buget:f2} leva more!");
            else
                Console.WriteLine($"The budget for the movie is enough! We have {buget-price:f2} leva left!");
        }
    }
}
