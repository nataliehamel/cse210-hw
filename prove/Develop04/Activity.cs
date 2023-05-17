using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    } 

    public int GetDuration()
    {
        Console.Write("Enter the duration (in seconds): ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Invalid duration. Please enter a positive integer.");
            Console.Write("Enter the duration (in seconds): ");
        }
        return duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"----- {_name} -----");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine();
        Console.WriteLine("Get ready to begin...");
        Pause(2);
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine("----- Activity Completed -----");
        Console.Write("Good job! ");
        Console.Write($"You have completed the {_name}. ");
        Console.Write($"Duration: {_duration} seconds.");
        Pause(3);
    }

    public void Pause(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write("\rPausing... " + i);
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}