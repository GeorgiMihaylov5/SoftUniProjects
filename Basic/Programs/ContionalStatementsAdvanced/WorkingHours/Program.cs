using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if(day=="Sunday")
                Console.WriteLine("closed");
            else
            {
                if(hours>=10 && hours<=18)
                    Console.WriteLine("open");
                else
                    Console.WriteLine("closed");
            }
        }
    }
}
