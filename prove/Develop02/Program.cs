using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        Journal journal = new Journal();
        
        Console.WriteLine("Welcome to your journal! ");
        Console.WriteLine($"If you write an entry, your streak will be {journal.StreakTracker().streak} days of journaling!");
        Console.WriteLine($"Your longest streak is {journal.StreakTracker().largest_streak} days!");

        while (choice != 5)
        {
            Console.WriteLine("\nPlease select one of the following choices (just type the integer): \n");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Load a file to display");
            Console.WriteLine("4. Save the current entries to a file");
            Console.WriteLine("5. Quit the program");
            Console.WriteLine("\nWhat would you like to do? \n");


            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.LoadFromFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    journal.StreakTracker();
                    break;
                case 5: //Simply here so I can have a default that won't print an error when the user enters 5
                    Console.WriteLine($"Thanks for journaling! Your streak is currently {journal.StreakTracker().streak} days!");
                    break;
                default:
                    Console.WriteLine("Not a valid option. Try again. ");
                    break;
            }
        }
    }
}