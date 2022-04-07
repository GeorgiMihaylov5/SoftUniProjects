using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int otherFood = int.Parse(Console.ReadLine());
            Console.WriteLine(dogFood*2.5+otherFood*4 +" lv.");
        }
    }
}
