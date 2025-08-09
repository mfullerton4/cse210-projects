public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goals(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    //Abstract method to be overridden in derived classes
    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        return $"{_name} ({_description}) - {_points} points";
    }

    public abstract string ToCSV();

}