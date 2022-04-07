using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            byte counter = 1;

            while (true)
            {  
                string password = Console.ReadLine();
                string verify = string.Join("", username.Reverse());

                if(password == verify)
                {
                    break;
                }

                if (counter == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                counter++;
                Console.WriteLine("Incorrect password. Try again.");
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
