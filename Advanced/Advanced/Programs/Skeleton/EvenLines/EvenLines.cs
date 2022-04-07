namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            char[] symbols = { '-', ',', '.', '!', '?' };

            StringBuilder sb = new StringBuilder();
            using (StreamReader stream = new StreamReader(inputFilePath))
            {
                int index = 0;
                string currentText = stream.ReadLine();
                while (currentText != null)
                {
                    if (index % 2 == 0)
                    {
                        foreach (var item in symbols)
                        {
                            currentText = currentText.Replace(item, '@');
                        }

                        currentText = string.Join(" ", currentText.Split().Reverse());
                        sb.AppendLine(currentText);
                    }
                    index++;
                    currentText = stream.ReadLine();
                }
            }

            return sb.ToString().TrimEnd();
        }
        private static string ReverseWords(string replacedSymbols)
        {
            throw new NotImplementedException();
        }

        private static string ReplaceSymbols(string line)
        {
            throw new NotImplementedException();
        }
    }

}
