public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out _duration) || _duration <= 0)
        {
            Console.Write("Invalid input. Please enter a positive number for the duration: ");
            input = Console.ReadLine();
        }

        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        ConsoleWriteLine($"You have completed the {_activityName} Activity in {_duration} seconds.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerChars = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerChars[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            if (i >= spinnerChars.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b" + new string(' ', i.ToString().Length) + "\b");
        }
    }

    protected void ConsoleWriteLine(string message)
    {
        Console.Write("\r" + new string(' ', Console.WindowWidth - 1) + "\r" + message);
        Console.WriteLine();
    }
}
