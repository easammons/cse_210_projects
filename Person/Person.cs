
class Person
{
    private string _firstName;
    private string _lastname;
    private int _age;

    public Person()
    {
        _firstName = "";
        _lastname = "";
        _age = 0;


    }

    public Person(string firstName, string lastname, int age)
    {
        _firstName = firstName;
        _lastname = lastname;
        _age = age;
    }

    public string GetPersonInformation()
    {
        return $"{_firstName} {_lastname} age: {_age}";
    }

}