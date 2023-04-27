using System;
class Journal
{
    List<Entry> entries;

    List<string> prompts;

    public string _prompt;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJounralEntry()
    {
        Console.WriteLine("");
    }

    public void SaveToCSV()
    {

    }

    public void LoadFromCSV()
    {

    }

    public string GetRandomPrompt()
    {
        return "What are you grateful for?";
        
    }
}