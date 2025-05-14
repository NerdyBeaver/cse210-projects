using System;
using System.Security.Cryptography;


public class Prompt
{
    public List<string> _prompts = new List<string>{"Foo" ,"bar", "popo", "i", "u"};

    public void DisplayRandomPrompt()
    {
        Random randomGenerator = new Random();

        int random_number = randomGenerator.Next(1,6);
        string random_prompt = _prompts[random_number];
        Console.WriteLine($"Today's prompt is: {random_prompt}");

    }
}