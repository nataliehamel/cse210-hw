using System;

class Program
{   
    private List<Goal> goals = new List<Goal>();
    public void Main()
    {
        LoadGoals();

        while (true)
        {
            DisplayGoals();
            Console.WriteLine();
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show score");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal();
                    break;

                case "2":
                    RecordEvent();
                    break;

                case "3":
                    ShowScore();
                    break;

                case "4":
                    SaveGoals();
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again. ");
                    break;
            }

            Console.WriteLine();
        }
    }

    private void LoadGoals()
    {
            
    }
    private void SaveGoals()
    {

    }
    private void DisplayGoals()
    {
        Console.WriteLine("Goals: ");
        foreach (Goal goal in goals)
        {
            Console.Write($"- [{(goal is ChecklistGoal ? " " + ((ChecklistGoal)goal)._timesCompleted : " ")}{(goal._points > 0 ? "+" : "-")}] {goal._goalName}");

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.Write($" ({checklistGoal._timesCompleted}/{checklistGoal._timesNeeded})");
            }

            Console.WriteLine();
        }
    }

    private void CreateNewGoal()
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Select goal type: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter the value of points: ");
                int points = int.Parse(Console.ReadLine());
                goals.Add(new SimpleGoal(name, points));
                break;

            case "2":
                Console.Write("Enter the value of points: ");
                points = int.Parse(Console.ReadLine());
                goals.Add(new EternalGoal(name, points));
                break;

            case "3":
                Console.Write("Enter the value of points: ");
                points = int.Parse(Console.ReadLine());
                Console.Write("Enter the needed amount of times to complete this goal: ");
                int timesNeeded = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus value of points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, points, timesNeeded, bonusPoints));
                break;

            default:
                Console.WriteLine("Invalid choice, please try again. ");
                break;
        }

        Console.WriteLine($"Goal '{name}' has been added.");
    }

    private void RecordEvent()
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Goal goal = goals.Find(g => g._goalName==name);

        if (goal != null)
        {
            goal.MarkComplete();
        }
        else
        {
            Console.WriteLine("Sorry goal not found! Please try again! ");
        }
    }

    private void ShowScore()
    {
        int score = 0;

        foreach (Goal goal in goals)
        {
            score += goal._points;
        }

        Console.WriteLine($"Your current score is: {score} points!");
    }
}
