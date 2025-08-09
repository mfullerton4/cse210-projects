public class EternalGoal : Goals
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        //Always award points, no completion tracking
        return _points;
    }

    public override string GetDetailsString()
    {
        //Eternal goals are never complete, so always show as incomplete
        return $"[ ] {_name} ({_description})";
    }
    public string ToCSV()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}