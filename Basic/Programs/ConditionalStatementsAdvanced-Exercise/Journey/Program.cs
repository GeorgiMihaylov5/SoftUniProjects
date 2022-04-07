using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = string.Empty;
            string typeJourney = string.Empty;

            if (budget <= 100)
            {
                place = "Bulgaria";
                if (season == "summer")
                {
                    budget = budget * 30 / 100;
                    typeJourney = "Camp";
                }
                else if (season == "winter")
                {
                    budget = budget * 70 / 100;
                    typeJourney = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                place = "Balkans";
                if (season == "summer")
                {
                    budget = budget * 40 / 100;
                    typeJourney = "Camp";
                }
                else if (season == "winter")
                {
                    budget = budget * 80 / 100;
                    typeJourney = "Hotel";
                }
            }
            else
            {
                place = "Europe";
                budget = budget * 90 / 100;
                typeJourney = "Hotel";
            }

            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{typeJourney} - {budget:f2}");
        }
    }
}
