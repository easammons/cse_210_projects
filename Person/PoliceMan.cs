
class PoliceMan : Person
{
    private string _weapons;
    private int _hoursWorked;
    private double _hourlyWage;
    public PoliceMan(string firstName, string lastname, int age, string weapons, int hoursWorked, int hourlyWage)
    : base(firstName, lastname, age)
    {
        _weapons = weapons;
        _hoursWorked = hoursWorked;
        _hourlyWage = hourlyWage;
    }

    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} :: {GetPersonInformation()}";
    }

    public override double GetPay()
    {
        double pay = _hourlyWage * _hoursWorked;
        if (_hoursWorked > 40)
        {
            pay += (_hoursWorked - 40) * _hourlyWage * 2;
        }
        return pay;
    }
}