using System; 

public class SimpleGoal : Goal
{
   public SimpleGoal(string goalName, int points)
   {
    _goalName = goalName;
    _points = points;
   }

    public override void MarkComplete()
    {
        Console.WriteLine($"Goal '{_goalName}' completed! You have earned {_points} points!" );
    }
}