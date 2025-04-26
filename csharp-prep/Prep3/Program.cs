using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        do
        {    
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(0,1000);
            float guessNumber = 0;
            int guesses = 0;

            do
            {    
                Console.Write("\nWhat is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = float.Parse(guess);


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
                    Console.WriteLine("\nYou guessed it!");
                }

                guesses ++;
            } while (guessNumber != magicNumber);

            Console.WriteLine($"It took you {guesses} guesses. ");
        
            Console.Write("\nWould you like to play again? ");
            answer = Console.ReadLine();

        }while (answer.ToLower() == "yes" || answer.ToLower() == "yes!" || answer.ToLower() == "y");
    }
}