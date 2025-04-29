using System;

namespace Project1_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Greeting App!");
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
