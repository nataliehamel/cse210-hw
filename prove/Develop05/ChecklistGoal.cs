using System; 

public class ChecklistGoal : Goal
{
   public int _timesCompleted;
   public int _timesNeeded;
   private int _bonusPoints;

   public ChecklistGoal(string goalName, int points, int timesNeeded, int bonusPoints)
   {
        _goalName = goalName;
        _points = points;
        this._timesNeeded = timesNeeded;
        this._bonusPoints = bonusPoints;
   }

    public override void MarkComplete()
    {
        _timesCompleted++;

        Console.WriteLine($"You completed '{_goalName}' ({_timesCompleted}/{_timesNeeded})! You have earned {_points} points!" );

        if (_timesCompleted == _timesNeeded)
        {
            Console.WriteLine($"Congrats!! You have reached the goal '{_goalName}' and have earned a bonus of {_bonusPoints} points! ");
            _points += _bonusPoints;
        }
    }
}