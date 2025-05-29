using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Proverbs"; //Default scripture
        int chapter = 3;
        string start = "5";
        string end = "6";
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";


        Reference reference;

        Console.Write("What is the book? ");
        book = Console.ReadLine();

        Console.Write("What is the chapter? ");
        chapter = int.Parse(Console.ReadLine());

        Console.Write("Are there multiple verses? (Y/N) ");
        string response = Console.ReadLine();

        if (response.ToLower() == "n" || response.ToLower() == "no")
        {
            Console.Write("What is the verse number? ");
            start = Console.ReadLine();
            reference = new Reference(book, chapter, start);
        }

        else
        {
            Console.Write("What is the first verse number? ");
            start = Console.ReadLine();

            Console.Write("What is the last verse number? ");
            end = Console.ReadLine();
            reference = new Reference(book, chapter, start, end);
        }

        Console.WriteLine("Please enter the scripture text. ");
        scriptureText = Console.ReadLine();
        
        Scripture scripture = new Scripture(reference, scriptureText);

        string input = "";

        while (input.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Good job!");
                input = "quit";
            }

            else
            {
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
                input = Console.ReadLine();
            }

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
         
        }
    }
}