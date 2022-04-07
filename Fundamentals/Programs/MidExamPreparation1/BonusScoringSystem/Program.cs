
using System;

namespace BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxAttendances = 0;

            for (int i = 0; i < studentCount; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double total = (double)attendances / lecturesCount * (5 + initialBonus);
                
                if(maxAttendances < attendances)
                {
                    maxAttendances = attendances;
                    maxBonus = total;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
