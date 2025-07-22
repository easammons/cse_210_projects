class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override bool IsComplete() => false;

    public override int RecordEvent() => points;

    public override string GetStatus()
    {
        return $"[∞] {name} ({description})";
    }

    public override string Serialize()
    {
        return $"Eternal|{name}|{description}|{points}";
    }

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        name = parts[1];
        description = parts[2];
        points = int.Parse(parts[3]);
    }

    public override string GetName() => name;
}
