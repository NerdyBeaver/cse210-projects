using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Proverbs";
        int chapter = 3;
        string start = "5";
        string end = "6";

        Reference reference = new Reference(book, chapter, start, end);

        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        string input = "";

        while (input.ToLower() == "")
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