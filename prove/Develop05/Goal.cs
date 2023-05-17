using System;

public abstract class Goal
{
    private string _goalName;
    private string _recordEvent;
    private bool _isComplete;

    public Goal(string goalName, string recordEvent, bool isComplete)
    {
        _goalName = goalName;
        _recordEvent = recordEvent;
        _isComplete = isComplete;
    }

    public string GetGoal()
    {
        return _goalName;
    }

    public void SetGoal(string goalName)
    {
        _goalName = goalName;
    }

     public string GetRecordEvent()
    {
        return _recordEvent;
    }

    public void SetRecordEvent(string recordEvent)
    {
        _recordEvent = recordEvent;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public abstract int GetScore();
}