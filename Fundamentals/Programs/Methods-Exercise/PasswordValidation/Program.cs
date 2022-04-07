using System;
using System.Linq;
using System.Collections.Generic;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            Validation(password);
        }

        static bool PasswordLenght(string password)
        {
            if(password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool Format(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if(!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            return true;
        }
        static bool HaveTwoDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if(char.IsDigit(password[i]))
                {
                    counter++;
                }
            }
            if (counter >= 2)
                return true;
            else
                return false;
        }
        static void Validation(string password)
        {
            bool passwordLenght = PasswordLenght(password);
            bool format = Format(password);
            bool digits = HaveTwoDigits(password);
            if (passwordLenght && format && digits)
            {
                Console.WriteLine("Password is valid");
                return;
            }
            else
            {
                if (!passwordLenght)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                }
                if(!format)
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
                if(!digits)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }
    }
}
