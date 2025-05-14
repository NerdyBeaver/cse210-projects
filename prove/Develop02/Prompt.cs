using System;
using System.Security.Cryptography;


public class Prompt
{
    List<string> prompts = new List<string>
        {
            "Foo",
            "Bar",
            "Baz",
            "Qux",
            "Quux"
        };
     

    public string DisplayRandomPrompt()
    {
        Random randomGenerator = new Random();

        int random_number = randomGenerator.Next(1,6);
        string prompt = prompts[random_number];
        Console.WriteLine(prompt);

        return prompt;

    }
}