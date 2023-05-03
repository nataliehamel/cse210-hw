using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(scriptureReference, "Trust in the lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");
        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to contine or 'quit' to finish: ");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }
        Console.WriteLine(scripture.GetScripture());            
        Console.WriteLine();
        Console.WriteLine("I hope you enjoyed this memorizing process and hopefully it worked!");
    }
}

//To exceed the requirements I did the stretch challenge and made my program randomly chose from the words that weren't already hidden.