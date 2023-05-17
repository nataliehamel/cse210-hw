using System;

public class ListingActivity : Activity
{
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Listing Activity";
        description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        duration = 50;
    }

    //select and display random prompt 
    //Who are people that you appreciate?
    //What are personal strengths of yours?
    //Who are people that you have helped this week?
    //When have you felt the Holy Ghost this month?
    //Who are some of your personal heroes?

    public void count()
    {
        Console.WriteLine("Begin thinking about your prompt.");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("List items");
        }; 
    }

    public void createList()
    {
        //user writes a list
    }

    public void displayList()
    {
        return createList;
    }

    public displayEndMessage() : base(endMessage)
    {
        return endMessage;
    }
}