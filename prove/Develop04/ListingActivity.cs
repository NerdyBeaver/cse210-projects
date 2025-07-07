class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    private string GetRandomPrompt()
    {
        return _prompts[_random.Next(_prompts.Count)];
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        ConsoleWriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        ConsoleWriteLine("Go!");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        ConsoleWriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
}