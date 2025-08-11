using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("10 Aug 2025", 30, 4.8),
            new Cycling("10 Aug 2025", 30, 9.7),
            new Swimming("10 Aug 2025", 30, 20)
        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}