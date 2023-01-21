namespace PersoTP_garrage;

internal class Garagist : Person
{
    private int Skills { get; set; }
    Garagist(string name, string firstName, int age) : base(name, firstName, age)
    {
        string Name = name;
        string FirstName = firstName;
        int Age = age;
    }

}
