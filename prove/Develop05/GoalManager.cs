public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _score += _goals[index].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public int GetScore() => _score;

    // Save and load methods would be implemented here
}
