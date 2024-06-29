public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _target)
        {
            _isComplete = true;
            return _points + _bonus;
        }
        return _points;
    }

    public override string GetDetailsString() => 
        $"[{(_isComplete ? "X" : " ")}] {_name} ({_description}) -- Completed {_timesCompleted}/{_target} times";
}