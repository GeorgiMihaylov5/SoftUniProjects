using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            int coinsCount = 0;

            while (balance != 0)
            {
                balance = Math.Round(balance,2);
                if (balance >= 2)
                {
                    coinsCount++;
                    balance -= 2;
                }
                else if (balance >= 1)
                {
                    coinsCount++;
                    balance -= 1;
                }
                else if (balance >= 0.50)
                {
                    coinsCount++;
                    balance -= 0.50;
                }
                else if (balance >= 0.20)
                {
                    coinsCount++;
                    balance -= 0.20;
                }
                else if (balance >= 0.10)
                {
                    coinsCount++;
                    balance -= 0.10;
                }
                else if (balance >= 0.050)
                {
                    coinsCount++;
                    balance -= 0.050;
                }
                else if (balance >= 0.020)
                {
                    coinsCount++;
                    balance -= 0.020;
                }
                else if (balance >= 0.010)
                {
                    coinsCount++;
                    balance -= 0.010;
                }
            }
            Console.WriteLine(coinsCount);



            //decimal balance = decimal.Parse(Console.ReadLine());
            //int coinsCount = 0;

            //while (balance != 0)
            //{
            //    if (balance >= 2)
            //    {
            //        coinsCount++;
            //        balance -= 2;
            //    }
            //    else if (balance >= 1)
            //    {
            //        coinsCount++;
            //        balance -= 1;
            //    }
            //    else if (balance >= 0.50m)
            //    {
            //        coinsCount++;
            //        balance -= 0.50m;
            //    }
            //    else if (balance >= 0.20m)
            //    {
            //        coinsCount++;
            //        balance -= 0.20m;
            //    }
            //    else if (balance >= 0.10m)
            //    {
            //        coinsCount++;
            //        balance -= 0.10m;
            //    }
            //    else if (balance >= 0.050m)
            //    {
            //        coinsCount++;
            //        balance -= 0.050m;
            //    }
            //    else if (balance >= 0.020m)
            //    {
            //        coinsCount++;
            //        balance -= 0.020m;
            //    }
            //    else if (balance >= 0.010m)
            //    {
            //        coinsCount++;
            //        balance -= 0.010m;
            //    }
            //}
            //Console.WriteLine(coinsCount);
        }
    }
}
