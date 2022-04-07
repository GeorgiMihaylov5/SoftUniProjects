using System;
using System.Text;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num = ushort.Parse(Console.ReadLine());
            StringBuilder st = new StringBuilder();

            if(num % 10 == 0)
                st.Append($"The number is divisible by {10}");
            else if(num % 7 == 0)
                st.Append($"The number is divisible by {7}");
            else if(num % 6 == 0)
                st.Append($"The number is divisible by {6}");
            else if (num % 3 == 0)
                st.Append($"The number is divisible by {3}");
            else if (num % 2 == 0)
                st.Append($"The number is divisible by {2}");
            else
                st.Append("Not divisible");
            Console.WriteLine(st);
        }
    }
}
