public class ChecklistGoal : Goals
{
    protected int _targetCount;
    protected int _currentCount;
    protected int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int currentCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                Console.WriteLine("Congratulations! You've completed the checklist goal!");
                return _points + _bonusPoints;
            }
            else
            {
                return _points;
            }
        }

        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    public override string GetDetailsString()
    {
        string status = _currentCount >= _targetCount ? "[X]" : "[]";
        return $"{status} {_name} ({_description}) -- Completed {_currentCount}/{_targetCount} times";
    }
    public override string ToCSV()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_bonusPoints}|{_targetCount}|{_currentCount}";
    }
}