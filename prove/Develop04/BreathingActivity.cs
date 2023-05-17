using System;
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
      name = "Breathing Activity";
      description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
      duration = 20;
    }
    public void StartBreathingActivity()
    {
        DisplayStartMessage();
        for (int i=0; i < 20; i += 2)
        {
            Console.WriteLine("Breathe in... ");
            Pause(1);
            Console.WriteLine("Breathe out... ");
            Pause(1);
        }

        DisplayEndMessage();
    }
}