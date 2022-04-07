using System;

namespace GrandpaStavri
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            double allRakia = 0;
            double allDegrees = 0;

            for (int i = 0; i < daysCount; i++)
            {
                double quantityRakia = double.Parse(Console.ReadLine());
                double degreesRakia = double.Parse(Console.ReadLine());

                allRakia += quantityRakia;
                allDegrees += quantityRakia * degreesRakia;
            }

            allDegrees = allDegrees / allRakia;

            Console.WriteLine($"Liter: {allRakia:f2}");
            Console.WriteLine($"Degrees: {allDegrees:f2}");

            if(allDegrees < 38)
                Console.WriteLine("Not good, you should baking!");
            else if(allDegrees <= 42)
                Console.WriteLine("Super!");   
            else if(allDegrees > 42)
                Console.WriteLine("Dilution with distilled water!");
        }
    }
}
