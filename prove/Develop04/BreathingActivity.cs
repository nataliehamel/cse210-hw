using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Breathing Activity";
        description ="This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        duration = 30; 
    }

    public void breathIn()
    {
        Console.WriteLine("Breath In");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }; 
    }

    public void breathOut()
    {
        Console.WriteLine("Breath Out");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }; 
    }

    public displayEndMessage() : base(endMessage)
    {
        return endMessage;
    }
}