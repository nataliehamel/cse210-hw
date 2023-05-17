using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
 
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

        int menuUserInput = 0;
        List<string> menu = new List<string>
        {
            "Menu Options:",
            "1. Start breathing activity",
            "2. Start reflecting activity",
            "3. Start listing activity",
            "4. Quit",
            "Select a choice from the menu: "
        };

        while (menuUserInput != 4)
        {
            foreach(string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            menuUserInput = int.Parse(Console.ReadLine());
        };
        
        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("Done");
    }
}