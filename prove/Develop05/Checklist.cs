class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.bonus = bonus;
        currentCount = 0;
    }

    public override bool IsComplete() => currentCount >= targetCount;

    public override int RecordEvent()
    {
        if (currentCount < targetCount)
        {
            currentCount++;
            if (currentCount == targetCount)
                return points + bonus;
            return points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        int barLength = 10;
        int filled = Math.Min(currentCount, targetCount);
        int filledBars = (int)((double)filled / targetCount * barLength);
        string progressBar = "[" + new string('=', filledBars) + new string(' ', barLength - filledBars) + "]";

        return $"[{(IsComplete() ? "X" : " ")}] {name} ({description}) {progressBar} {currentCount}/{targetCount}";
    }

    public override string Serialize()
    {
        return $"Checklist|{name}|{description}|{points}|{targetCount}|{bonus}|{currentCount}";
    }

    public override void Deserialize(string data)
    {
        var parts = data.Split('|');
        name = parts[1];
        description = parts[2];
        points = int.Parse(parts[3]);
        targetCount = int.Parse(parts[4]);
        bonus = int.Parse(parts[5]);
        currentCount = int.Parse(parts[6]);
    }

    public override string GetName() => name;
}
