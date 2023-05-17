using System;
public class ReflectingActivity : Activity
{ 
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
      name = "Reflecting Activity";
      description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
      duration = 50;
    }

    public string[] prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you overcame an obstacle.",
        "Think of a time when you trusted in the Lord."
    };

    public List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    }; 

    public void StartReflectionActivity()
    {
        DisplayStartMessage();
        Random random = new Random();
        for (int i=0; i < 50; i++)
        {
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            foreach (string question in questions)
            {
                Console.WriteLine();
                Console.WriteLine(question);
                Console.Write("Reflecting");
            }
        }
        DisplayEndMessage();
    }
}


