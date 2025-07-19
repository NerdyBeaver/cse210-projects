using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address eventAddress1 = new Address("101 University Ave", "Provo", "UT", "USA");
        Address eventAddress2 = new Address("Grand Ballroom", "New York", "NY", "USA");
        Address eventAddress3 = new Address("Central Park", "New York", "NY", "USA");

        Lecture lectureEvent = new Lecture(
            "The Future of AI",
            "An insightful lecture on the advancements and ethical considerations of Artificial Intelligence.",
            "2025-08-15",
            "10:00 AM",
            eventAddress1,
            "Dr. Alan Turing",
            150
        );
        events.Add(lectureEvent);

        Reception receptionEvent = new Reception(
            "Annual Alumni Mixer",
            "Connect with fellow alumni and network over refreshments.",
            "2025-09-20",
            "06:30 PM",
            eventAddress2,
            "alumni.rsvp@example.com"
        );
        events.Add(receptionEvent);

        OutdoorGathering outdoorEvent = new OutdoorGathering(
            "Summer Music Festival",
            "Enjoy live music from local bands in a relaxed outdoor setting.",
            "2025-07-25",
            "04:00 PM",
            eventAddress3,
            "Sunny with a high of 80°F"
        );
        events.Add(outdoorEvent);

        foreach (Event ev in events)
        {
            Console.WriteLine("--- Standard Details ---");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine("\n--- Full Details ---");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("\n--- Short Description ---");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine("\n--------------------------------------------------\n");
        }
    }
}