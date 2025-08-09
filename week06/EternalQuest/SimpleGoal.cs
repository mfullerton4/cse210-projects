public class SimpleGoal : Goals
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool _isComplete) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }
    public bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {_name} ({_description})";
    }

    public override string ToCSV()
    {
        return $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";
    }
}