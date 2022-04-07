using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badScoreCount = int.Parse(Console.ReadLine());
            int timesWithBadScore = 0;
            double sumScore = 0.0;
            int examsCount = 0;
            string lastExam = string.Empty;

            while (true)
            {
                if (timesWithBadScore >= badScoreCount)
                {
                    Console.WriteLine($"You need a break, {timesWithBadScore} poor grades.");
                    return;
                }

                string examName = Console.ReadLine();
                if (examName == "Enough")
                    break;

                int score = int.Parse(Console.ReadLine());
                if (score <= 4)
                    timesWithBadScore++;

                sumScore += score;
                examsCount++;
                lastExam = examName;
            }
            Console.WriteLine($"Average score: {sumScore/examsCount:f2}");
            Console.WriteLine($"Number of problems: {examsCount}");
            Console.WriteLine($"Last problem: {lastExam}");
        }
    }
}
