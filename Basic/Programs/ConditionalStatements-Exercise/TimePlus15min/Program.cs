using System;

namespace TimePlus15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;

            if (minutes >= 60)
            {
                hours++;
                minutes = minutes % 60;
            }
            if (hours >= 24)
            {
                hours = hours % 24;
            }

            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}
