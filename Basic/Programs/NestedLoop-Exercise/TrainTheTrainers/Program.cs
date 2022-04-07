using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int teachers = int.Parse(Console.ReadLine());
            double averageEvaluation = 0.0;
            int counter = 0;

            string presentation = Console.ReadLine();
            while (presentation!="Finish")
            {
                double currentAverageEvaluation = 0;
                for (int i = 0; i < teachers; i++)
                {
                    double evaluation = double.Parse(Console.ReadLine());
                    currentAverageEvaluation += evaluation;
                }

                counter++;
                averageEvaluation += currentAverageEvaluation / teachers;
                Console.WriteLine($"{presentation} - {currentAverageEvaluation / teachers:f2}.");
                presentation = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {averageEvaluation/counter:f2}.");
        }
    }
}
