using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            string room=Console.ReadLine();
            string rate = Console.ReadLine();
            double pay = 0;

            if(room == "room for one person")
            {
                pay = 18 * (daysCount-1);
            }
            else if(room == "apartment")
            {
                pay = 25 * (daysCount - 1);
                if (daysCount<10)
                {
                    pay -= pay * 30 / 100;
                }
                else if (daysCount < 15)
                {
                    pay -= pay * 35 / 100;
                }
                else
                {
                    pay -= pay * 50 / 100;
                }
            }
            else if(room =="president apartment")
            {
                pay = 35 * (daysCount - 1);
                if (daysCount < 10)
                {
                    pay -= pay * 10 / 100;
                }
                else if (daysCount < 15)
                {
                    pay -= pay * 15 / 100;
                }
                else
                {
                    pay -= pay * 20 / 100;
                }
            }

            if(rate=="positive")
            {
                pay += pay * 25 / 100;
            }
            else if(rate=="negative")
            {
                pay -= pay * 10 / 100;
            }
            Console.WriteLine($"{pay:f2}");
        }
    }
}
