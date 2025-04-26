using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string inputNumber = Console.ReadLine();
        int magicNumber = int.Parse(inputNumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);

        if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower");
        }

        else if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("You guessed it!");
        }









    }
}