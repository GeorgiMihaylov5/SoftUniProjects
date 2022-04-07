using System;

namespace SpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string num = i.ToString();
                string printedNum = string.Empty;

                for (int j = 0; j < num.Length; j++)
                {
                    int currentDigit = int.Parse(num[j].ToString());
                    if (currentDigit != 0)
                    {
                        if (n % currentDigit == 0)
                            printedNum += num[j];
                        else
                            break;
                    }
                }
                if(printedNum.Length == 4)
                    Console.Write(printedNum + " ");
            }
        }
    }
}
