
public class Assignment
{
    private string _stuName;
    private string _topic;

    public Assignment(string stuName, string topic)
    {
        _stuName = stuName;
        _topic = topic;
    }

        public string GetStudentName()
    {
        return _stuName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _stuName + " - " + _topic;
    }
}
