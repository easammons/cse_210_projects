
class Doctor : Person
{
    private string _tools;
    public Doctor(string firstName, string lastname, int age, string tools)
    : base(firstName, lastname, age)
    {
        _tools = tools;
    }

    public string GetDoctorInformation()
    {
        return $"Tools: {_tools} :: {GetPersonInformation()}";
    }
}