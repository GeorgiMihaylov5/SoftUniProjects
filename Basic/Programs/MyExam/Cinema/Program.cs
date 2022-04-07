using System;

namespace Cinema
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int capacity = int.Parse(Console.ReadLine());
    //        int allPeople = 0;
    //        int price = 0;
    //        string input = Console.ReadLine();

    //        while (input != "Movie time!")
    //        {
    //            int newPeople = int.Parse(input);

    //            if (newPeople % 3 == 0)
    //            {
    //                price += newPeople * 5 - 5;
    //            }
    //            else
    //                price += newPeople * 5;

    //            allPeople += newPeople;

    //            //input = Console.ReadLine();

    //            if (capacity <= allPeople && input!= "Movie time!")
    //            {
    //                Console.WriteLine("The cinema is full.");
    //                allPeople = capacity;
    //                break;
    //            }

    //            input = Console.ReadLine();
    //        }

    //        if (input == "Movie time!")
    //            Console.WriteLine($"There are {capacity-allPeople} seats left in the cinema.");
    //        Console.WriteLine($"Cinema income - {price} lv.");
    //    }
    //}




    class Program
    {
        static void Main(string[] args)
        {
            int places = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            string input = "";

            double billetPrice = 5;
            double billetSum = 0;
            double sum = 0;
            double peopleSum = 0;
            bool cinemaFull = false;

            while (true)
            {
                // Ако в залата се опитат да влязат повече хора от колкото
                // места са останали, то се счита че местата са изчерпани и програмата
                // трябва да приключи четенето на вход.
                if (places < (peopleSum + people))
                {
                    cinemaFull = true;
                    break;
                }

                peopleSum += people;


                //if (peopleSum > places)
                //{
                //    break;
                //}

                billetSum = billetPrice * people;

                if (people % 3 == 0)
                {
                    //if3 += 5;
                    billetSum -= 5;
                }

                sum += billetSum;

                input = Console.ReadLine();

                if (input == "Movie time!")
                {
                    break;
                }

                people = int.Parse(input);
            }


            //if (peopleSum <= places)
            if (cinemaFull == false)
            {
                Console.WriteLine($"There are {places - peopleSum} seats left in the cinema.");
                Console.WriteLine($"Cinema income - {sum} lv.");
            }
            else
            {
                Console.WriteLine($"The cinema is full.");
                Console.WriteLine($"Cinema income - {sum} lv.");
            }
        }
    }
}
