using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running("03 Nov 2022", 30, 3.0);
        activities.Add(runningActivity);

        Cycling cyclingActivity = new Cycling("04 Nov 2022", 45, 18.0);
        activities.Add(cyclingActivity);

        Swimming swimmingActivity = new Swimming("05 Nov 2022", 20, 40);
        activities.Add(swimmingActivity);

        Console.WriteLine("--- Exercise Tracking Summaries ---");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}