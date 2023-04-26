
class Journal
{
    List<Entry> entries;

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
        return "";
    }
}