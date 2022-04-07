using System;

namespace FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string progection = Console.ReadLine();
            string moviePackege = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            double price = 0.0;

            if( progection == "John Wick")
            {
                if(moviePackege == "Drink")
                {
                    price += 12;
                }
                else if(moviePackege == "Popcorn")
                {
                    price += 15;
                }
                else if(moviePackege == "Menu")
                {
                    price += 19;
                }
                price *= ticketsCount;
            }
            else if(progection == "Star Wars")
            {
                if (moviePackege == "Drink")
                {
                    price += 18;
                }
                else if (moviePackege == "Popcorn")
                {
                    price += 25;
                }
                else if (moviePackege == "Menu")
                {
                    price += 30;
                }

                price *= ticketsCount;
                if (ticketsCount >= 4)
                    price -= price * 30 / 100;
            }
            else if(progection == "Jumanji")
            {
                if (moviePackege == "Drink")
                {
                    price += 9;
                }
                else if (moviePackege == "Popcorn")
                {
                    price += 11;
                }
                else if (moviePackege == "Menu")
                {
                    price += 14;
                }
                price *= ticketsCount;

                if (ticketsCount == 2)
                    price -= price * 15 / 100;
            }
            Console.WriteLine($"Your bill is {price:f2} leva.");
        }
    }
}
