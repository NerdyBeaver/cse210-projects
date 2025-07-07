
        class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.RunActivity();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Press any key to try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}

    }
