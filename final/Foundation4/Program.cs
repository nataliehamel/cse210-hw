using System;

class Program
{
    static void Main(string[] args)
    {
        List<activity> activities = new List<activity>();

        //create activity of each type
        activities.Add(new runningActivity(new DateTime(2023, 5, 12), 45, 4.0));
        activities.Add(new cyclingActivity (new DateTime(2023, 5, 24), 30, 9.7));
        activities.Add(new swimmingActivity(new DateTime(2023, 5, 29), 45, 80));


        Console.WriteLine("Exercise Journal:");

        //summaries for each activity
        foreach (activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}