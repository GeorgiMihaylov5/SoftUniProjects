using System;

namespace BookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            double pagesForOneHour = double.Parse(Console.ReadLine());
            int daysForRead = int.Parse(Console.ReadLine());

            double allTimeForRead = bookPages / pagesForOneHour;
            double hoursOnDay = allTimeForRead / daysForRead;
            Console.WriteLine(hoursOnDay);
        }
    }
}
