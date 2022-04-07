using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double allSeats = 0;
            int studentSeats = 0;
            int kidSeats = 0;
            int standartSeats = 0;

            string movieName = Console.ReadLine();
            while (movieName!="Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                double seatsCount = 0;

                string tickets = string.Empty;
                while (tickets != "End" && seatsCount < freeSeats)
                {
                    tickets = Console.ReadLine();
                    if (tickets == "standard")
                    {
                        standartSeats++;
                        allSeats++;
                        seatsCount++;
                    }
                    else if(tickets == "kid")
                    {
                        kidSeats++;
                        allSeats++;
                        seatsCount++;
                    }
                    else if(tickets == "student")
                    {
                        studentSeats++;
                        allSeats++;
                        seatsCount++;
                    }
                }

                Console.WriteLine($"{movieName} - {seatsCount/freeSeats*100:f2}% full.");
                movieName = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {allSeats}");
            Console.WriteLine($"{studentSeats/allSeats*100:f2}% student tickets.");
            Console.WriteLine($"{standartSeats / allSeats * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidSeats / allSeats * 100:f2}% kids tickets.");

        }
    }
}
