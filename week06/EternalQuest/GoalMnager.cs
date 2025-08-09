public class GoalManager
{
    private List<Goals> _goals = new List<Goals>();
    private int _score = 0;

    public void Add(Goals goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            int pointsEarned = _goals[goalIndex].RecordEvent();
            _score += pointsEarned;
        }

    }
    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goals goal in _goals)
            {
                writer.WriteLine(goal.ToCSV());
            }
        }
    }
    public void LoadGoals(string filename)
    {
        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            Goals goal = type switch
            {
                "SimpleGoal" => new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])),
                "EternalGoal" => new EternalGoal(parts[1], parts[2], int.Parse(parts[3])),
                "ChecklistGoal" => new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])),
                _ => null
            };
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }
    }
    public int GetScore()
    {
        return _score;
    }
}