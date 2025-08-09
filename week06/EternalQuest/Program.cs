using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine($"\nYou have {manager.GetScore()} points.");
            Console.WriteLine("Menu options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Record Event");
            Console.WriteLine(" 4. Save Goals");
            Console.WriteLine(" 5. Load Goals");
            Console.WriteLine(" 6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    CreateGoal(manager);
                    break;
                case 2:
                    manager.DisplayGoals();
                    break;
                case 3:
                    Console.Write("Enter the number of the goal to record: ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndex))
                    {
                        manager.RecordEvent(goalIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    break;
                case 4:
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    break;
                case 5:
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Try again.");
                    break;

            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("Select goal type. ");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        string input = Console.ReadLine();

        if (!int.TryParse(input, out int typeChoice) || typeChoice < 1 || typeChoice > 3)
        {
            Console.WriteLine("Invalid goal type.");
            return;
        }
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goals goal = typeChoice switch
        {
            1 => new SimpleGoal(name, description, points, false),
            2 => new EternalGoal(name, description, points),
            3 => CreateChecklistGoal(name, description, points),
            _ => null
        };
        if (goal != null)
        {
            manager.Add(goal);
            Console.WriteLine("Goal added successfully.");
        }
    }
    static ChecklistGoal CreateChecklistGoal(string name, string description, int points)
    {
        Console.Write("Enter bonus points: ");
        int bonus = int.Parse(Console.ReadLine());
        Console.Write("Enter target count: ");
        int target = int.Parse(Console.ReadLine());

        return new ChecklistGoal(name, description, points, bonus, target, 0);
    }
}