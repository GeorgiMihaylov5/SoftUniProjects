using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            int symbol1 = 1;
            int symbol2 = 1;
            int symbol3 = (char)'a';
            int symbol4 = (char)'a';
            int counter = 1;

            int symbol5;
            if (symbol1 > symbol2)
                symbol5 = symbol1 + 1;
            else
                symbol5 = symbol2 + 1;

            string password = string.Empty;

            while (symbol1 < n)
            {
                for (int i = 0; i < l * l; i++)
                {
                    if (symbol1 > symbol2)
                        symbol5 = symbol1 + 1;
                    else
                        symbol5 = symbol2 + 1;

                    while (symbol5 <= n)
                    {
                        password = symbol1.ToString() + symbol2 + (char)symbol3 + (char)symbol4 + symbol5;
                        Console.Write(password + " ");
                        symbol5++;
                    }

                    if (symbol1 > symbol2)
                        symbol5 = symbol1 + 1;
                    else
                        symbol5 = symbol2 + 1;

                    if (counter == l)
                    {
                        symbol3++;
                        symbol4 = (char)'a';
                        counter = 1;
                    }
                    else
                    {
                        symbol4++;
                        counter++;
                    }
                }

                symbol3 = (char)'a';
                symbol4 = (char)'a';
                if (symbol1 > symbol2)
                    symbol5 = symbol1 + 1;
                else
                    symbol5 = symbol2 + 1;

                symbol2++;

                if (symbol2 >= n)
                {
                    symbol2 = 1;
                    symbol1++;
                }
            }
        }
    }
}
