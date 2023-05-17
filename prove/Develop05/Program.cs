using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        SimpleGoal g1 = new SimpleGoal("Simple Goal", " ", true, 1000);
        goals.Add(g1);

        EternalGoal g2 = new EternalGoal("Eternal Goal", " ", false, 100);
        goals.Add(g2);

        ChecklistGoal g3 = new ChecklistGoal("Checklist Goal", " ", true, 50);
        goals.Add(g3);

        foreach (Goal g in goals)
        {
            string goalName = g.GetGoal();
            int points = g.GetScore();
            Console.WriteLine($"The {goalName} goal has a total score of {points}.");
        }
    }
}