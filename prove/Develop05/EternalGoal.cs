using System; 

public class EternalGoal : Goal
{
    private int _points;

    public EternalGoal(string goalName, string recordEvent, bool isComplete, int points) : base (goalName, recordEvent, isComplete)
    {
        _points = points;
    }

    public override int GetScore()
    {
        return 100;
    }
}