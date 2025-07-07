class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        Console.Clear();
        ConsoleWriteLine("Clear your mind and focus on your breathing.");
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            int breathDuration = 4;
            for (int i = 0; i < breathDuration; i++)
            {
                Console.Write(" .");
                Thread.Sleep(1000);
            }
            Console.Write("\b \b\b \b\b \b\b \b");
            Console.WriteLine();

            if (DateTime.Now >= endTime) break;

            Console.Write("Breathe out...");
            for (int i = 0; i < breathDuration; i++)
            {
                Console.Write(" .");
                Thread.Sleep(1000);
            }
            Console.Write("\b \b\b \b\b \b\b \b");
            Console.WriteLine();

            if (DateTime.Now >= endTime) break;
        }

        DisplayEndingMessage();
    }
}