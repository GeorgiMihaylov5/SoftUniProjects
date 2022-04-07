using System;

namespace MakeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());
            Console.WriteLine($"The architect {name} will need {3*countOfProjects} hours to complete {countOfProjects} project/s.");
        }
    }
}
