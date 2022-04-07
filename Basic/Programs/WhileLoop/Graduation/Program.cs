using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades =0;
            int excludedTimes = 0;
            double sum = 0;

            while (grades < 12 && excludedTimes < 2) 
            {
                double evaluation = double.Parse(Console.ReadLine());
                if (evaluation < 4)
                {
                    excludedTimes++;
                    if (excludedTimes < 2)
                        grades++;
                    continue;
                }
                sum += evaluation;
                grades++;
            }
            if (excludedTimes>=2)
                Console.WriteLine($"{name} has been excluded at {grades} grade");
            else
                Console.WriteLine($"{name} graduated. Average grade: {sum/grades:f2}");
        }
    }
}
