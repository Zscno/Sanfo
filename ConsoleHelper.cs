using System;
using System.Diagnostics;

namespace Zscno.Sanfo
{
    internal static class ConsoleHelper
    {
        public static int GetLength()
        {
            bool isNotRightNumber;
            int length = 0;

            do
            {
                Console.WriteLine("Please enter the number of letters you want to generate:");
                try
                {
                    length = Convert.ToInt32(Console.ReadLine());
                    isNotRightNumber = false;
                }
                catch (Exception)
                {
                    ConsoleColor color = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please enter a right number.");
                    Console.ForegroundColor = color;
                    isNotRightNumber = true;
                }
            } while (isNotRightNumber);

            return length;
        }

        public static bool GetWhetherToContinue()
        {
            bool isContinue = false;
            bool isNotRight;
            string? temp;

            do
            {
                Console.WriteLine("Do you want to continue?[Y/N]");
                temp = Console.ReadLine();
                if (temp == "Y")
                {
                    isContinue = true;
                    isNotRight = false;
                }
                else if (temp == "N")
                {
                    isContinue = false;
                    isNotRight = false;
                }
                else
                {
                    ConsoleColor color = Console.BackgroundColor;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Please enter a right letter.");
                    Console.ForegroundColor = color;
                    isNotRight = true;
                }
            } while (isNotRight);

            return isContinue;
        }
    }
}