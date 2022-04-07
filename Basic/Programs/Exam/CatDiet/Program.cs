using System;

namespace CatDiet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fatPercent = int.Parse(Console.ReadLine());
            double proteinPercent = int.Parse(Console.ReadLine());
            double carbohydratesPercent = int.Parse(Console.ReadLine());
            double allCalories = int.Parse(Console.ReadLine());
            double waterPercent = int.Parse(Console.ReadLine());

            double fatGrams = (allCalories * fatPercent / 100.0) / 9.0;
            double proteinGrams = (allCalories * proteinPercent / 100.0) / 4.0;
            double carbohydratesGrams = (allCalories * carbohydratesPercent / 100.0) / 4.0;

            double grams = fatGrams + proteinGrams + carbohydratesGrams;

            double caloriesForGram = allCalories / grams;

            waterPercent = 100 - waterPercent;

            double result = caloriesForGram * waterPercent / 100.0;

            Console.WriteLine($"{result:f4}");
        }
    }
}
