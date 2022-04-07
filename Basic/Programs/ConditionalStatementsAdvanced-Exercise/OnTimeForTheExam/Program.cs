using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {

            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int myHour = int.Parse(Console.ReadLine());
            int myMinutes = int.Parse(Console.ReadLine());

            examMinutes += examHour * 60;
            myMinutes += myHour * 60;

            if (myMinutes > examMinutes)
            {
                Console.WriteLine("Late");

                int difference = myMinutes - examMinutes;
                int hour = difference / 60;
                int minutes = difference % 60;

                if (hour == 0)
                    Console.WriteLine($"{minutes} minutes after the start");
                else
                {
                    if(minutes<10)
                        Console.WriteLine($"{hour}:0{minutes} hours after the start");
                    else
                    {
                        Console.WriteLine($"{hour}:{minutes} hours after the start");
                    }
                }
            }
            else
            {
                int difference = examMinutes - myMinutes;
                int hour = difference / 60;
                int minutes = difference % 60;

                if (hour == 0 && minutes <= 30)
                {
                    Console.WriteLine("On time");
                    if (minutes != 0)
                    {
                        Console.WriteLine($"{minutes} minutes before the start");
                    }
                }
                else
                {
                    Console.WriteLine("Early");

                    if (hour == 0)
                        Console.WriteLine($"{minutes} minutes before the start");
                    else
                    {
                        if (minutes < 10)
                            Console.WriteLine($"{hour}:0{minutes} hours before the start");
                        else
                            Console.WriteLine($"{hour}:{minutes} hours before the start");
                    }
                }
            }
        }
    }
}
