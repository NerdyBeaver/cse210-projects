using System;

class Program
{
    static void Main(string[] args)
    {
        int guessNumber;
        int magicNumber;

         Console.Write("What is the magic number? ");
        string inputNumber = Console.ReadLine();
        magicNumber = int.Parse(inputNumber);

        do
        {    
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);


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

        } while (guessNumber != magicNumber);











    }
}