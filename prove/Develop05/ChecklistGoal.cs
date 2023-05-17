using System; 

public class ChecklistGoal : Goal
{
    private int _points;

    public ChecklistGoal(string goalName, string recordEvent, bool isComplete, int points) : base (goalName, recordEvent, isComplete)
    {
        _points = points;
    }

    public override int GetScore()
    {
        return 50;
    }
}