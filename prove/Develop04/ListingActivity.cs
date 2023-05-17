using System;

public class ListingActivity : Activity
{
    public string[] prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        "Who do you look up to?",
        "When have you served your family this month?",
        "What do you do on Sundays to honor the Sabbath?"
    };
    
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        duration = 50;
    }

    public void StartListingActivity()
    {
        DisplayStartMessage();
        Random random = new Random();
        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        Console.WriteLine("Begin thinking about your prompt.");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("List items");
        };
        Console.WriteLine();
        Console.WriteLine($"Number of items listed: {GetDuration}");
        DisplayEndMessage();
    }
}