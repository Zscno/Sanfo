using System;

namespace Zscno.Sanfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isContinue;
            ConsoleColor color = Console.ForegroundColor;

            do
            {
                GetRandomLetters get = new();
                int length = ConsoleHelper.GetLength();
                Console.WriteLine("Generate...");
                string results = get.Get(length);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(results);
                Console.ForegroundColor = color;
                isContinue = ConsoleHelper.GetWhetherToContinue();
            } while (isContinue);
        }
    }
}
