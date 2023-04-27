using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int menuUserInput = 0;

        List<string> menu = new List<string>
            {
                "Please select one of the following choices:",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
                "What would you like to do? "
            };

        
        var random = new Random();
        List<string> prompts = new List<string>
            {
                "When were you the happiest today and why?",
                "If you could redo one thing today, what would it be?",
                "How did you treat yourself today?",
                "What did you do spiritually today?",
                "What are you grateful for?",
                "How did you serve someone today?",
                "Who was the most interesting person I intereacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?"
            };
        int index = random.Next(prompts.Count);
        Console.WriteLine(prompts[index]);



        while (menuUserInput != 5)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());

        }
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        
    }
}