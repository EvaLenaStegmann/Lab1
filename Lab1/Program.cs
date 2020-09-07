using System;
using System.Diagnostics.CodeAnalysis;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            if (args.Length > 0)
            {
                input = args[0];
            }

            ConsoleColor currentForeground = Console.ForegroundColor;
            ConsoleColor currentBackground = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            long sum = 0;

            for (int currentPos = 0; currentPos < input.Length; currentPos++)
            {
                int alsoFoundAt = input.IndexOf(input[currentPos], currentPos + 1);
                if (alsoFoundAt > currentPos && long.TryParse(input.Substring(currentPos, alsoFoundAt - currentPos + 1), out long foundNumber) && input[currentPos] != ' ')
                {
                    Console.Write(input.Substring(0, currentPos));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(foundNumber);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(input.Substring(alsoFoundAt + 1));

                    sum += foundNumber;
                }              
            }

            Console.WriteLine("");
            Console.WriteLine($"Total = {sum}");

            Console.ForegroundColor = currentForeground;
            Console.BackgroundColor = currentBackground;
        }
    }
}

