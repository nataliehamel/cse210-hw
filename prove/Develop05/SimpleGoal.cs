using System; 

public class SimpleGoal : Goal
{
    private int _points;

    public SimpleGoal(string goalName, string recordEvent, bool isComplete, int points) : base (goalName, recordEvent, isComplete)
    {
        _points = points;
    }

    public override int GetScore()
    {
        return 1000;
    }
}