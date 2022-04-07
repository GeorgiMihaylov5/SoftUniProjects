using System;

namespace OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string input = Console.ReadLine();
            int count = 0;

            while (input!=book && input!= "No More Books")
            {
                count++;
                input = Console.ReadLine();
            }
            if(input == book)
                Console.WriteLine($"You checked {count} books and found it.");
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {count} books.");
            }
        }
    }
}
