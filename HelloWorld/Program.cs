using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Hello, World!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("Enter something: ");
            string incomingText = Console.ReadLine();
            Console.WriteLine($"Entered: {incomingText}");
        }
    }
}