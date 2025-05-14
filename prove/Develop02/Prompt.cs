using System;
using System.Security.Cryptography;


public class Prompt
{
    List<string> prompts = new List<string>
        {
            "What am I most grateful for today? ",
            "What did I do to help someone today? ",
            "What is one thing that brought joy to me today or made me smile? ",
            "What did I mess up on today that I can be better at tomorrow? ",
            "What could I have done to have been kinder to others today? ",
            "What was the best part of my day? ",
            "What did I learn today? ",
            "What is the strongest emotion I felt today? ",
            "Who made the biggest impact on my day today? ",
            "What am I most proud of doing today? "
        };
     

    public string DisplayRandomPrompt()
    {
        Random randomGenerator = new Random();

        int random_number = randomGenerator.Next(1,11);
        string prompt = prompts[random_number];
        Console.WriteLine(prompt);

        return prompt;

    }
}