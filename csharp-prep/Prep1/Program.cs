using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("\nWhat is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.Write("\n");
        Console.Write($"Your name is {last_name}, {first_name} {last_name}.");


    }
}