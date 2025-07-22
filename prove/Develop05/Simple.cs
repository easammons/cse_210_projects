class SimpleGoal : Goal
{
    private bool completed;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        completed = false;
    }

    public override bool IsComplete() => completed;

    public override int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return $"[{(completed ? "X" : " ")}] {name} ({description})";
    }

    public override string Serialize()
    {
        return $"Simple|{name}|{description}|{points}|{completed}";
    }

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        name = parts[1];
        description = parts[2];
        points = int.Parse(parts[3]);
        completed = bool.Parse(parts[4]);
    }

    public override string GetName() => name;
}