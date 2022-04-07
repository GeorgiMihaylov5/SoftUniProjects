using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int simpleNumber = 0;
            int notSimpleNumber = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "stop")
                    break;
                int num = int.Parse(input);

                if (num < 0)
                    Console.WriteLine("Number is negative.");
                else if(num!=0)
                {
                    int saveChanges = notSimpleNumber;
                    int index = 2;

                    while (index!=num)
                    {
                        if (num % index == 0 && index!=1)
                        {
                            notSimpleNumber += num;
                            break;
                        }
                        index++;
                    
                    }
                    if (saveChanges == notSimpleNumber)
                        simpleNumber+=num;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {simpleNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {notSimpleNumber}");

        }
    }
}
